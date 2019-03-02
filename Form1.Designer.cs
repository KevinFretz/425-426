namespace WolframRules
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.TimeStepsLabel = new System.Windows.Forms.Label();
            this.HowManyStatesLabel = new System.Windows.Forms.Label();
            this.ChangedStatesLabel = new System.Windows.Forms.Label();
            this.RuleLabel = new System.Windows.Forms.Label();
            this.TimeStepsTextBox = new System.Windows.Forms.TextBox();
            this.HowManyStatesTextBox = new System.Windows.Forms.TextBox();
            this.ChangedStatesTextBox = new System.Windows.Forms.TextBox();
            this.NumRule_Txt = new System.Windows.Forms.TextBox();
            this.Show_TxtBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ArraySizeTB = new System.Windows.Forms.TextBox();
            this.ArraySizeLabel = new System.Windows.Forms.Label();
            this.InfiniteCB = new System.Windows.Forms.CheckBox();
            this.FiniteCB = new System.Windows.Forms.CheckBox();
            this.PeriodicCB = new System.Windows.Forms.CheckBox();
            this.NullCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(465, 521);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(146, 43);
            this.BTN_Submit.TabIndex = 2;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // TimeStepsLabel
            // 
            this.TimeStepsLabel.AutoSize = true;
            this.TimeStepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepsLabel.Location = new System.Drawing.Point(415, 31);
            this.TimeStepsLabel.Name = "TimeStepsLabel";
            this.TimeStepsLabel.Size = new System.Drawing.Size(253, 29);
            this.TimeStepsLabel.TabIndex = 3;
            this.TimeStepsLabel.Text = "How many time steps?";
            // 
            // HowManyStatesLabel
            // 
            this.HowManyStatesLabel.AutoSize = true;
            this.HowManyStatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowManyStatesLabel.Location = new System.Drawing.Point(306, 141);
            this.HowManyStatesLabel.Name = "HowManyStatesLabel";
            this.HowManyStatesLabel.Size = new System.Drawing.Size(451, 29);
            this.HowManyStatesLabel.TabIndex = 4;
            this.HowManyStatesLabel.Text = "How many states do you want to change?";
            // 
            // ChangedStatesLabel
            // 
            this.ChangedStatesLabel.AutoSize = true;
            this.ChangedStatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangedStatesLabel.Location = new System.Drawing.Point(382, 263);
            this.ChangedStatesLabel.Name = "ChangedStatesLabel";
            this.ChangedStatesLabel.Size = new System.Drawing.Size(295, 29);
            this.ChangedStatesLabel.TabIndex = 5;
            this.ChangedStatesLabel.Text = "Enter the string as 0s or 1s";
            this.ChangedStatesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RuleLabel
            // 
            this.RuleLabel.AutoSize = true;
            this.RuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleLabel.Location = new System.Drawing.Point(455, 373);
            this.RuleLabel.Name = "RuleLabel";
            this.RuleLabel.Size = new System.Drawing.Size(156, 29);
            this.RuleLabel.TabIndex = 6;
            this.RuleLabel.Text = "Rule Number";
            // 
            // TimeStepsTextBox
            // 
            this.TimeStepsTextBox.Location = new System.Drawing.Point(488, 78);
            this.TimeStepsTextBox.Name = "TimeStepsTextBox";
            this.TimeStepsTextBox.Size = new System.Drawing.Size(100, 26);
            this.TimeStepsTextBox.TabIndex = 7;
            // 
            // HowManyStatesTextBox
            // 
            this.HowManyStatesTextBox.Location = new System.Drawing.Point(488, 198);
            this.HowManyStatesTextBox.Name = "HowManyStatesTextBox";
            this.HowManyStatesTextBox.Size = new System.Drawing.Size(100, 26);
            this.HowManyStatesTextBox.TabIndex = 8;
            // 
            // ChangedStatesTextBox
            // 
            this.ChangedStatesTextBox.Location = new System.Drawing.Point(488, 310);
            this.ChangedStatesTextBox.Name = "ChangedStatesTextBox";
            this.ChangedStatesTextBox.Size = new System.Drawing.Size(100, 26);
            this.ChangedStatesTextBox.TabIndex = 9;
            // 
            // NumRule_Txt
            // 
            this.NumRule_Txt.Location = new System.Drawing.Point(488, 449);
            this.NumRule_Txt.Name = "NumRule_Txt";
            this.NumRule_Txt.Size = new System.Drawing.Size(100, 26);
            this.NumRule_Txt.TabIndex = 10;
            // 
            // Show_TxtBox
            // 
            this.Show_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_TxtBox.Location = new System.Drawing.Point(12, 3);
            this.Show_TxtBox.Multiline = true;
            this.Show_TxtBox.Name = "Show_TxtBox";
            this.Show_TxtBox.ReadOnly = true;
            this.Show_TxtBox.Size = new System.Drawing.Size(1057, 512);
            this.Show_TxtBox.TabIndex = 11;
            this.Show_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Show_TxtBox.TextChanged += new System.EventHandler(this.Show_TxtBox_TextChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(465, 521);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(156, 43);
            this.ReturnButton.TabIndex = 12;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ArraySizeTB
            // 
            this.ArraySizeTB.Location = new System.Drawing.Point(53, 295);
            this.ArraySizeTB.Name = "ArraySizeTB";
            this.ArraySizeTB.Size = new System.Drawing.Size(100, 26);
            this.ArraySizeTB.TabIndex = 17;
            // 
            // ArraySizeLabel
            // 
            this.ArraySizeLabel.AutoSize = true;
            this.ArraySizeLabel.Location = new System.Drawing.Point(61, 272);
            this.ArraySizeLabel.Name = "ArraySizeLabel";
            this.ArraySizeLabel.Size = new System.Drawing.Size(81, 20);
            this.ArraySizeLabel.TabIndex = 18;
            this.ArraySizeLabel.Text = "Array Size";
            // 
            // InfiniteCB
            // 
            this.InfiniteCB.AutoSize = true;
            this.InfiniteCB.Location = new System.Drawing.Point(35, 155);
            this.InfiniteCB.Name = "InfiniteCB";
            this.InfiniteCB.Size = new System.Drawing.Size(83, 24);
            this.InfiniteCB.TabIndex = 19;
            this.InfiniteCB.Text = "Infinite";
            this.InfiniteCB.UseVisualStyleBackColor = true;
            this.InfiniteCB.CheckedChanged += new System.EventHandler(this.InfiniteCB_CheckedChanged);
            // 
            // FiniteCB
            // 
            this.FiniteCB.AutoSize = true;
            this.FiniteCB.Location = new System.Drawing.Point(140, 155);
            this.FiniteCB.Name = "FiniteCB";
            this.FiniteCB.Size = new System.Drawing.Size(74, 24);
            this.FiniteCB.TabIndex = 20;
            this.FiniteCB.Text = "Finite";
            this.FiniteCB.UseVisualStyleBackColor = true;
            this.FiniteCB.CheckedChanged += new System.EventHandler(this.FiniteCB_CheckedChanged);
            // 
            // PeriodicCB
            // 
            this.PeriodicCB.AutoSize = true;
            this.PeriodicCB.Location = new System.Drawing.Point(35, 198);
            this.PeriodicCB.Name = "PeriodicCB";
            this.PeriodicCB.Size = new System.Drawing.Size(163, 24);
            this.PeriodicCB.TabIndex = 21;
            this.PeriodicCB.Text = "Periodic Boundary";
            this.PeriodicCB.UseVisualStyleBackColor = true;
            // 
            // NullCB
            // 
            this.NullCB.AutoSize = true;
            this.NullCB.Location = new System.Drawing.Point(35, 229);
            this.NullCB.Name = "NullCB";
            this.NullCB.Size = new System.Drawing.Size(133, 24);
            this.NullCB.TabIndex = 22;
            this.NullCB.Text = "Null Boundary";
            this.NullCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 576);
            this.Controls.Add(this.NullCB);
            this.Controls.Add(this.PeriodicCB);
            this.Controls.Add(this.FiniteCB);
            this.Controls.Add(this.InfiniteCB);
            this.Controls.Add(this.ArraySizeLabel);
            this.Controls.Add(this.ArraySizeTB);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.NumRule_Txt);
            this.Controls.Add(this.ChangedStatesTextBox);
            this.Controls.Add(this.HowManyStatesTextBox);
            this.Controls.Add(this.TimeStepsTextBox);
            this.Controls.Add(this.RuleLabel);
            this.Controls.Add(this.ChangedStatesLabel);
            this.Controls.Add(this.HowManyStatesLabel);
            this.Controls.Add(this.TimeStepsLabel);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.Show_TxtBox);
            this.Name = "Form1";
            this.Text = "Wolfram Rules";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Label TimeStepsLabel;
        private System.Windows.Forms.Label HowManyStatesLabel;
        private System.Windows.Forms.Label ChangedStatesLabel;
        private System.Windows.Forms.Label RuleLabel;
        private System.Windows.Forms.TextBox TimeStepsTextBox;
        private System.Windows.Forms.TextBox HowManyStatesTextBox;
        private System.Windows.Forms.TextBox ChangedStatesTextBox;
        private System.Windows.Forms.TextBox NumRule_Txt;
        private System.Windows.Forms.TextBox Show_TxtBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox ArraySizeTB;
        private System.Windows.Forms.Label ArraySizeLabel;
        private System.Windows.Forms.CheckBox InfiniteCB;
        private System.Windows.Forms.CheckBox FiniteCB;
        private System.Windows.Forms.CheckBox PeriodicCB;
        private System.Windows.Forms.CheckBox NullCB;
    }
}

