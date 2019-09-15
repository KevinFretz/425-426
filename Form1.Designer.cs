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
            this.RuleLabel = new System.Windows.Forms.Label();
            this.TimeStepsTextBox = new System.Windows.Forms.TextBox();
            this.HowManyStatesTextBox = new System.Windows.Forms.TextBox();
            this.NumRule_Txt = new System.Windows.Forms.TextBox();
            this.ArraySizeTB = new System.Windows.Forms.TextBox();
            this.ArraySizeLabel = new System.Windows.Forms.Label();
            this.InfiniteCB = new System.Windows.Forms.CheckBox();
            this.FiniteCB = new System.Windows.Forms.CheckBox();
            this.PeriodicCB = new System.Windows.Forms.CheckBox();
            this.NullCB = new System.Windows.Forms.CheckBox();
            this.ParallelCB = new System.Windows.Forms.CheckBox();
            this.SequentialCB = new System.Windows.Forms.CheckBox();
            this.ChangedStatesCLB = new System.Windows.Forms.CheckedListBox();
            this.LeftToRight = new System.Windows.Forms.CheckBox();
            this.RightToLeft = new System.Windows.Forms.CheckBox();
            this.Random = new System.Windows.Forms.CheckBox();
            this.RandomizeSS = new System.Windows.Forms.Button();
            this.UserCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(465, 521);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(146, 43);
            this.BTN_Submit.TabIndex = 4;
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
            this.TimeStepsTextBox.TabIndex = 1;
            // 
            // HowManyStatesTextBox
            // 
            this.HowManyStatesTextBox.Location = new System.Drawing.Point(488, 198);
            this.HowManyStatesTextBox.Name = "HowManyStatesTextBox";
            this.HowManyStatesTextBox.Size = new System.Drawing.Size(100, 26);
            this.HowManyStatesTextBox.TabIndex = 2;
            this.HowManyStatesTextBox.TextChanged += new System.EventHandler(this.HowManyStatesTextBox_TextChanged);
            // 
            // NumRule_Txt
            // 
            this.NumRule_Txt.Location = new System.Drawing.Point(488, 449);
            this.NumRule_Txt.Name = "NumRule_Txt";
            this.NumRule_Txt.Size = new System.Drawing.Size(100, 26);
            this.NumRule_Txt.TabIndex = 4;
            // 
            // ArraySizeTB
            // 
            this.ArraySizeTB.Location = new System.Drawing.Point(35, 449);
            this.ArraySizeTB.Name = "ArraySizeTB";
            this.ArraySizeTB.Size = new System.Drawing.Size(111, 26);
            this.ArraySizeTB.TabIndex = 17;
            this.ArraySizeTB.TextChanged += new System.EventHandler(this.ArraySizeTB_TextChanged);
            // 
            // ArraySizeLabel
            // 
            this.ArraySizeLabel.AutoSize = true;
            this.ArraySizeLabel.Location = new System.Drawing.Point(50, 426);
            this.ArraySizeLabel.Name = "ArraySizeLabel";
            this.ArraySizeLabel.Size = new System.Drawing.Size(81, 20);
            this.ArraySizeLabel.TabIndex = 18;
            this.ArraySizeLabel.Text = "Array Size";
            // 
            // InfiniteCB
            // 
            this.InfiniteCB.AutoSize = true;
            this.InfiniteCB.Location = new System.Drawing.Point(35, 67);
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
            this.FiniteCB.Location = new System.Drawing.Point(127, 67);
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
            this.PeriodicCB.Location = new System.Drawing.Point(35, 334);
            this.PeriodicCB.Name = "PeriodicCB";
            this.PeriodicCB.Size = new System.Drawing.Size(163, 24);
            this.PeriodicCB.TabIndex = 21;
            this.PeriodicCB.Text = "Periodic Boundary";
            this.PeriodicCB.UseVisualStyleBackColor = true;
            this.PeriodicCB.CheckedChanged += new System.EventHandler(this.PeriodicCB_CheckedChanged);
            // 
            // NullCB
            // 
            this.NullCB.AutoSize = true;
            this.NullCB.Location = new System.Drawing.Point(35, 364);
            this.NullCB.Name = "NullCB";
            this.NullCB.Size = new System.Drawing.Size(133, 24);
            this.NullCB.TabIndex = 22;
            this.NullCB.Text = "Null Boundary";
            this.NullCB.UseVisualStyleBackColor = true;
            this.NullCB.CheckedChanged += new System.EventHandler(this.NullCB_CheckedChanged);
            // 
            // ParallelCB
            // 
            this.ParallelCB.AutoSize = true;
            this.ParallelCB.Location = new System.Drawing.Point(35, 141);
            this.ParallelCB.Name = "ParallelCB";
            this.ParallelCB.Size = new System.Drawing.Size(86, 24);
            this.ParallelCB.TabIndex = 28;
            this.ParallelCB.Text = "Parallel";
            this.ParallelCB.UseVisualStyleBackColor = true;
            this.ParallelCB.CheckedChanged += new System.EventHandler(this.ParallelCB_CheckedChanged);
            // 
            // SequentialCB
            // 
            this.SequentialCB.AutoSize = true;
            this.SequentialCB.Location = new System.Drawing.Point(127, 141);
            this.SequentialCB.Name = "SequentialCB";
            this.SequentialCB.Size = new System.Drawing.Size(111, 24);
            this.SequentialCB.TabIndex = 29;
            this.SequentialCB.Text = "Sequential";
            this.SequentialCB.UseVisualStyleBackColor = true;
            this.SequentialCB.CheckedChanged += new System.EventHandler(this.SequentialCB_CheckedChanged);
            // 
            // ChangedStatesCLB
            // 
            this.ChangedStatesCLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChangedStatesCLB.CheckOnClick = true;
            this.ChangedStatesCLB.FormattingEnabled = true;
            this.ChangedStatesCLB.HorizontalScrollbar = true;
            this.ChangedStatesCLB.Location = new System.Drawing.Point(269, 250);
            this.ChangedStatesCLB.Margin = new System.Windows.Forms.Padding(1);
            this.ChangedStatesCLB.MultiColumn = true;
            this.ChangedStatesCLB.Name = "ChangedStatesCLB";
            this.ChangedStatesCLB.ScrollAlwaysVisible = true;
            this.ChangedStatesCLB.Size = new System.Drawing.Size(555, 88);
            this.ChangedStatesCLB.TabIndex = 3;
            // 
            // LeftToRight
            // 
            this.LeftToRight.AutoSize = true;
            this.LeftToRight.Location = new System.Drawing.Point(35, 190);
            this.LeftToRight.Name = "LeftToRight";
            this.LeftToRight.Size = new System.Drawing.Size(127, 24);
            this.LeftToRight.TabIndex = 32;
            this.LeftToRight.Text = "Left To Right";
            this.LeftToRight.UseVisualStyleBackColor = true;
            this.LeftToRight.CheckedChanged += new System.EventHandler(this.LeftToRight_CheckedChanged);
            // 
            // RightToLeft
            // 
            this.RightToLeft.AutoSize = true;
            this.RightToLeft.Location = new System.Drawing.Point(35, 220);
            this.RightToLeft.Name = "RightToLeft";
            this.RightToLeft.Size = new System.Drawing.Size(127, 24);
            this.RightToLeft.TabIndex = 33;
            this.RightToLeft.Text = "Right To Left";
            this.RightToLeft.UseVisualStyleBackColor = true;
            this.RightToLeft.CheckedChanged += new System.EventHandler(this.RightToLeft_CheckedChanged);
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(35, 250);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(96, 24);
            this.Random.TabIndex = 34;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckedChanged += new System.EventHandler(this.Random_CheckedChanged);
            // 
            // RandomizeSS
            // 
            this.RandomizeSS.BackColor = System.Drawing.SystemColors.Control;
            this.RandomizeSS.Location = new System.Drawing.Point(854, 261);
            this.RandomizeSS.Name = "RandomizeSS";
            this.RandomizeSS.Size = new System.Drawing.Size(203, 47);
            this.RandomizeSS.TabIndex = 35;
            this.RandomizeSS.Text = "Randomize Starting State";
            this.RandomizeSS.UseVisualStyleBackColor = false;
            this.RandomizeSS.Click += new System.EventHandler(this.RandomizeSS_Click);
            // 
            // UserCB
            // 
            this.UserCB.AutoSize = true;
            this.UserCB.Location = new System.Drawing.Point(35, 281);
            this.UserCB.Name = "UserCB";
            this.UserCB.Size = new System.Drawing.Size(69, 24);
            this.UserCB.TabIndex = 36;
            this.UserCB.Text = "User";
            this.UserCB.UseVisualStyleBackColor = true;
            this.UserCB.CheckedChanged += new System.EventHandler(this.UserCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1081, 639);
            this.Controls.Add(this.UserCB);
            this.Controls.Add(this.RandomizeSS);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.RightToLeft);
            this.Controls.Add(this.LeftToRight);
            this.Controls.Add(this.ChangedStatesCLB);
            this.Controls.Add(this.SequentialCB);
            this.Controls.Add(this.ParallelCB);
            this.Controls.Add(this.NullCB);
            this.Controls.Add(this.PeriodicCB);
            this.Controls.Add(this.FiniteCB);
            this.Controls.Add(this.InfiniteCB);
            this.Controls.Add(this.ArraySizeLabel);
            this.Controls.Add(this.ArraySizeTB);
            this.Controls.Add(this.NumRule_Txt);
            this.Controls.Add(this.HowManyStatesTextBox);
            this.Controls.Add(this.TimeStepsTextBox);
            this.Controls.Add(this.RuleLabel);
            this.Controls.Add(this.HowManyStatesLabel);
            this.Controls.Add(this.TimeStepsLabel);
            this.Controls.Add(this.BTN_Submit);
            this.Name = "Form1";
            this.Text = "Wolfram Rules";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Label TimeStepsLabel;
        private System.Windows.Forms.Label HowManyStatesLabel;
        private System.Windows.Forms.Label RuleLabel;
        private System.Windows.Forms.TextBox TimeStepsTextBox;
        private System.Windows.Forms.TextBox HowManyStatesTextBox;
        private System.Windows.Forms.TextBox NumRule_Txt;
        private System.Windows.Forms.TextBox ArraySizeTB;
        private System.Windows.Forms.Label ArraySizeLabel;
        private System.Windows.Forms.CheckBox InfiniteCB;
        private System.Windows.Forms.CheckBox FiniteCB;
        private System.Windows.Forms.CheckBox PeriodicCB;
        private System.Windows.Forms.CheckBox NullCB;
        private System.Windows.Forms.CheckBox ParallelCB;
        private System.Windows.Forms.CheckBox SequentialCB;
        private System.Windows.Forms.CheckedListBox ChangedStatesCLB;
        private System.Windows.Forms.CheckBox LeftToRight;
        private System.Windows.Forms.CheckBox RightToLeft;
        private System.Windows.Forms.CheckBox Random;
        private System.Windows.Forms.Button RandomizeSS;
        private System.Windows.Forms.CheckBox UserCB;
    }
}

