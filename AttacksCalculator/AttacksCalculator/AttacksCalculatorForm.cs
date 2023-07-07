namespace AttacksCalculator
{
    public partial class AttacksCalculatorForm : Form
    {
        public AttacksCalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToHitComboBox.SelectedIndex = 1;
            ToWoundComboBox.SelectedIndex = 2;
            ArmorComboBox.SelectedIndex = 1;
        }

        private void Recalculate(object sender, EventArgs e)
        {
            if (int.TryParse(AttacksTextbox.Text, out var attacks) is false
                || ToHitComboBox.SelectedIndex > 4 || ToHitComboBox.SelectedIndex < 0
                || ToWoundComboBox.SelectedIndex > 4 || ToWoundComboBox.SelectedIndex < 0
                || ArmorComboBox.SelectedIndex > 4 || ArmorComboBox.SelectedIndex < 0)
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
            double woundsDevastated = DevastatingWoundsCheckbox.Checked ? CalculateCriticalWounds(hitsCalulated + (SustainedHitsCheckbox.Checked ? hitsSustained : 0)) : 0;
            WoundsTextbox.Text = woundsCalculated.ToString("F3");
            if (LethalHitsCheckbox.Checked)
            {
                WoundsTextbox.Text += $" +{hitsLethal:F2}L";
            }

            double damageCalculated = DefenseDiceResult(woundsCalculated + (LethalHitsCheckbox.Checked ? hitsLethal : 0), ArmorComboBox.SelectedIndex);
            DamageTextbox.Text = damageCalculated.ToString("F3");
            if (DevastatingWoundsCheckbox.Checked)
            {
                DamageTextbox.Text += $" +{woundsDevastated:F2}D";
                DamageFinalTextbox.Text = (damageCalculated + woundsDevastated).ToString("F3");
            }
            else
            {
                DamageFinalTextbox.Text = string.Empty;
            }
        }

        private double CalculateCriticalWounds(double attacks)
        {
            return CalculateWounds(attacks, 4, false);
        }

        private double CalculateCriticalHits(double attacks)
        {
            return CalculateHits(attacks, 4, false);
        }

        private double CalculateHits(double attacks, int index, bool lethal)
        {
            if (radioButtonHitsNoReroll.Checked)
            {
                return AttackDiceResult(attacks, index, lethal);
            }

            if (radioButtonHitsRerollOnes.Checked)
            {
                return AttackDiceResult(attacks, index, lethal) + AttackDiceResult(attacks / 6, index, lethal);
            }

            if (radioButtonHitsFullReroll.Checked)
            {
                var successfulHits = AttackDiceResult(attacks, index, lethal);
                return successfulHits + AttackDiceResult(attacks - successfulHits, index, lethal);
            }

            throw new NotImplementedException();
        }

        private double CalculateWounds(double hits, int index, bool devastating)
        {
            if (radioButtonWoundNoReroll.Checked)
            {
                return WoundDiceResult(hits, index, devastating);
            }

            if (radioButtonWoundRerollOnes.Checked)
            {
                return WoundDiceResult(hits, index, devastating) + WoundDiceResult(hits / 6, index, devastating);
            }

            if (radioButtonWoundFullReroll.Checked)
            {
                var successfulWounds = WoundDiceResult(hits, index, devastating);
                return successfulWounds + WoundDiceResult(hits - successfulWounds, index, devastating);
            }

            throw new NotImplementedException();
        }

        private static double AttackDiceResult(double attacks, int index, bool lethal)
        {
            if (lethal is false)
            {
                return index switch
                {
                    0 => attacks * 5 / 6,
                    1 => attacks * 2 / 3,
                    2 => attacks / 2,
                    3 => attacks / 3,
                    4 => attacks / 6,
                    _ => throw new NotImplementedException(),
                };
            }

            return index switch
            {
                0 => attacks * 2 / 3,
                1 => attacks / 2,
                2 => attacks / 3,
                3 => attacks / 6,
                4 => 0,
                _ => throw new NotImplementedException(),
            };
        }

        private static double WoundDiceResult(double attacks, int index, bool devastating)
        {
            if (devastating is false)
            {
                return index switch
                {
                    0 => attacks * 5 / 6,
                    1 => attacks * 2 / 3,
                    2 => attacks / 2,
                    3 => attacks / 3,
                    4 => attacks / 6,
                    _ => throw new NotImplementedException(),
                };
            }

            return index switch
            {
                0 => attacks * 2 / 3,
                1 => attacks / 2,
                2 => attacks / 3,
                3 => attacks / 6,
                4 => 0,
                _ => throw new NotImplementedException(),
            };
        }

        private static double DefenseDiceResult(double attacks, int index) => index switch
        {
            4 => attacks * 5 / 6,
            3 => attacks * 2 / 3,
            2 => attacks / 2,
            1 => attacks / 3,
            0 => attacks / 6,
            _ => throw new NotImplementedException(),
        };
    }
}