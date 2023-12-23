
namespace Tyuiu.BrukhovAA.Sprint7.Project.V8
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.toolTip_BAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_BAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_BAA = new System.Windows.Forms.SaveFileDialog();
            this.labelMainMenu_BAA = new System.Windows.Forms.Label();
            this.buttonHelp_BAA = new System.Windows.Forms.Button();
            this.buttonGuide_BAA = new System.Windows.Forms.Button();
            this.buttonStart_BAA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMainMenu_BAA
            // 
            this.labelMainMenu_BAA.AutoSize = true;
            this.labelMainMenu_BAA.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu_BAA.Location = new System.Drawing.Point(12, 9);
            this.labelMainMenu_BAA.Name = "labelMainMenu_BAA";
            this.labelMainMenu_BAA.Size = new System.Drawing.Size(233, 41);
            this.labelMainMenu_BAA.TabIndex = 0;
            this.labelMainMenu_BAA.Text = "Главное меню\r\n";
            this.labelMainMenu_BAA.Click += new System.EventHandler(this.labelMainMenu_BAA_Click);
            // 
            // buttonHelp_BAA
            // 
            this.buttonHelp_BAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BAA.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp_BAA.Location = new System.Drawing.Point(381, 207);
            this.buttonHelp_BAA.Name = "buttonHelp_BAA";
            this.buttonHelp_BAA.Size = new System.Drawing.Size(46, 42);
            this.buttonHelp_BAA.TabIndex = 1;
            this.buttonHelp_BAA.Text = "?";
            this.buttonHelp_BAA.UseVisualStyleBackColor = false;
            this.buttonHelp_BAA.Click += new System.EventHandler(this.buttonHelp_BAA_Click);
            // 
            // buttonGuide_BAA
            // 
            this.buttonGuide_BAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGuide_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuide_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuide_BAA.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuide_BAA.Location = new System.Drawing.Point(12, 207);
            this.buttonGuide_BAA.Name = "buttonGuide_BAA";
            this.buttonGuide_BAA.Size = new System.Drawing.Size(150, 42);
            this.buttonGuide_BAA.TabIndex = 2;
            this.buttonGuide_BAA.Text = "Краткое руководство";
            this.buttonGuide_BAA.UseVisualStyleBackColor = false;
            this.buttonGuide_BAA.Click += new System.EventHandler(this.buttonGuide_BAA_Click);
            // 
            // buttonStart_BAA
            // 
            this.buttonStart_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart_BAA.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart_BAA.Location = new System.Drawing.Point(106, 102);
            this.buttonStart_BAA.Name = "buttonStart_BAA";
            this.buttonStart_BAA.Size = new System.Drawing.Size(226, 56);
            this.buttonStart_BAA.TabIndex = 3;
            this.buttonStart_BAA.Text = "Начать работу с базой данных";
            this.buttonStart_BAA.UseVisualStyleBackColor = true;
            this.buttonStart_BAA.Click += new System.EventHandler(this.buttonStart_BAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.buttonStart_BAA);
            this.Controls.Add(this.buttonGuide_BAA);
            this.Controls.Add(this.buttonHelp_BAA);
            this.Controls.Add(this.labelMainMenu_BAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip_BAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_BAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_BAA;
        private System.Windows.Forms.Label labelMainMenu_BAA;
        private System.Windows.Forms.Button buttonHelp_BAA;
        private System.Windows.Forms.Button buttonGuide_BAA;
        private System.Windows.Forms.Button buttonStart_BAA;
    }
}

