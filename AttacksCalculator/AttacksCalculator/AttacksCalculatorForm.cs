using AttacksCalculator.Methods;

namespace AttacksCalculator
{
    public partial class AttacksCalculatorForm : Form
    {
        public AttacksCalculatorForm()
        {
            InitializeComponent();
        }

        internal void AttacksCalculatorFormLoad(object sender, EventArgs e)
        {
            ToHitComboBox.SelectedIndex = 1;
            ToWoundComboBox.SelectedIndex = 2;
            ArmorComboBox.SelectedIndex = 1;
            FnpComboBox.SelectedIndex = 0;
        }

        internal void Recalculate(object sender, EventArgs e)
        {
            if (int.TryParse(AttacksTextbox.Text, out var attacks) is false
                || ToHitComboBox.SelectedIndex > 4 || ToHitComboBox.SelectedIndex < 0
                || ToWoundComboBox.SelectedIndex > 4 || ToWoundComboBox.SelectedIndex < 0
                || ArmorComboBox.SelectedIndex > 5 || ArmorComboBox.SelectedIndex < 0
                || FnpComboBox.SelectedIndex > 3 || FnpComboBox.SelectedIndex < 0)
            {
                return;
            }

            double hitsLethal = CalculateCriticalHits(attacks);
            double hitsSustained = CalculateCriticalHits(attacks);
            double hitsCalulated = CalculateHits(attacks, ToHitComboBox.SelectedIndex, LethalHitsCheckbox.Checked);

            HitsTextbox.Text = hitsCalulated.ToString("F3");
            if (SustainedHitsCheckbox.Checked)
            {
                HitsTextbox.Text += $" +{hitsSustained:F2}S";
            }

            double woundsCalculated = CalculateWounds(hitsCalulated + (SustainedHitsCheckbox.Checked ? hitsSustained : 0),
                ToWoundComboBox.SelectedIndex,
                DevastatingWoundsCheckbox.Checked);
            double woundsDevastated = CalculateDevastatingWounds(hitsSustained, hitsCalulated, ToWoundComboBox.SelectedIndex);

            WoundsTextbox.Text = woundsCalculated.ToString("F3");
            if (LethalHitsCheckbox.Checked)
            {
                WoundsTextbox.Text += $" +{hitsLethal:F3}L";
            }

            double damageCalculated = DefenseDiceResult(woundsCalculated + (LethalHitsCheckbox.Checked ? hitsLethal : 0), ArmorComboBox.SelectedIndex);
            DamageTextbox.Text = damageCalculated.ToString("F3");
            if (DevastatingWoundsCheckbox.Checked)
            {
                DamageTextbox.Text += $" +{woundsDevastated:F3}D";
            }

            double damageFelt = GetDamageFelt(woundsDevastated, damageCalculated);

            DamageFinalTextbox.Text = damageFelt.ToString("F3");
        }

        internal double CalculateDevastatingWounds(double hitsSustained, double hitsCalulated, int index)
        {
            if (DevastatingWoundsCheckbox.Checked is false)
            {
                return 0;
            }

            double hits = hitsCalulated + (SustainedHitsCheckbox.Checked ? hitsSustained : 0);
            var successfulWounds = hits / 6;

            if (radioButtonWoundNoReroll.Checked)
            {
                return successfulWounds;
            }

            if (radioButtonWoundRerollOnes.Checked)
            {
                return successfulWounds + (hits / 36);
            }

            if (radioButtonWoundFullReroll.Checked)
            {
                return index switch
                {
                    0 => successfulWounds + (hits / 36),
                    1 => successfulWounds + (hits * 2 / 36),
                    2 => successfulWounds + (hits * 3/ 36),
                    3 => successfulWounds + (hits * 4 / 36),
                    4 => successfulWounds + (hits * 5 / 36),
                    _ => throw new NotImplementedException(),
                };
            }

            throw new NotImplementedException();
        }

        internal double GetDamageFelt(double woundsDevastated, double damageCalculated)
        {
            if (OnlyMwFnpCheckBox.Checked)
            {
                return damageCalculated + Calculator.CalculateFnp(woundsDevastated, FnpComboBox.SelectedIndex);
            }
            else
            {
                return Calculator.CalculateFnp(damageCalculated + woundsDevastated, FnpComboBox.SelectedIndex);
            }
        }

        internal double CalculateWounds(double hits, int index, bool devastating)
        {
            if (radioButtonWoundNoReroll.Checked)
            {
                return Calculator.WoundDiceResult(hits, index, devastating);
            }

            if (radioButtonWoundRerollOnes.Checked)
            {
                return Calculator.WoundDiceResult(hits, index, devastating) + Calculator.WoundDiceResult(hits / 6, index, devastating);
            }

            if (radioButtonWoundFullReroll.Checked)
            {
                return Calculator.WoundWithFullReroll(hits, index, devastating);
            }

            throw new NotImplementedException();
        }

        internal double CalculateCriticalHits(double attacks)
        {
            return CalculateHits(attacks, 4, false);
        }

        internal double CalculateHits(double attacks, int index, bool lethal)
        {
            if (radioButtonHitsNoReroll.Checked)
            {
                return Calculator.AttackDiceResult(attacks, index, lethal);
            }

            if (radioButtonHitsRerollOnes.Checked)
            {
                return Calculator.AttackDiceResult(attacks, index, lethal) + Calculator.AttackDiceResult(attacks / 6, index, lethal);
            }

            if (radioButtonHitsFullReroll.Checked)
            {
                var successfulHits = Calculator.AttackDiceResult(attacks, index, lethal);
                return successfulHits + Calculator.AttackDiceResult(attacks - successfulHits, index, lethal);
            }

            throw new NotImplementedException();
        }

        internal static double DefenseDiceResult(double attacks, int index) => index switch
        {
            5 => attacks,
            4 => attacks * 5 / 6,
            3 => attacks * 2 / 3,
            2 => attacks / 2,
            1 => attacks / 3,
            0 => attacks / 6,
            _ => throw new NotImplementedException(),
        };
    }
}