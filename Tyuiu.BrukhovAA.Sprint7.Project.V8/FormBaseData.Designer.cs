
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelIndicators_BAA = new System.Windows.Forms.Panel();
            this.groupBoxStatistic_BAA = new System.Windows.Forms.GroupBox();
            this.panelSearch_BAA = new System.Windows.Forms.Panel();
            this.groupBoxTop_BAA = new System.Windows.Forms.GroupBox();
            this.groupBoxButtonsForData_BAA = new System.Windows.Forms.GroupBox();
            this.buttonSearch_BAA = new System.Windows.Forms.Button();
            this.labelSearch_BAA = new System.Windows.Forms.Label();
            this.textBoxSearch_BAA = new System.Windows.Forms.TextBox();
            this.buttonAddRows_BAA = new System.Windows.Forms.Button();
            this.buttonDeleteRow_BAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_BAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_BAA = new System.Windows.Forms.Button();
            this.toolTip_BAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_BAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_BAA = new System.Windows.Forms.SaveFileDialog();
            this.panelData_BAA = new System.Windows.Forms.Panel();
            this.groupBoxData_BAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_BAA = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelIndicators_BAA.SuspendLayout();
            this.panelSearch_BAA.SuspendLayout();
            this.groupBoxTop_BAA.SuspendLayout();
            this.groupBoxButtonsForData_BAA.SuspendLayout();
            this.panelData_BAA.SuspendLayout();
            this.groupBoxData_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIndicators_BAA
            // 
            this.panelIndicators_BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIndicators_BAA.Controls.Add(this.groupBoxStatistic_BAA);
            this.panelIndicators_BAA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIndicators_BAA.Location = new System.Drawing.Point(0, 482);
            this.panelIndicators_BAA.Name = "panelIndicators_BAA";
            this.panelIndicators_BAA.Size = new System.Drawing.Size(884, 91);
            this.panelIndicators_BAA.TabIndex = 1;
            // 
            // groupBoxStatistic_BAA
            // 
            this.groupBoxStatistic_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStatistic_BAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStatistic_BAA.Name = "groupBoxStatistic_BAA";
            this.groupBoxStatistic_BAA.Size = new System.Drawing.Size(882, 89);
            this.groupBoxStatistic_BAA.TabIndex = 0;
            this.groupBoxStatistic_BAA.TabStop = false;
            this.groupBoxStatistic_BAA.Text = "Статистика";
            // 
            // panelSearch_BAA
            // 
            this.panelSearch_BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch_BAA.Controls.Add(this.groupBoxTop_BAA);
            this.panelSearch_BAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch_BAA.Location = new System.Drawing.Point(0, 0);
            this.panelSearch_BAA.Name = "panelSearch_BAA";
            this.panelSearch_BAA.Size = new System.Drawing.Size(884, 86);
            this.panelSearch_BAA.TabIndex = 3;
            // 
            // groupBoxTop_BAA
            // 
            this.groupBoxTop_BAA.Controls.Add(this.groupBoxButtonsForData_BAA);
            this.groupBoxTop_BAA.Controls.Add(this.buttonOpenFile_BAA);
            this.groupBoxTop_BAA.Controls.Add(this.buttonSaveFile_BAA);
            this.groupBoxTop_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTop_BAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTop_BAA.Name = "groupBoxTop_BAA";
            this.groupBoxTop_BAA.Size = new System.Drawing.Size(882, 84);
            this.groupBoxTop_BAA.TabIndex = 0;
            this.groupBoxTop_BAA.TabStop = false;
            // 
            // groupBoxButtonsForData_BAA
            // 
            this.groupBoxButtonsForData_BAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxButtonsForData_BAA.Controls.Add(this.buttonSearch_BAA);
            this.groupBoxButtonsForData_BAA.Controls.Add(this.labelSearch_BAA);
            this.groupBoxButtonsForData_BAA.Controls.Add(this.textBoxSearch_BAA);
            this.groupBoxButtonsForData_BAA.Controls.Add(this.buttonAddRows_BAA);
            this.groupBoxButtonsForData_BAA.Controls.Add(this.buttonDeleteRow_BAA);
            this.groupBoxButtonsForData_BAA.Location = new System.Drawing.Point(159, 0);
            this.groupBoxButtonsForData_BAA.Name = "groupBoxButtonsForData_BAA";
            this.groupBoxButtonsForData_BAA.Size = new System.Drawing.Size(722, 85);
            this.groupBoxButtonsForData_BAA.TabIndex = 1;
            this.groupBoxButtonsForData_BAA.TabStop = false;
            this.groupBoxButtonsForData_BAA.Text = "Управление таблицей";
            // 
            // buttonSearch_BAA
            // 
            this.buttonSearch_BAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch_BAA.Location = new System.Drawing.Point(637, 54);
            this.buttonSearch_BAA.Name = "buttonSearch_BAA";
            this.buttonSearch_BAA.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch_BAA.TabIndex = 3;
            this.buttonSearch_BAA.Text = "Найти";
            this.buttonSearch_BAA.UseVisualStyleBackColor = false;
            this.buttonSearch_BAA.Click += new System.EventHandler(this.buttonSearch_BAA_Click);
            // 
            // labelSearch_BAA
            // 
            this.labelSearch_BAA.AutoSize = true;
            this.labelSearch_BAA.Location = new System.Drawing.Point(505, 12);
            this.labelSearch_BAA.Name = "labelSearch_BAA";
            this.labelSearch_BAA.Size = new System.Drawing.Size(39, 13);
            this.labelSearch_BAA.TabIndex = 2;
            this.labelSearch_BAA.Text = "Поиск";
            // 
            // textBoxSearch_BAA
            // 
            this.textBoxSearch_BAA.Location = new System.Drawing.Point(508, 28);
            this.textBoxSearch_BAA.Name = "textBoxSearch_BAA";
            this.textBoxSearch_BAA.Size = new System.Drawing.Size(207, 20);
            this.textBoxSearch_BAA.TabIndex = 1;
            this.textBoxSearch_BAA.Text = "Введите искомое значение";
            // 
            // buttonAddRows_BAA
            // 
            this.buttonAddRows_BAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddRows_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddRows_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddRows_BAA.Location = new System.Drawing.Point(6, 19);
            this.buttonAddRows_BAA.Name = "buttonAddRows_BAA";
            this.buttonAddRows_BAA.Size = new System.Drawing.Size(112, 25);
            this.buttonAddRows_BAA.TabIndex = 0;
            this.buttonAddRows_BAA.Text = "Добавить строку";
            this.buttonAddRows_BAA.UseVisualStyleBackColor = false;
            this.buttonAddRows_BAA.Click += new System.EventHandler(this.buttonAddRows_BAA_Click);
            // 
            // buttonDeleteRow_BAA
            // 
            this.buttonDeleteRow_BAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteRow_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteRow_BAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteRow_BAA.Location = new System.Drawing.Point(6, 54);
            this.buttonDeleteRow_BAA.Name = "buttonDeleteRow_BAA";
            this.buttonDeleteRow_BAA.Size = new System.Drawing.Size(112, 25);
            this.buttonDeleteRow_BAA.TabIndex = 0;
            this.buttonDeleteRow_BAA.Text = "Удалить строку";
            this.buttonDeleteRow_BAA.UseVisualStyleBackColor = false;
            this.buttonDeleteRow_BAA.Click += new System.EventHandler(this.buttonDeleteRow_BAA_Click);
            // 
            // buttonOpenFile_BAA
            // 
            this.buttonOpenFile_BAA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFile_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_BAA.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_BAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BAA.Image")));
            this.buttonOpenFile_BAA.Location = new System.Drawing.Point(6, 11);
            this.buttonOpenFile_BAA.Name = "buttonOpenFile_BAA";
            this.buttonOpenFile_BAA.Size = new System.Drawing.Size(70, 68);
            this.buttonOpenFile_BAA.TabIndex = 0;
            this.buttonOpenFile_BAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_BAA.Click += new System.EventHandler(this.buttonOpenFile_BAA_Click);
            // 
            // buttonSaveFile_BAA
            // 
            this.buttonSaveFile_BAA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveFile_BAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_BAA.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile_BAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_BAA.Image")));
            this.buttonSaveFile_BAA.Location = new System.Drawing.Point(82, 11);
            this.buttonSaveFile_BAA.Name = "buttonSaveFile_BAA";
            this.buttonSaveFile_BAA.Size = new System.Drawing.Size(70, 68);
            this.buttonSaveFile_BAA.TabIndex = 0;
            this.buttonSaveFile_BAA.UseVisualStyleBackColor = false;
            this.buttonSaveFile_BAA.Click += new System.EventHandler(this.buttonSaveFile_BAA_Click);
            // 
            // panelData_BAA
            // 
            this.panelData_BAA.Controls.Add(this.groupBoxData_BAA);
            this.panelData_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData_BAA.Location = new System.Drawing.Point(0, 86);
            this.panelData_BAA.Name = "panelData_BAA";
            this.panelData_BAA.Size = new System.Drawing.Size(884, 396);
            this.panelData_BAA.TabIndex = 4;
            // 
            // groupBoxData_BAA
            // 
            this.groupBoxData_BAA.Controls.Add(this.dataGridViewData_BAA);
            this.groupBoxData_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxData_BAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData_BAA.Name = "groupBoxData_BAA";
            this.groupBoxData_BAA.Size = new System.Drawing.Size(884, 396);
            this.groupBoxData_BAA.TabIndex = 0;
            this.groupBoxData_BAA.TabStop = false;
            // 
            // dataGridViewData_BAA
            // 
            this.dataGridViewData_BAA.AllowUserToAddRows = false;
            this.dataGridViewData_BAA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewData_BAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_BAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnSurname,
            this.ColumnName,
            this.ColumnLastname,
            this.ColumnBirth,
            this.ColumnAges,
            this.ColumnPayment});
            this.dataGridViewData_BAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData_BAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewData_BAA.Name = "dataGridViewData_BAA";
            this.dataGridViewData_BAA.RowHeadersVisible = false;
            this.dataGridViewData_BAA.Size = new System.Drawing.Size(878, 377);
            this.dataGridViewData_BAA.TabIndex = 0;
            // 
            // ColumnID
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnID.HeaderText = "табельный номер";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 125;
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Фамилия";
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // ColumnLastname
            // 
            this.ColumnLastname.HeaderText = "Отчество";
            this.ColumnLastname.Name = "ColumnLastname";
            this.ColumnLastname.Width = 125;
            // 
            // ColumnBirth
            // 
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.ColumnBirth.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnBirth.HeaderText = "дата рождения";
            this.ColumnBirth.Name = "ColumnBirth";
            this.ColumnBirth.Width = 125;
            // 
            // ColumnAges
            // 
            dataGridViewCellStyle11.NullValue = null;
            this.ColumnAges.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnAges.HeaderText = "стаж";
            this.ColumnAges.Name = "ColumnAges";
            this.ColumnAges.Width = 125;
            // 
            // ColumnPayment
            // 
            dataGridViewCellStyle12.NullValue = null;
            this.ColumnPayment.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnPayment.HeaderText = "оклад";
            this.ColumnPayment.Name = "ColumnPayment";
            this.ColumnPayment.Width = 125;
            // 
            // FormBaseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 573);
            this.Controls.Add(this.panelData_BAA);
            this.Controls.Add(this.panelSearch_BAA);
            this.Controls.Add(this.panelIndicators_BAA);
            this.MinimumSize = new System.Drawing.Size(878, 476);
            this.Name = "FormBaseData";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelIndicators_BAA.ResumeLayout(false);
            this.panelSearch_BAA.ResumeLayout(false);
            this.groupBoxTop_BAA.ResumeLayout(false);
            this.groupBoxButtonsForData_BAA.ResumeLayout(false);
            this.groupBoxButtonsForData_BAA.PerformLayout();
            this.panelData_BAA.ResumeLayout(false);
            this.groupBoxData_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIndicators_BAA;
        private System.Windows.Forms.GroupBox groupBoxStatistic_BAA;
        private System.Windows.Forms.Panel panelSearch_BAA;
        private System.Windows.Forms.GroupBox groupBoxTop_BAA;
        private System.Windows.Forms.Button buttonOpenFile_BAA;
        private System.Windows.Forms.Button buttonSaveFile_BAA;
        private System.Windows.Forms.ToolTip toolTip_BAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_BAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_BAA;
        private System.Windows.Forms.Panel panelData_BAA;
        private System.Windows.Forms.GroupBox groupBoxData_BAA;
        private System.Windows.Forms.GroupBox groupBoxButtonsForData_BAA;
        private System.Windows.Forms.Button buttonAddRows_BAA;
        private System.Windows.Forms.Button buttonDeleteRow_BAA;
        private System.Windows.Forms.DataGridView dataGridViewData_BAA;
        private System.Windows.Forms.Button buttonSearch_BAA;
        private System.Windows.Forms.Label labelSearch_BAA;
        private System.Windows.Forms.TextBox textBoxSearch_BAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAges;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayment;
    }
}