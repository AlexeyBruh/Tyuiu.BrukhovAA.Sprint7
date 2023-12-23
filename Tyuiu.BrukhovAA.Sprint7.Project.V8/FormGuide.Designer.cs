
namespace Tyuiu.BrukhovAA.Sprint7.Project.V8
{
    partial class FormGuide
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
            this.panelGuide_BAA = new System.Windows.Forms.Panel();
            this.textBoxGuide_BAA = new System.Windows.Forms.TextBox();
            this.panelGuide_BAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGuide_BAA
            // 
            this.panelGuide_BAA.Controls.Add(this.textBoxGuide_BAA);
            this.panelGuide_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuide_BAA.Location = new System.Drawing.Point(0, 0);
            this.panelGuide_BAA.Name = "panelGuide_BAA";
            this.panelGuide_BAA.Size = new System.Drawing.Size(376, 503);
            this.panelGuide_BAA.TabIndex = 0;
            // 
            // textBoxGuide_BAA
            // 
            this.textBoxGuide_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGuide_BAA.Location = new System.Drawing.Point(0, 0);
            this.textBoxGuide_BAA.Multiline = true;
            this.textBoxGuide_BAA.Name = "textBoxGuide_BAA";
            this.textBoxGuide_BAA.ReadOnly = true;
            this.textBoxGuide_BAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGuide_BAA.Size = new System.Drawing.Size(376, 503);
            this.textBoxGuide_BAA.TabIndex = 0;
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(376, 503);
            this.Controls.Add(this.panelGuide_BAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGuide";
            this.Text = "Краткое руководство";
            this.panelGuide_BAA.ResumeLayout(false);
            this.panelGuide_BAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGuide_BAA;
        private System.Windows.Forms.TextBox textBoxGuide_BAA;
    }
}