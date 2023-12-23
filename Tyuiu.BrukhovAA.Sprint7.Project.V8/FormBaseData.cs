using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BrukhovAA.Sprint7.Project.V8.Lib;

namespace Tyuiu.BrukhovAA.Sprint7.Project.V8
{
    public partial class FormBaseData : Form
    {
        public FormBaseData()
        {
            InitializeComponent();
        }

        static string openFilePath;
        DataService ds = new DataService();
        static string[,] DataBase;


        private void buttonOpenFile_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_BAA.ShowDialog();
                openFilePath = openFileDialog_BAA.FileName;
                DataBase = ds.LoadFromFileData(openFilePath);
                int rows = DataBase.GetUpperBound(0) + 1;
                int columns = DataBase.Length / rows;

                dataGridViewData_BAA.ColumnCount = columns;
                dataGridViewData_BAA.RowCount = rows;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    { 
                        if(int.TryParse(DataBase[r,c], out int n))
                        {
                            dataGridViewData_BAA.Rows[r].Cells[c].Value = n;
                        }
                        else
                        {
                            dataGridViewData_BAA.Rows[r].Cells[c].Value = DataBase[r, c];
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


        private void buttonSaveFile_BAA_Click(object sender, EventArgs e)
        {
            saveFileDialog_BAA.FileName = "Водители.csv";
            saveFileDialog_BAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_BAA.ShowDialog();

            string path = saveFileDialog_BAA.FileName;

            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_BAA.RowCount;
            int columns = dataGridViewData_BAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewData_BAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewData_BAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void dataGridViewData_BAA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataBase[e.RowIndex, 0] = Convert.ToString(dataGridViewData_BAA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
            }
            catch
            {

            }
        }

        private void buttonAddRows_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewData_BAA.Rows.Add(1);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDeleteRow_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewData_BAA.Rows.RemoveAt(dataGridViewData_BAA.Rows.Count - 1);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewData_BAA.RowCount; i++)
                {
                    dataGridViewData_BAA.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewData_BAA.ColumnCount; j++)
                        if (dataGridViewData_BAA.Rows[i].Cells[j].Value != null)
                            if (dataGridViewData_BAA.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_BAA.Text))
                            {
                                dataGridViewData_BAA.Rows[i].Selected = true;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Строка не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvAppSummary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
