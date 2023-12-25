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
        private void buttonOpenFile_BAA_Click(object sender, EventArgs e) //Кнопка открытия файла
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
                        if(double.TryParse(DataBase[r,c], out double n))
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


        private void buttonSaveFile_BAA_Click(object sender, EventArgs e)//кнопка сохранения, также ничего особенного
        {
            try
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
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewData_BAA_CellValueChanged(object sender, DataGridViewCellEventArgs e)//Событие, благодаря которому изменяя значения в DataGridView изменяются значения в массиве
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

        private void buttonAddRows_BAA_Click(object sender, EventArgs e)//Кнопка, добавляющая строку в DataGridView
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

        private void buttonDeleteRow_BAA_Click(object sender, EventArgs e)//Кнопка, удаляющая последнюю строку в DataGridView
        {
            try
            {
                dataGridViewData_BAA.Rows.RemoveAt(dataGridViewData_BAA.Rows.Count - 1);
            }
            catch
            {
                MessageBox.Show("Таблица пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_BAA_Click(object sender, EventArgs e)//поиск
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

        private void dataGridViewData_BAA_SortCompare(object sender, DataGridViewSortCompareEventArgs e)//Ключевое событие для корректной сортировки
        {
            try
            {
                double a = double.Parse(e.CellValue1.ToString()), b = double.Parse(e.CellValue2.ToString());

                e.SortResult = a.CompareTo(b);

                e.Handled = true;
            }
            catch
            {

            }

        }

        private void buttonGuide_BAA_Click(object sender, EventArgs e)//открывает Краткое руководство пользователя
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonStatistic_BAA_Click(object sender, EventArgs e)//Реализует статистику
        {
            try
            {
                int rows = dataGridViewData_BAA.RowCount;
                int columns = dataGridViewData_BAA.ColumnCount;

                string[,] DataBaseStat = new string[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataBaseStat[i, j] = Convert.ToString(dataGridViewData_BAA.Rows[i].Cells[j].Value);
                    }
                }
                textBoxCount_BAA.Text = Convert.ToString(ds.amountOfData(DataBaseStat));

                bool Age = false;
                bool Pay = true;
                textBoxAverageAge_BAA.Text = Convert.ToString(ds.AverageNumberPaymentOrAgeOfWork(DataBaseStat, Age, rows));


                textBoxAveragePay_BAA.Text = Convert.ToString(ds.AverageNumberPaymentOrAgeOfWork(DataBaseStat, Pay, rows));

                labelMinMaxA_BAA.Text = "Минимальный стаж";
                labelMinMaxP_BAA.Text = "Минимальный оклад";
                radioButtonMinMaxA_BAA.Checked = false;
                radioButtonMinMaxP_BAA.Checked = false;
                textBoxMinMaxA_BAA.Text = Convert.ToString(ds.MinPaymentOrAge(DataBaseStat, Age, rows));
                textBoxMinMaxP_BAA.Text = Convert.ToString(ds.MinPaymentOrAge(DataBaseStat, Pay, rows));

                textBoxSumPay_BAA.Text = Convert.ToString(ds.SumOfPayment(DataBaseStat, rows));
            }
            catch
            {
                MessageBox.Show("Таблица пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonMinMaxA_BAA_CheckedChanged(object sender, EventArgs e)//Кнопка для стажа
        {
            try
            {
                int rows = dataGridViewData_BAA.RowCount;
                int columns = dataGridViewData_BAA.ColumnCount;

                string[,] DataBaseStat = new string[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataBaseStat[i, j] = Convert.ToString(dataGridViewData_BAA.Rows[i].Cells[j].Value);
                    }
                }
                bool Age = false;

                if (radioButtonMinMaxA_BAA.Checked)
                {
                    textBoxMinMaxA_BAA.Text = Convert.ToString(ds.MaxPaymentOrAge(DataBaseStat, Age, rows));
                    labelMinMaxA_BAA.Text = "Максимальный стаж";
                }
                else
                {
                    textBoxMinMaxA_BAA.Text = Convert.ToString(ds.MinPaymentOrAge(DataBaseStat, Age, rows));
                    labelMinMaxA_BAA.Text = "Минимальный стаж";
                }

            }
            catch
            {
                MessageBox.Show("Таблица пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonMinMaxP_BAA_CheckedChanged(object sender, EventArgs e)//кнопка для оклада
        {
            try
            {
                int rows = dataGridViewData_BAA.RowCount;
                int columns = dataGridViewData_BAA.ColumnCount;

                string[,] DataBaseStat = new string[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataBaseStat[i, j] = Convert.ToString(dataGridViewData_BAA.Rows[i].Cells[j].Value);
                    }
                }
                bool Pay = true;
                if (radioButtonMinMaxP_BAA.Checked)
                {
                    textBoxMinMaxP_BAA.Text = Convert.ToString(ds.MaxPaymentOrAge(DataBaseStat, Pay, rows));
                    labelMinMaxP_BAA.Text = "Максимальный оклад";
                }
                else
                {
                    textBoxMinMaxP_BAA.Text = Convert.ToString(ds.MinPaymentOrAge(DataBaseStat, Pay, rows));
                    labelMinMaxP_BAA.Text = "Минимальный оклад";
                }

            }
            catch
            {
                MessageBox.Show("Таблица пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonMinMaxA_BAA_Click(object sender, EventArgs e)//Событие, благодоря которому радио кнопки нажимаются отдельно, включаются и выключаются
        {
                switch (radioButtonMinMaxA_BAA.Checked)
                {
                    case true:
                        radioButtonMinMaxA_BAA.Checked = false;
                        break;
                    case false:
                        radioButtonMinMaxA_BAA.Checked = true;
                        break;
                }
        }

        private void radioButtonMinMaxP_BAA_Click(object sender, EventArgs e)//Событие, благодоря которому радио кнопки нажимаются отдельно, включаются и выключаются
        {
                switch (radioButtonMinMaxP_BAA.Checked)
                {
                    case true:
                        radioButtonMinMaxP_BAA.Checked = false;
                        break;
                    case false:
                        radioButtonMinMaxP_BAA.Checked = true;
                        break;
                }
        }
        private void dataGridViewData_BAA_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)//Событие, которое активирует другое событие при редактировании определенных столбцов
        {
            e.Control.KeyPress -= new KeyPressEventHandler(AnyColumnKeyPress);
            if (dataGridViewData_BAA.CurrentCell.ColumnIndex == 0 || dataGridViewData_BAA.CurrentCell.ColumnIndex == 5 || dataGridViewData_BAA.CurrentCell.ColumnIndex == 6)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(AnyColumnKeyPress);
                }



            }
        }

        private void AnyColumnKeyPress(object sender, KeyPressEventArgs e)//Событие, которое дает печатать только число
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
