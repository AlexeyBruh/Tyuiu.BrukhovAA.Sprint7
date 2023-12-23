
namespace Tyuiu.BrukhovAA.Sprint7.Project.V8
{
    partial class FormBaseData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseData));
            this.panelButtons_BAA = new System.Windows.Forms.Panel();
            this.panelIndicators_BAA = new System.Windows.Forms.Panel();
            this.panelData_BAA = new System.Windows.Forms.Panel();
            this.groupBoxData_BAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_BAA = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile_BAA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelButtons_BAA.SuspendLayout();
            this.panelData_BAA.SuspendLayout();
            this.groupBoxData_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_BAA
            // 
            this.panelButtons_BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons_BAA.Controls.Add(this.button1);
            this.panelButtons_BAA.Controls.Add(this.buttonOpenFile_BAA);
            this.panelButtons_BAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons_BAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BAA.Name = "panelButtons_BAA";
            this.panelButtons_BAA.Size = new System.Drawing.Size(198, 437);
            this.panelButtons_BAA.TabIndex = 0;
            // 
            // panelIndicators_BAA
            // 
            this.panelIndicators_BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIndicators_BAA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIndicators_BAA.Location = new System.Drawing.Point(198, 366);
            this.panelIndicators_BAA.Name = "panelIndicators_BAA";
            this.panelIndicators_BAA.Size = new System.Drawing.Size(664, 71);
            this.panelIndicators_BAA.TabIndex = 1;
            // 
            // panelData_BAA
            // 
            this.panelData_BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData_BAA.Controls.Add(this.groupBoxData_BAA);
            this.panelData_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData_BAA.Location = new System.Drawing.Point(198, 0);
            this.panelData_BAA.Name = "panelData_BAA";
            this.panelData_BAA.Size = new System.Drawing.Size(664, 366);
            this.panelData_BAA.TabIndex = 2;
            // 
            // groupBoxData_BAA
            // 
            this.groupBoxData_BAA.Controls.Add(this.dataGridViewData_BAA);
            this.groupBoxData_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxData_BAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData_BAA.Name = "groupBoxData_BAA";
            this.groupBoxData_BAA.Size = new System.Drawing.Size(662, 364);
            this.groupBoxData_BAA.TabIndex = 0;
            this.groupBoxData_BAA.TabStop = false;
            // 
            // dataGridViewData_BAA
            // 
            this.dataGridViewData_BAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData_BAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewData_BAA.Name = "dataGridViewData_BAA";
            this.dataGridViewData_BAA.Size = new System.Drawing.Size(656, 345);
            this.dataGridViewData_BAA.TabIndex = 0;
            this.dataGridViewData_BAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_BAA_CellContentClick);
            // 
            // buttonOpenFile_BAA
            // 
            this.buttonOpenFile_BAA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFile_BAA.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_BAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BAA.Image")));
            this.buttonOpenFile_BAA.Location = new System.Drawing.Point(11, 11);
            this.buttonOpenFile_BAA.Name = "buttonOpenFile_BAA";
            this.buttonOpenFile_BAA.Size = new System.Drawing.Size(75, 71);
            this.buttonOpenFile_BAA.TabIndex = 0;
            this.buttonOpenFile_BAA.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(107, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 71);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormBaseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 437);
            this.Controls.Add(this.panelData_BAA);
            this.Controls.Add(this.panelIndicators_BAA);
            this.Controls.Add(this.panelButtons_BAA);
            this.MinimumSize = new System.Drawing.Size(878, 476);
            this.Name = "FormBaseData";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelButtons_BAA.ResumeLayout(false);
            this.panelData_BAA.ResumeLayout(false);
            this.groupBoxData_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BAA;
        private System.Windows.Forms.Panel panelIndicators_BAA;
        private System.Windows.Forms.Panel panelData_BAA;
        private System.Windows.Forms.GroupBox groupBoxData_BAA;
        private System.Windows.Forms.DataGridView dataGridViewData_BAA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOpenFile_BAA;
    }
}