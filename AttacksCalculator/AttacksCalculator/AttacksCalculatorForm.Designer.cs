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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            ArmorComboBox.Items.AddRange(new object[] { "2+", "3+", "4+", "5+", "6+" });
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
            radioButtonHitsNoReroll.CheckedChanged += Recalculate;
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
            radioButtonHitsRerollOnes.CheckedChanged += Recalculate;
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
            radioButtonHitsFullReroll.CheckedChanged += Recalculate;
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
            radioButtonWoundNoReroll.CheckedChanged += Recalculate;
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
            radioButtonWoundRerollOnes.CheckedChanged += Recalculate;
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
            radioButtonWoundFullReroll.CheckedChanged += Recalculate;
            // 
            // DamageFinalTextbox
            // 
            DamageFinalTextbox.Location = new Point(592, 50);
            DamageFinalTextbox.Name = "DamageFinalTextbox";
            DamageFinalTextbox.ReadOnly = true;
            DamageFinalTextbox.Size = new Size(100, 23);
            DamageFinalTextbox.TabIndex = 23;
            // 
            // AttacksCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 280);
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
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}