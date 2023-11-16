namespace AttacksCalculator
{
    partial class AttacksCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            AutoHitsCheckbox = new CheckBox();
            LethalHitsCheckbox = new CheckBox();
            DevastatingWoundsCheckbox = new CheckBox();
            AttacksTextbox = new TextBox();
            label1 = new Label();
            ToHitComboBox = new ComboBox();
            HitsTextbox = new TextBox();
            ToWoundComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            WoundsTextbox = new TextBox();
            ArmorComboBox = new ComboBox();
            label4 = new Label();
            DamageTextbox = new TextBox();
            radioButtonHitsNoReroll = new RadioButton();
            radioButtonHitsRerollOnes = new RadioButton();
            radioButtonHitsFullReroll = new RadioButton();
            ToHitRerollGroupBox = new GroupBox();
            groupBox2 = new GroupBox();
            radioButtonWoundNoReroll = new RadioButton();
            radioButtonWoundRerollOnes = new RadioButton();
            radioButtonWoundFullReroll = new RadioButton();
            DamageFinalTextbox = new TextBox();
            SustainedHitsGroupBox = new GroupBox();
            SustainedHitsValueTextBox = new TextBox();
            SustainedHitsCustomValue_RadioButton = new RadioButton();
            SustainedHitsThreeRadioButton = new RadioButton();
            SustainedHitsZeroRadioButton = new RadioButton();
            SustainedHitsOneRadioButton = new RadioButton();
            SustainedHitsTwoRadioButton = new RadioButton();
            label5 = new Label();
            FnpComboBox = new ComboBox();
            FishCritHitsCheckBox = new CheckBox();
            FishCritWoundsCheckBox = new CheckBox();
            CritHitsComboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            CritWoundsComboBox = new ComboBox();
            DiffChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            MainTabs = new TabControl();
            AttacksCalculator = new TabPage();
            Chart = new TabPage();
            ToHitRerollGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            SustainedHitsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiffChart).BeginInit();
            MainTabs.SuspendLayout();
            AttacksCalculator.SuspendLayout();
            Chart.SuspendLayout();
            SuspendLayout();
            // 
            // AutoHitsCheckbox
            // 
            AutoHitsCheckbox.AutoSize = true;
            AutoHitsCheckbox.Location = new Point(14, 8);
            AutoHitsCheckbox.Name = "AutoHitsCheckbox";
            AutoHitsCheckbox.Size = new Size(71, 19);
            AutoHitsCheckbox.TabIndex = 0;
            AutoHitsCheckbox.Text = "Autohits";
            AutoHitsCheckbox.UseVisualStyleBackColor = true;
            AutoHitsCheckbox.CheckedChanged += AutoHitsCheckbox_CheckedChanged;
            // 
            // LethalHitsCheckbox
            // 
            LethalHitsCheckbox.AutoSize = true;
            LethalHitsCheckbox.Location = new Point(120, 8);
            LethalHitsCheckbox.Name = "LethalHitsCheckbox";
            LethalHitsCheckbox.Size = new Size(82, 19);
            LethalHitsCheckbox.TabIndex = 1;
            LethalHitsCheckbox.Text = "Lethal Hits";
            LethalHitsCheckbox.UseVisualStyleBackColor = true;
            LethalHitsCheckbox.CheckedChanged += Recalculate;
            // 
            // DevastatingWoundsCheckbox
            // 
            DevastatingWoundsCheckbox.AutoSize = true;
            DevastatingWoundsCheckbox.Location = new Point(278, 8);
            DevastatingWoundsCheckbox.Name = "DevastatingWoundsCheckbox";
            DevastatingWoundsCheckbox.Size = new Size(135, 19);
            DevastatingWoundsCheckbox.TabIndex = 2;
            DevastatingWoundsCheckbox.Text = "Devastating Wounds";
            DevastatingWoundsCheckbox.UseVisualStyleBackColor = true;
            DevastatingWoundsCheckbox.CheckedChanged += Recalculate;
            // 
            // AttacksTextbox
            // 
            AttacksTextbox.Location = new Point(14, 47);
            AttacksTextbox.Name = "AttacksTextbox";
            AttacksTextbox.Size = new Size(100, 23);
            AttacksTextbox.TabIndex = 3;
            AttacksTextbox.TextChanged += Recalculate;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "# of attacks";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ToHitComboBox
            // 
            ToHitComboBox.FormattingEnabled = true;
            ToHitComboBox.Items.AddRange(new object[] { "2+", "3+", "4+", "5+", "6+" });
            ToHitComboBox.Location = new Point(120, 47);
            ToHitComboBox.Name = "ToHitComboBox";
            ToHitComboBox.Size = new Size(46, 23);
            ToHitComboBox.TabIndex = 6;
            ToHitComboBox.SelectedIndexChanged += Recalculate;
            // 
            // HitsTextbox
            // 
            HitsTextbox.Location = new Point(172, 47);
            HitsTextbox.Name = "HitsTextbox";
            HitsTextbox.ReadOnly = true;
            HitsTextbox.Size = new Size(100, 23);
            HitsTextbox.TabIndex = 7;
            // 
            // ToWoundComboBox
            // 
            ToWoundComboBox.FormattingEnabled = true;
            ToWoundComboBox.Items.AddRange(new object[] { "2+", "3+", "4+", "5+", "6+" });
            ToWoundComboBox.Location = new Point(278, 47);
            ToWoundComboBox.Name = "ToWoundComboBox";
            ToWoundComboBox.Size = new Size(46, 23);
            ToWoundComboBox.TabIndex = 8;
            ToWoundComboBox.SelectedIndexChanged += Recalculate;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 30);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = "to hit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 30);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "to wound";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WoundsTextbox
            // 
            WoundsTextbox.Location = new Point(330, 47);
            WoundsTextbox.Name = "WoundsTextbox";
            WoundsTextbox.ReadOnly = true;
            WoundsTextbox.Size = new Size(100, 23);
            WoundsTextbox.TabIndex = 11;
            // 
            // ArmorComboBox
            // 
            ArmorComboBox.FormattingEnabled = true;
            ArmorComboBox.Items.AddRange(new object[] { "2+", "3+", "4+", "5+", "6+", "-" });
            ArmorComboBox.Location = new Point(436, 47);
            ArmorComboBox.Name = "ArmorComboBox";
            ArmorComboBox.Size = new Size(46, 23);
            ArmorComboBox.TabIndex = 12;
            ArmorComboBox.SelectedIndexChanged += Recalculate;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 30);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "armor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DamageTextbox
            // 
            DamageTextbox.Location = new Point(488, 47);
            DamageTextbox.Name = "DamageTextbox";
            DamageTextbox.ReadOnly = true;
            DamageTextbox.Size = new Size(100, 23);
            DamageTextbox.TabIndex = 14;
            // 
            // radioButtonHitsNoReroll
            // 
            radioButtonHitsNoReroll.AutoSize = true;
            radioButtonHitsNoReroll.Checked = true;
            radioButtonHitsNoReroll.Location = new Point(11, 22);
            radioButtonHitsNoReroll.Name = "radioButtonHitsNoReroll";
            radioButtonHitsNoReroll.Size = new Size(76, 19);
            radioButtonHitsNoReroll.TabIndex = 15;
            radioButtonHitsNoReroll.TabStop = true;
            radioButtonHitsNoReroll.Text = "No rerolls";
            radioButtonHitsNoReroll.UseVisualStyleBackColor = true;
            radioButtonHitsNoReroll.CheckedChanged += RadioButtonHitsFullRerollDeselected;
            // 
            // radioButtonHitsRerollOnes
            // 
            radioButtonHitsRerollOnes.AutoSize = true;
            radioButtonHitsRerollOnes.Location = new Point(11, 47);
            radioButtonHitsRerollOnes.Name = "radioButtonHitsRerollOnes";
            radioButtonHitsRerollOnes.Size = new Size(69, 19);
            radioButtonHitsRerollOnes.TabIndex = 16;
            radioButtonHitsRerollOnes.Text = "Reroll 1s";
            radioButtonHitsRerollOnes.UseVisualStyleBackColor = true;
            radioButtonHitsRerollOnes.CheckedChanged += RadioButtonHitsFullRerollDeselected;
            // 
            // radioButtonHitsFullReroll
            // 
            radioButtonHitsFullReroll.AutoSize = true;
            radioButtonHitsFullReroll.Location = new Point(11, 72);
            radioButtonHitsFullReroll.Name = "radioButtonHitsFullReroll";
            radioButtonHitsFullReroll.Size = new Size(74, 19);
            radioButtonHitsFullReroll.TabIndex = 17;
            radioButtonHitsFullReroll.Text = "Full reroll";
            radioButtonHitsFullReroll.UseVisualStyleBackColor = true;
            radioButtonHitsFullReroll.CheckedChanged += RadioButtonHitsFullRerollClicked;
            // 
            // ToHitRerollGroupBox
            // 
            ToHitRerollGroupBox.Controls.Add(radioButtonHitsNoReroll);
            ToHitRerollGroupBox.Controls.Add(radioButtonHitsRerollOnes);
            ToHitRerollGroupBox.Controls.Add(radioButtonHitsFullReroll);
            ToHitRerollGroupBox.Location = new Point(120, 77);
            ToHitRerollGroupBox.Name = "ToHitRerollGroupBox";
            ToHitRerollGroupBox.Size = new Size(88, 100);
            ToHitRerollGroupBox.TabIndex = 21;
            ToHitRerollGroupBox.TabStop = false;
            ToHitRerollGroupBox.Text = "to hit";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonWoundNoReroll);
            groupBox2.Controls.Add(radioButtonWoundRerollOnes);
            groupBox2.Controls.Add(radioButtonWoundFullReroll);
            groupBox2.Location = new Point(278, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(88, 100);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "to wound";
            // 
            // radioButtonWoundNoReroll
            // 
            radioButtonWoundNoReroll.AutoSize = true;
            radioButtonWoundNoReroll.Checked = true;
            radioButtonWoundNoReroll.Location = new Point(11, 22);
            radioButtonWoundNoReroll.Name = "radioButtonWoundNoReroll";
            radioButtonWoundNoReroll.Size = new Size(76, 19);
            radioButtonWoundNoReroll.TabIndex = 15;
            radioButtonWoundNoReroll.TabStop = true;
            radioButtonWoundNoReroll.Text = "No rerolls";
            radioButtonWoundNoReroll.UseVisualStyleBackColor = true;
            radioButtonWoundNoReroll.CheckedChanged += RadioButtonWoundsFullRerollDeselected;
            // 
            // radioButtonWoundRerollOnes
            // 
            radioButtonWoundRerollOnes.AutoSize = true;
            radioButtonWoundRerollOnes.Location = new Point(11, 47);
            radioButtonWoundRerollOnes.Name = "radioButtonWoundRerollOnes";
            radioButtonWoundRerollOnes.Size = new Size(69, 19);
            radioButtonWoundRerollOnes.TabIndex = 16;
            radioButtonWoundRerollOnes.Text = "Reroll 1s";
            radioButtonWoundRerollOnes.UseVisualStyleBackColor = true;
            radioButtonWoundRerollOnes.CheckedChanged += RadioButtonWoundsFullRerollDeselected;
            // 
            // radioButtonWoundFullReroll
            // 
            radioButtonWoundFullReroll.AutoSize = true;
            radioButtonWoundFullReroll.Location = new Point(11, 72);
            radioButtonWoundFullReroll.Name = "radioButtonWoundFullReroll";
            radioButtonWoundFullReroll.Size = new Size(74, 19);
            radioButtonWoundFullReroll.TabIndex = 17;
            radioButtonWoundFullReroll.Text = "Full reroll";
            radioButtonWoundFullReroll.UseVisualStyleBackColor = true;
            radioButtonWoundFullReroll.CheckedChanged += RadioButtonWoundsFullRerollClicked;
            // 
            // DamageFinalTextbox
            // 
            DamageFinalTextbox.Location = new Point(646, 47);
            DamageFinalTextbox.Name = "DamageFinalTextbox";
            DamageFinalTextbox.ReadOnly = true;
            DamageFinalTextbox.Size = new Size(100, 23);
            DamageFinalTextbox.TabIndex = 23;
            // 
            // SustainedHitsGroupBox
            // 
            SustainedHitsGroupBox.Controls.Add(SustainedHitsValueTextBox);
            SustainedHitsGroupBox.Controls.Add(SustainedHitsCustomValue_RadioButton);
            SustainedHitsGroupBox.Controls.Add(SustainedHitsThreeRadioButton);
            SustainedHitsGroupBox.Controls.Add(SustainedHitsZeroRadioButton);
            SustainedHitsGroupBox.Controls.Add(SustainedHitsOneRadioButton);
            SustainedHitsGroupBox.Controls.Add(SustainedHitsTwoRadioButton);
            SustainedHitsGroupBox.Location = new Point(14, 77);
            SustainedHitsGroupBox.Name = "SustainedHitsGroupBox";
            SustainedHitsGroupBox.Size = new Size(100, 155);
            SustainedHitsGroupBox.TabIndex = 22;
            SustainedHitsGroupBox.TabStop = false;
            SustainedHitsGroupBox.Text = "Sustained hits";
            // 
            // SustainedHitsValueTextBox
            // 
            SustainedHitsValueTextBox.Enabled = false;
            SustainedHitsValueTextBox.Location = new Point(41, 121);
            SustainedHitsValueTextBox.Name = "SustainedHitsValueTextBox";
            SustainedHitsValueTextBox.Size = new Size(53, 23);
            SustainedHitsValueTextBox.TabIndex = 20;
            SustainedHitsValueTextBox.TextChanged += SustainedHitsValueTextBox_TextChanged;
            // 
            // SustainedHitsCustomValue_RadioButton
            // 
            SustainedHitsCustomValue_RadioButton.AutoSize = true;
            SustainedHitsCustomValue_RadioButton.Location = new Point(11, 122);
            SustainedHitsCustomValue_RadioButton.Name = "SustainedHitsCustomValue_RadioButton";
            SustainedHitsCustomValue_RadioButton.Size = new Size(28, 19);
            SustainedHitsCustomValue_RadioButton.TabIndex = 19;
            SustainedHitsCustomValue_RadioButton.Text = ":";
            SustainedHitsCustomValue_RadioButton.UseVisualStyleBackColor = true;
            SustainedHitsCustomValue_RadioButton.CheckedChanged += SustainedHitsCustomValue_RadioButton_CheckedChanged;
            // 
            // SustainedHitsThreeRadioButton
            // 
            SustainedHitsThreeRadioButton.AutoSize = true;
            SustainedHitsThreeRadioButton.Location = new Point(11, 97);
            SustainedHitsThreeRadioButton.Name = "SustainedHitsThreeRadioButton";
            SustainedHitsThreeRadioButton.Size = new Size(31, 19);
            SustainedHitsThreeRadioButton.TabIndex = 18;
            SustainedHitsThreeRadioButton.Text = "3";
            SustainedHitsThreeRadioButton.UseVisualStyleBackColor = true;
            SustainedHitsThreeRadioButton.CheckedChanged += SustainedHitsThreeRadioButton_CheckedChanged;
            // 
            // SustainedHitsZeroRadioButton
            // 
            SustainedHitsZeroRadioButton.AutoSize = true;
            SustainedHitsZeroRadioButton.Checked = true;
            SustainedHitsZeroRadioButton.Location = new Point(11, 22);
            SustainedHitsZeroRadioButton.Name = "SustainedHitsZeroRadioButton";
            SustainedHitsZeroRadioButton.Size = new Size(41, 19);
            SustainedHitsZeroRadioButton.TabIndex = 15;
            SustainedHitsZeroRadioButton.TabStop = true;
            SustainedHitsZeroRadioButton.Text = "No";
            SustainedHitsZeroRadioButton.UseVisualStyleBackColor = true;
            SustainedHitsZeroRadioButton.CheckedChanged += SustainedHitsZeroRadioButton_CheckedChanged;
            // 
            // SustainedHitsOneRadioButton
            // 
            SustainedHitsOneRadioButton.AutoSize = true;
            SustainedHitsOneRadioButton.Location = new Point(11, 47);
            SustainedHitsOneRadioButton.Name = "SustainedHitsOneRadioButton";
            SustainedHitsOneRadioButton.Size = new Size(31, 19);
            SustainedHitsOneRadioButton.TabIndex = 16;
            SustainedHitsOneRadioButton.Text = "1";
            SustainedHitsOneRadioButton.UseVisualStyleBackColor = true;
            SustainedHitsOneRadioButton.CheckedChanged += SustainedHitsOneRadioButton_CheckedChanged;
            // 
            // SustainedHitsTwoRadioButton
            // 
            SustainedHitsTwoRadioButton.AutoSize = true;
            SustainedHitsTwoRadioButton.Location = new Point(11, 72);
            SustainedHitsTwoRadioButton.Name = "SustainedHitsTwoRadioButton";
            SustainedHitsTwoRadioButton.Size = new Size(49, 19);
            SustainedHitsTwoRadioButton.TabIndex = 17;
            SustainedHitsTwoRadioButton.Text = "2/d3";
            SustainedHitsTwoRadioButton.UseVisualStyleBackColor = true;
            SustainedHitsTwoRadioButton.CheckedChanged += SustainedHitsTwoRadioButton_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(594, 30);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 25;
            label5.Text = "FNP";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FnpComboBox
            // 
            FnpComboBox.FormattingEnabled = true;
            FnpComboBox.Items.AddRange(new object[] { "-", "6+", "5+", "4+" });
            FnpComboBox.Location = new Point(594, 47);
            FnpComboBox.Name = "FnpComboBox";
            FnpComboBox.Size = new Size(46, 23);
            FnpComboBox.TabIndex = 24;
            FnpComboBox.SelectedIndexChanged += Recalculate;
            // 
            // FishCritHitsCheckBox
            // 
            FishCritHitsCheckBox.AutoSize = true;
            FishCritHitsCheckBox.Enabled = false;
            FishCritHitsCheckBox.Location = new Point(120, 183);
            FishCritHitsCheckBox.Name = "FishCritHitsCheckBox";
            FishCritHitsCheckBox.Size = new Size(74, 19);
            FishCritHitsCheckBox.TabIndex = 27;
            FishCritHitsCheckBox.Text = "Fish Crits";
            FishCritHitsCheckBox.UseVisualStyleBackColor = true;
            FishCritHitsCheckBox.CheckedChanged += Recalculate;
            // 
            // FishCritWoundsCheckBox
            // 
            FishCritWoundsCheckBox.AutoSize = true;
            FishCritWoundsCheckBox.Enabled = false;
            FishCritWoundsCheckBox.Location = new Point(278, 183);
            FishCritWoundsCheckBox.Name = "FishCritWoundsCheckBox";
            FishCritWoundsCheckBox.Size = new Size(74, 19);
            FishCritWoundsCheckBox.TabIndex = 28;
            FishCritWoundsCheckBox.Text = "Fish Crits";
            FishCritWoundsCheckBox.UseVisualStyleBackColor = true;
            FishCritWoundsCheckBox.CheckedChanged += Recalculate;
            // 
            // CritHitsComboBox
            // 
            CritHitsComboBox.FormattingEnabled = true;
            CritHitsComboBox.Items.AddRange(new object[] { "6+", "5+", "4+", "3+", "2+" });
            CritHitsComboBox.Location = new Point(148, 208);
            CritHitsComboBox.Name = "CritHitsComboBox";
            CritHitsComboBox.Size = new Size(46, 23);
            CritHitsComboBox.TabIndex = 29;
            CritHitsComboBox.SelectedIndexChanged += Recalculate;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 211);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 30;
            label6.Text = "on";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 206);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 32;
            label7.Text = "on";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CritWoundsComboBox
            // 
            CritWoundsComboBox.FormattingEnabled = true;
            CritWoundsComboBox.Items.AddRange(new object[] { "6+", "5+", "4+", "3+", "2+" });
            CritWoundsComboBox.Location = new Point(306, 203);
            CritWoundsComboBox.Name = "CritWoundsComboBox";
            CritWoundsComboBox.Size = new Size(46, 23);
            CritWoundsComboBox.TabIndex = 31;
            CritWoundsComboBox.SelectedIndexChanged += Recalculate;
            // 
            // DiffChart
            // 
            DiffChart.BackColor = Color.LightGray;
            chartArea1.AxisX.Title = "To hit, to wound, armor";
            chartArea1.BackColor = Color.FromArgb(224, 224, 224);
            chartArea1.BorderColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            DiffChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            DiffChart.Legends.Add(legend1);
            DiffChart.Location = new Point(6, 6);
            DiffChart.Name = "DiffChart";
            DiffChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.LabelFormat = "F1";
            series1.Legend = "Legend1";
            series1.Name = "NoMods";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sustained";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Lethal";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Devastating";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            DiffChart.Series.Add(series1);
            DiffChart.Series.Add(series2);
            DiffChart.Series.Add(series3);
            DiffChart.Series.Add(series4);
            DiffChart.Size = new Size(989, 337);
            DiffChart.TabIndex = 33;
            DiffChart.Text = "chart1";
            // 
            // MainTabs
            // 
            MainTabs.Controls.Add(AttacksCalculator);
            MainTabs.Controls.Add(Chart);
            MainTabs.Location = new Point(2, 2);
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.Size = new Size(1009, 377);
            MainTabs.TabIndex = 34;
            MainTabs.SelectedIndexChanged += MainTabs_SelectedIndexChanged;
            // 
            // AttacksCalculator
            // 
            AttacksCalculator.Controls.Add(WoundsTextbox);
            AttacksCalculator.Controls.Add(label7);
            AttacksCalculator.Controls.Add(AutoHitsCheckbox);
            AttacksCalculator.Controls.Add(CritWoundsComboBox);
            AttacksCalculator.Controls.Add(LethalHitsCheckbox);
            AttacksCalculator.Controls.Add(label6);
            AttacksCalculator.Controls.Add(DevastatingWoundsCheckbox);
            AttacksCalculator.Controls.Add(CritHitsComboBox);
            AttacksCalculator.Controls.Add(AttacksTextbox);
            AttacksCalculator.Controls.Add(FishCritWoundsCheckBox);
            AttacksCalculator.Controls.Add(label1);
            AttacksCalculator.Controls.Add(FishCritHitsCheckBox);
            AttacksCalculator.Controls.Add(ToHitComboBox);
            AttacksCalculator.Controls.Add(HitsTextbox);
            AttacksCalculator.Controls.Add(label5);
            AttacksCalculator.Controls.Add(ToWoundComboBox);
            AttacksCalculator.Controls.Add(FnpComboBox);
            AttacksCalculator.Controls.Add(label2);
            AttacksCalculator.Controls.Add(SustainedHitsGroupBox);
            AttacksCalculator.Controls.Add(label3);
            AttacksCalculator.Controls.Add(DamageFinalTextbox);
            AttacksCalculator.Controls.Add(ArmorComboBox);
            AttacksCalculator.Controls.Add(groupBox2);
            AttacksCalculator.Controls.Add(label4);
            AttacksCalculator.Controls.Add(ToHitRerollGroupBox);
            AttacksCalculator.Controls.Add(DamageTextbox);
            AttacksCalculator.Location = new Point(4, 24);
            AttacksCalculator.Name = "AttacksCalculator";
            AttacksCalculator.Padding = new Padding(3);
            AttacksCalculator.Size = new Size(1001, 349);
            AttacksCalculator.TabIndex = 0;
            AttacksCalculator.Text = "AttacksCalculator";
            AttacksCalculator.UseVisualStyleBackColor = true;
            // 
            // Chart
            // 
            Chart.Controls.Add(DiffChart);
            Chart.Location = new Point(4, 24);
            Chart.Name = "Chart";
            Chart.Padding = new Padding(3);
            Chart.Size = new Size(1001, 349);
            Chart.TabIndex = 1;
            Chart.Text = "Chart";
            Chart.UseVisualStyleBackColor = true;
            // 
            // AttacksCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 382);
            Controls.Add(MainTabs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AttacksCalculatorForm";
            Text = "Attacks Calculator";
            Load += AttacksCalculatorFormLoad;
            ToHitRerollGroupBox.ResumeLayout(false);
            ToHitRerollGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            SustainedHitsGroupBox.ResumeLayout(false);
            SustainedHitsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiffChart).EndInit();
            MainTabs.ResumeLayout(false);
            AttacksCalculator.ResumeLayout(false);
            AttacksCalculator.PerformLayout();
            Chart.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox AutoHitsCheckbox;
        private CheckBox LethalHitsCheckbox;
        private CheckBox DevastatingWoundsCheckbox;
        private TextBox AttacksTextbox;
        private Label label1;
        private ComboBox ToHitComboBox;
        private TextBox HitsTextbox;
        private ComboBox ToWoundComboBox;
        private Label label2;
        private Label label3;
        private TextBox WoundsTextbox;
        private ComboBox ArmorComboBox;
        private Label label4;
        private TextBox DamageTextbox;
        private RadioButton radioButtonHitsNoReroll;
        private RadioButton radioButtonHitsRerollOnes;
        private RadioButton radioButtonHitsFullReroll;
        private GroupBox ToHitRerollGroupBox;
        private GroupBox groupBox2;
        private RadioButton radioButtonWoundNoReroll;
        private RadioButton radioButtonWoundRerollOnes;
        private RadioButton radioButtonWoundFullReroll;
        private TextBox DamageFinalTextbox;
        private GroupBox SustainedHitsGroupBox;
        private RadioButton SustainedHitsZeroRadioButton;
        private RadioButton SustainedHitsOneRadioButton;
        private RadioButton SustainedHitsTwoRadioButton;
        private RadioButton SustainedHitsCustomValue_RadioButton;
        private RadioButton SustainedHitsThreeRadioButton;
        private TextBox SustainedHitsValueTextBox;
        private Label label5;
        private ComboBox FnpComboBox;
        private CheckBox FishCritHitsCheckBox;
        private CheckBox FishCritWoundsCheckBox;
        private ComboBox CritHitsComboBox;
        private Label label6;
        private Label label7;
        private ComboBox CritWoundsComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart DiffChart;
        private TabControl MainTabs;
        private TabPage AttacksCalculator;
        private TabPage Chart;
    }
}