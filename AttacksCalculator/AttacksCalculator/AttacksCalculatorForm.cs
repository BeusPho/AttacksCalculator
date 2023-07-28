using AttacksCalculator.Entities;
using AttacksCalculator.Methods;
using System;
using System.Collections;
using System.Reflection;

namespace AttacksCalculator
{
    public partial class AttacksCalculatorForm : Form
    {
        private bool IsChartCalculated = false;
        private int SustainedMultiplicator = 0;

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
            CritHitsComboBox.SelectedIndex = 0;
            CritWoundsComboBox.SelectedIndex = 0;
        }

        internal void RadioButtonHitsFullRerollClicked(object sender, EventArgs e)
        {
            FishCritHitsCheckBox.Enabled = true;
            Recalculate(sender, e);
        }

        internal void RadioButtonHitsFullRerollDeselected(object sender, EventArgs e)
        {
            FishCritHitsCheckBox.Enabled = false;
            FishCritHitsCheckBox.Checked = false;
            Recalculate(sender, e);
        }

        internal void RadioButtonWoundsFullRerollClicked(object sender, EventArgs e)
        {
            FishCritWoundsCheckBox.Enabled = true;
            Recalculate(sender, e);
        }

        internal void RadioButtonWoundsFullRerollDeselected(object sender, EventArgs e)
        {
            FishCritWoundsCheckBox.Enabled = false;
            FishCritWoundsCheckBox.Checked = false;
            Recalculate(sender, e);
        }

        internal void Recalculate(object sender, EventArgs e)
        {
            if (int.TryParse(AttacksTextbox.Text, out var attacks) is false
                || ToHitComboBox.SelectedIndex > 4 || ToHitComboBox.SelectedIndex < 0
                || ToWoundComboBox.SelectedIndex > 4 || ToWoundComboBox.SelectedIndex < 0
                || ArmorComboBox.SelectedIndex > 5 || ArmorComboBox.SelectedIndex < 0
                || FnpComboBox.SelectedIndex > 3 || FnpComboBox.SelectedIndex < 0
                || SustainedHitsCustomValue_RadioButton.Checked && int.TryParse(SustainedHitsValueTextBox.Text, out _) is false
                )
            {
                return;
            }

            var hitRerollResult = CaclulateHitRoll(attacks);
            var hitsPostReroll = AutoHitsCheckbox.Checked ? attacks : hitRerollResult.Item1;
            var hitCritsPostReroll = hitRerollResult.Item2;

            HitsTextbox.Text = hitsPostReroll.ToString("F3");
            var sustainedAmmount = hitCritsPostReroll * SustainedMultiplicator;
            if (sustainedAmmount > 0)
            {
                HitsTextbox.Text += $" +{sustainedAmmount:F2}S";
            }

            var hitsToCalculateWounds = hitsPostReroll + sustainedAmmount;
            var woundRerollResult = CaclulateWoundRoll(hitsToCalculateWounds);
            var woundsPostReroll = woundRerollResult.Item1;
            var woundCritsPostReroll = woundRerollResult.Item2;

            WoundsTextbox.Text = woundsPostReroll.ToString("F3");
            if (LethalHitsCheckbox.Checked)
            {
                WoundsTextbox.Text += $" +{hitCritsPostReroll:F3}L";
            }

            double damageCalculated = Calculator.DefenseDiceResult(woundsPostReroll + (LethalHitsCheckbox.Checked ? hitCritsPostReroll : 0), ArmorComboBox.SelectedIndex);
            DamageTextbox.Text = damageCalculated.ToString("F3");
            if (DevastatingWoundsCheckbox.Checked)
            {
                DamageTextbox.Text += $" +{woundCritsPostReroll:F3}D";
            }

            double damageFelt = GetDamageFelt(DevastatingWoundsCheckbox.Checked ? woundCritsPostReroll : 0, damageCalculated);

            DamageFinalTextbox.Text = damageFelt.ToString("F3");
        }

        private Tuple<double, double> CaclulateHitRoll(int attacks)
        {
            var hitsPreReroll = CalculateHits(attacks);
            var critsPreReroll = CalculateCriticalHits(attacks);

            double hitsPostReroll;
            double critsPostReroll;

            if (radioButtonHitsRerollOnes.Checked)
            {
                hitsPostReroll = hitsPreReroll + CalculateHits(attacks / 6);
                critsPostReroll = critsPreReroll + CalculateCriticalHits(attacks / 6);
            }
            else if (radioButtonHitsFullReroll.Checked)
            {
                if (FishCritHitsCheckBox.Checked is false)
                {
                    hitsPostReroll = hitsPreReroll + CalculateHits(attacks - hitsPreReroll);
                    critsPostReroll = critsPreReroll + CalculateCriticalHits(attacks - hitsPreReroll);
                }
                else if (FishCritHitsCheckBox.Checked)
                {
                    hitsPostReroll = critsPreReroll + CalculateHits(attacks - critsPreReroll);
                    critsPostReroll = critsPreReroll + CalculateCriticalHits(attacks - critsPreReroll);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else if (radioButtonHitsNoReroll.Checked)
            {
                hitsPostReroll = hitsPreReroll;
                critsPostReroll = critsPreReroll;
            }
            else
            {
                throw new NotImplementedException();
            }

            var hitsMinusLethalPostReroll = hitsPostReroll - (LethalHitsCheckbox.Checked ? critsPostReroll : 0);
            return new Tuple<double, double>(hitsMinusLethalPostReroll, critsPostReroll);
        }

        private Tuple<double, double> CaclulateWoundRoll(double hits)
        {
            var woundsPreReroll = CalculateWounds(hits);
            var woundCritsPreReroll = CalculateCriticalWounds(hits);

            double woundsPostReroll;
            double woundCritsPostReroll;

            if (radioButtonWoundRerollOnes.Checked)
            {
                woundsPostReroll = woundsPreReroll + CalculateWounds(hits / 6);
                woundCritsPostReroll = woundCritsPreReroll + CalculateCriticalWounds(hits / 6);
            }
            else if (radioButtonWoundFullReroll.Checked)
            {
                if (FishCritWoundsCheckBox.Checked is false)
                {
                    woundsPostReroll = woundsPreReroll + CalculateWounds(hits - woundsPreReroll);
                    woundCritsPostReroll = woundCritsPreReroll + CalculateCriticalWounds(hits - woundsPreReroll);
                }
                else if (FishCritWoundsCheckBox.Checked)
                {
                    woundsPostReroll = woundCritsPreReroll + CalculateWounds(hits - woundCritsPreReroll);
                    woundCritsPostReroll = woundCritsPreReroll + CalculateCriticalWounds(hits - woundCritsPreReroll);

                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else if (radioButtonWoundNoReroll.Checked)
            {
                woundsPostReroll = woundsPreReroll;
                woundCritsPostReroll = woundCritsPreReroll;
            }
            else
            {
                throw new NotImplementedException();
            }

            var woundsMinusDevastatingPostReroll = woundsPostReroll - (DevastatingWoundsCheckbox.Checked ? woundCritsPostReroll : 0);
            return new Tuple<double, double>(woundsMinusDevastatingPostReroll, woundCritsPostReroll);
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

        internal double CalculateWounds(double hits, int? index = null)
        {
            index = index == null ? ToWoundComboBox.SelectedIndex : index;
            var rollValue = ToHitComboBox.Items[index.Value];

            return Calculator.WoundDiceResult(hits, index.Value);
        }

        internal static double CalculateCriticalWounds(double hits)
        {
            return hits / 6;
        }

        internal double CalculateHits(double attacks, int? index = null)
        {
            index = index == null ? ToHitComboBox.SelectedIndex : index;
            return Calculator.HitDiceResult(attacks, index.Value);
        }

        internal static double CalculateCriticalHits(double attacks)
        {
            return attacks / 6;
        }

        private void MainTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var steps = new List<ChartStep>();
            if (IsChartCalculated is false)
            {
                var attacks = 100;
                List<string> variants = new() { "3+", "4+", "5+" };
                foreach (var hitroll in variants)
                {
                    var hits = Calculator.GoodDiceResult(attacks, hitroll);
                    var crits = CalculateCriticalHits(attacks);
                    foreach (var woundroll in variants)
                    {
                        var wounds = Calculator.GoodDiceResult(hits, woundroll);
                        var woundsSustained = Calculator.GoodDiceResult(hits + crits, woundroll);
                        var woundsLethal = Calculator.GoodDiceResult(hits - crits, woundroll) + crits;
                        var critWounds = CalculateCriticalWounds(hits);
                        foreach (var armor in variants)
                        {
                            steps.Add(new ChartStep
                            {
                                Key = hitroll + "/" + woundroll + "/" + armor,
                                ValueNoMods = Calculator.BadDiceResult(wounds, armor),
                                ValueSustainedHits = Calculator.BadDiceResult(woundsSustained, armor),
                                ValueLethalHits = Calculator.BadDiceResult(woundsLethal, armor),
                                ValueDevWounds = Calculator.BadDiceResult(wounds - critWounds, armor) + critWounds,
                            });
                        }
                    }
                }

                DiffChart.DataSource = steps;
                DiffChart.Series["NoMods"].XValueMember = "Key";
                DiffChart.Series["NoMods"].YValueMembers = "ValueNoMods";
                DiffChart.Series["Sustained"].YValueMembers = "ValueSustainedHits";
                DiffChart.Series["Lethal"].YValueMembers = "ValueLethalHits";
                DiffChart.Series["Devastating"].YValueMembers = "ValueDevWounds";
                DiffChart.ChartAreas.Single().AxisX.Interval = 1;
                DiffChart.DataBind();
                IsChartCalculated = true;
            }
        }

        private void SustainedHitsCustomValue_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SustainedHitsValueTextBox.Enabled = true;
            SustainedHitsValueTextBox_TextChanged(sender, e);
        }

        private void SustainedHitsRadioButtonChanged(object sender, EventArgs e)
        {
            SustainedHitsValueTextBox.Enabled = false;
            Recalculate(sender, e);
        }

        private void SustainedHitsValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SustainedHitsValueTextBox.Text, out var sustained))
            {
                SustainedMultiplicator = sustained;
            }
            Recalculate(sender, e);
        }

        private void SustainedHitsZeroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SustainedHitsZeroRadioButton.Checked == true)
            {
                SustainedMultiplicator = 0;
                SustainedHitsRadioButtonChanged(sender, e);
            }
        }

        private void SustainedHitsTwoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SustainedHitsTwoRadioButton.Checked == true)
            {
                SustainedMultiplicator = 2;
                SustainedHitsRadioButtonChanged(sender, e);
            }
        }

        private void SustainedHitsOneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SustainedHitsOneRadioButton.Checked == true)
            {
                SustainedMultiplicator = 1;
                SustainedHitsRadioButtonChanged(sender, e);
            }
        }

        private void SustainedHitsThreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SustainedHitsThreeRadioButton.Checked == true)
            {
                SustainedMultiplicator = 3;
                SustainedHitsRadioButtonChanged(sender, e);
            }
        }

        private void AutoHitsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoHitsCheckbox.Checked is true)
            {
                ToHitRerollGroupBox.Enabled = false;
                SustainedHitsZeroRadioButton.Checked = true;
                ToHitComboBox.Enabled = false;
                LethalHitsCheckbox.Checked = false;
                LethalHitsCheckbox.Enabled = false;
                SustainedHitsGroupBox.Enabled = false;
                SustainedHitsRadioButtonChanged(sender, e);
            }
            else
            {
                ToHitRerollGroupBox.Enabled = true;
                ToHitComboBox.Enabled = true;
                LethalHitsCheckbox.Enabled = true;
                SustainedHitsGroupBox.Enabled = true;
                Recalculate(sender, e);
            }
        }
    }
}