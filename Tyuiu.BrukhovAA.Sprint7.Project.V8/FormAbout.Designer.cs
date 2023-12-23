
namespace Tyuiu.BrukhovAA.Sprint7.Project.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelHelp_BAA = new System.Windows.Forms.Label();
            this.buttonOK_BAA = new System.Windows.Forms.Button();
            this.pictureBoxPortret_BAA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortret_BAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHelp_BAA
            // 
            this.labelHelp_BAA.AutoSize = true;
            this.labelHelp_BAA.Location = new System.Drawing.Point(136, 9);
            this.labelHelp_BAA.Name = "labelHelp_BAA";
            this.labelHelp_BAA.Size = new System.Drawing.Size(284, 117);
            this.labelHelp_BAA.TabIndex = 3;
            this.labelHelp_BAA.Text = resources.GetString("labelHelp_BAA.Text");
            this.labelHelp_BAA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK_BAA
            // 
            this.buttonOK_BAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK_BAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOK_BAA.Location = new System.Drawing.Point(345, 130);
            this.buttonOK_BAA.Name = "buttonOK_BAA";
            this.buttonOK_BAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_BAA.TabIndex = 5;
            this.buttonOK_BAA.Text = "Ок";
            this.buttonOK_BAA.UseVisualStyleBackColor = true;
            this.buttonOK_BAA.Click += new System.EventHandler(this.buttonOK_BAA_Click);
            // 
            // pictureBoxPortret_BAA
            // 
            this.pictureBoxPortret_BAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPortret_BAA.Image")));
            this.pictureBoxPortret_BAA.Location = new System.Drawing.Point(12, 9);
            this.pictureBoxPortret_BAA.Name = "pictureBoxPortret_BAA";
            this.pictureBoxPortret_BAA.Size = new System.Drawing.Size(109, 141);
            this.pictureBoxPortret_BAA.TabIndex = 6;
            this.pictureBoxPortret_BAA.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.pictureBoxPortret_BAA);
            this.Controls.Add(this.buttonOK_BAA);
            this.Controls.Add(this.labelHelp_BAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortret_BAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelp_BAA;
        private System.Windows.Forms.Button buttonOK_BAA;
        private System.Windows.Forms.PictureBox pictureBoxPortret_BAA;
    }
}