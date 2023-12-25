
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.panelGuide_BAA = new System.Windows.Forms.Panel();
            this.labelGuide_BAA = new System.Windows.Forms.Label();
            this.panelGuide_BAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGuide_BAA
            // 
            this.panelGuide_BAA.Controls.Add(this.labelGuide_BAA);
            this.panelGuide_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuide_BAA.Location = new System.Drawing.Point(0, 0);
            this.panelGuide_BAA.Name = "panelGuide_BAA";
            this.panelGuide_BAA.Size = new System.Drawing.Size(528, 314);
            this.panelGuide_BAA.TabIndex = 0;
            // 
            // labelGuide_BAA
            // 
            this.labelGuide_BAA.AutoSize = true;
            this.labelGuide_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGuide_BAA.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuide_BAA.Location = new System.Drawing.Point(0, 0);
            this.labelGuide_BAA.Name = "labelGuide_BAA";
            this.labelGuide_BAA.Size = new System.Drawing.Size(523, 304);
            this.labelGuide_BAA.TabIndex = 0;
            this.labelGuide_BAA.Text = resources.GetString("labelGuide_BAA.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(528, 314);
            this.Controls.Add(this.panelGuide_BAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое руководство";
            this.panelGuide_BAA.ResumeLayout(false);
            this.panelGuide_BAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGuide_BAA;
        private System.Windows.Forms.Label labelGuide_BAA;
    }
}