namespace WolframRules
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayVScroll = new System.Windows.Forms.VScrollBar();
            this.DisplayHScroll = new System.Windows.Forms.HScrollBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.DisplayHScroll);
            this.panel1.Controls.Add(this.DisplayVScroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 1044);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DisplayVScroll
            // 
            this.DisplayVScroll.Location = new System.Drawing.Point(1443, 9);
            this.DisplayVScroll.Name = "DisplayVScroll";
            this.DisplayVScroll.Size = new System.Drawing.Size(26, 1017);
            this.DisplayVScroll.TabIndex = 0;
            this.DisplayVScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DisplayVScroll_Scroll);
            // 
            // DisplayHScroll
            // 
            this.DisplayHScroll.Location = new System.Drawing.Point(56, 1009);
            this.DisplayHScroll.Name = "DisplayHScroll";
            this.DisplayHScroll.Size = new System.Drawing.Size(1373, 26);
            this.DisplayHScroll.TabIndex = 1;
            this.DisplayHScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DisplayHScroll_Scroll);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.ClientSize = new System.Drawing.Size(1478, 1044);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Window";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form2_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar DisplayVScroll;
        private System.Windows.Forms.HScrollBar DisplayHScroll;
    }
}