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
            SustainedHitsCheckbox = new CheckBox();
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButtonWoundNoReroll = new RadioButton();
            radioButtonWoundRerollOnes = new RadioButton();
            radioButtonWoundFullReroll = new RadioButton();
            DamageFinalTextbox = new TextBox();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label5 = new Label();
            FnpComboBox = new ComboBox();
            OnlyMwFnpCheckBox = new CheckBox();
            FishCritHitsCheckBox = new CheckBox();
            FishCritWoundsCheckBox = new CheckBox();
            CritHitsComboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            CritWoundsComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // SustainedHitsCheckbox
            // 
            SustainedHitsCheckbox.AutoSize = true;
            SustainedHitsCheckbox.Location = new Point(12, 11);
            SustainedHitsCheckbox.Name = "SustainedHitsCheckbox";
            SustainedHitsCheckbox.Size = new Size(101, 19);
            SustainedHitsCheckbox.TabIndex = 0;
            SustainedHitsCheckbox.Text = "Sustained Hits";
            SustainedHitsCheckbox.UseVisualStyleBackColor = true;
            SustainedHitsCheckbox.CheckedChanged += Recalculate;
            // 
            // LethalHitsCheckbox
            // 
            LethalHitsCheckbox.AutoSize = true;
            LethalHitsCheckbox.Location = new Point(118, 11);
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
            DevastatingWoundsCheckbox.Location = new Point(276, 11);
            DevastatingWoundsCheckbox.Name = "DevastatingWoundsCheckbox";
            DevastatingWoundsCheckbox.Size = new Size(135, 19);
            DevastatingWoundsCheckbox.TabIndex = 2;
            DevastatingWoundsCheckbox.Text = "Devastating Wounds";
            DevastatingWoundsCheckbox.UseVisualStyleBackColor = true;
            DevastatingWoundsCheckbox.CheckedChanged += Recalculate;
            // 
            // AttacksTextbox
            // 
            AttacksTextbox.Location = new Point(12, 50);
            AttacksTextbox.Name = "AttacksTextbox";
            AttacksTextbox.Size = new Size(100, 23);
            AttacksTextbox.TabIndex = 3;
            AttacksTextbox.TextChanged += Recalculate;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
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
            ToHitComboBox.Location = new Point(118, 50);
            ToHitComboBox.Name = "ToHitComboBox";
            ToHitComboBox.Size = new Size(46, 23);
            ToHitComboBox.TabIndex = 6;
            ToHitComboBox.SelectedIndexChanged += Recalculate;
            // 
            // HitsTextbox
            // 
            HitsTextbox.Location = new Point(170, 50);
            HitsTextbox.Name = "HitsTextbox";
            HitsTextbox.ReadOnly = true;
            HitsTextbox.Size = new Size(100, 23);
            HitsTextbox.TabIndex = 7;
            // 
            // ToWoundComboBox
            // 
            ToWoundComboBox.FormattingEnabled = true;
            ToWoundComboBox.Items.AddRange(new object[] { "2+", "3+", "4+", "5+", "6+" });
            ToWoundComboBox.Location = new Point(276, 50);
            ToWoundComboBox.Name = "ToWoundComboBox";
            ToWoundComboBox.Size = new Size(46, 23);
            ToWoundComboBox.TabIndex = 8;
            ToWoundComboBox.SelectedIndexChanged += Recalculate;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 33);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = "to hit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 33);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "to wound";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WoundsTextbox
            // 
            WoundsTextbox.Location = new Point(328, 50);
            WoundsTextbox.Name = "WoundsTextbox";
            WoundsTextbox.ReadOnly = true;
            WoundsTextbox.Size = new Size(100, 23);
            WoundsTextbox.TabIndex = 11;
            // 
            // ArmorComboBox
            // 
            ArmorComboBox.FormattingEnabled = true;
            ArmorComboBox.Items.AddRange(new object[] { "2+", "3+", "4+", "5+", "6+", "-" });
            ArmorComboBox.Location = new Point(434, 50);
            ArmorComboBox.Name = "ArmorComboBox";
            ArmorComboBox.Size = new Size(46, 23);
            ArmorComboBox.TabIndex = 12;
            ArmorComboBox.SelectedIndexChanged += Recalculate;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 33);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "armor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DamageTextbox
            // 
            DamageTextbox.Location = new Point(486, 50);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonHitsNoReroll);
            groupBox1.Controls.Add(radioButtonHitsRerollOnes);
            groupBox1.Controls.Add(radioButtonHitsFullReroll);
            groupBox1.Location = new Point(118, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(88, 100);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "to hit";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonWoundNoReroll);
            groupBox2.Controls.Add(radioButtonWoundRerollOnes);
            groupBox2.Controls.Add(radioButtonWoundFullReroll);
            groupBox2.Location = new Point(276, 80);
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
            DamageFinalTextbox.Location = new Point(644, 50);
            DamageFinalTextbox.Name = "DamageFinalTextbox";
            DamageFinalTextbox.ReadOnly = true;
            DamageFinalTextbox.Size = new Size(100, 23);
            DamageFinalTextbox.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(12, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(100, 155);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "sustained hits";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 23);
            textBox1.TabIndex = 20;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(11, 122);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(28, 19);
            radioButton5.TabIndex = 19;
            radioButton5.Text = ":";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += Recalculate;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(11, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(31, 19);
            radioButton4.TabIndex = 18;
            radioButton4.Text = "3";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(11, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(41, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "No";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(11, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 16;
            radioButton2.Text = "1";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(11, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 17;
            radioButton3.Text = "2/d3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(592, 33);
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
            FnpComboBox.Location = new Point(592, 50);
            FnpComboBox.Name = "FnpComboBox";
            FnpComboBox.Size = new Size(46, 23);
            FnpComboBox.TabIndex = 24;
            FnpComboBox.SelectedIndexChanged += Recalculate;
            // 
            // OnlyMwFnpCheckBox
            // 
            OnlyMwFnpCheckBox.AutoSize = true;
            OnlyMwFnpCheckBox.Location = new Point(592, 11);
            OnlyMwFnpCheckBox.Name = "OnlyMwFnpCheckBox";
            OnlyMwFnpCheckBox.Size = new Size(150, 19);
            OnlyMwFnpCheckBox.TabIndex = 26;
            OnlyMwFnpCheckBox.Text = "Only vs Mortal Wounds";
            OnlyMwFnpCheckBox.UseVisualStyleBackColor = true;
            OnlyMwFnpCheckBox.CheckedChanged += Recalculate;
            // 
            // FishCritHitsCheckBox
            // 
            FishCritHitsCheckBox.AutoSize = true;
            FishCritHitsCheckBox.Enabled = false;
            FishCritHitsCheckBox.Location = new Point(118, 186);
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
            FishCritWoundsCheckBox.Location = new Point(276, 186);
            FishCritWoundsCheckBox.Name = "FishCritWoundsCheckBox";
            FishCritWoundsCheckBox.Size = new Size(74, 19);
            FishCritWoundsCheckBox.TabIndex = 28;
            FishCritWoundsCheckBox.Text = "Fish Crits";
            FishCritWoundsCheckBox.UseVisualStyleBackColor = true;
            FishCritWoundsCheckBox.CheckedChanged += Recalculate;
            // 
            // CritHitsComboBox
            // 
            CritHitsComboBox.Enabled = false;
            CritHitsComboBox.FormattingEnabled = true;
            CritHitsComboBox.Items.AddRange(new object[] { "6+", "5+" });
            CritHitsComboBox.Location = new Point(146, 211);
            CritHitsComboBox.Name = "CritHitsComboBox";
            CritHitsComboBox.Size = new Size(46, 23);
            CritHitsComboBox.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 214);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 30;
            label6.Text = "on";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 209);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 32;
            label7.Text = "on";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CritWoundsComboBox
            // 
            CritWoundsComboBox.Enabled = false;
            CritWoundsComboBox.FormattingEnabled = true;
            CritWoundsComboBox.Items.AddRange(new object[] { "6+", "5+" });
            CritWoundsComboBox.Location = new Point(304, 206);
            CritWoundsComboBox.Name = "CritWoundsComboBox";
            CritWoundsComboBox.Size = new Size(46, 23);
            CritWoundsComboBox.TabIndex = 31;
            // 
            // AttacksCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 303);
            Controls.Add(label7);
            Controls.Add(CritWoundsComboBox);
            Controls.Add(label6);
            Controls.Add(CritHitsComboBox);
            Controls.Add(FishCritWoundsCheckBox);
            Controls.Add(FishCritHitsCheckBox);
            Controls.Add(OnlyMwFnpCheckBox);
            Controls.Add(label5);
            Controls.Add(FnpComboBox);
            Controls.Add(groupBox3);
            Controls.Add(DamageFinalTextbox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DamageTextbox);
            Controls.Add(label4);
            Controls.Add(ArmorComboBox);
            Controls.Add(WoundsTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ToWoundComboBox);
            Controls.Add(HitsTextbox);
            Controls.Add(ToHitComboBox);
            Controls.Add(label1);
            Controls.Add(AttacksTextbox);
            Controls.Add(DevastatingWoundsCheckbox);
            Controls.Add(LethalHitsCheckbox);
            Controls.Add(SustainedHitsCheckbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AttacksCalculatorForm";
            Text = "Attacks Calculator";
            Load += AttacksCalculatorFormLoad;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox SustainedHitsCheckbox;
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButtonWoundNoReroll;
        private RadioButton radioButtonWoundRerollOnes;
        private RadioButton radioButtonWoundFullReroll;
        private TextBox DamageFinalTextbox;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private TextBox textBox1;
        private Label label5;
        private ComboBox FnpComboBox;
        private CheckBox OnlyMwFnpCheckBox;
        private CheckBox FishCritHitsCheckBox;
        private CheckBox FishCritWoundsCheckBox;
        private ComboBox CritHitsComboBox;
        private Label label6;
        private Label label7;
        private ComboBox CritWoundsComboBox;
    }
}