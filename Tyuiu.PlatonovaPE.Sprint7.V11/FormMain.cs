using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PlatonovaPE.Sprint7.V11.Lib;

namespace Tyuiu.PlatonovaPE.Sprint7.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string pathLoadTable;
        string pathTable = Path.Combine(Path.GetTempPath(), "Table.csv");
        string[,] matrixTable;
        string[,] matrixOldTable;
        bool flagChangeValueTable = false;
        int indexStaticColumnInComboBox;
        int indexFilterColumnInComboBox;
        int RowNumber = 0;

        public void UpdateMatrix()
        {
            flagChangeValueTable = false;
            dataGridViewTable_PPE.Rows.Clear();
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                dataGridViewTable_PPE.Rows.Add();
                for (int j = 0; j < matrixTable.GetLength(1); j++)
                    dataGridViewTable_PPE.Rows[i].Cells[j].Value = matrixTable[i, j];
            }
            flagChangeValueTable = true;
        }

        public FormMain()
        {
            InitializeComponent();
            if (!File.Exists(pathTable))
                File.WriteAllText(pathTable, ";;;;;;;;;;0");
            matrixTable = ds.CreateMatrixFromFileCSV(pathTable);
            UpdateMatrix();
            RowNumber = matrixTable.GetLength(0);
        }

        private void buttonSaveFileInTable_PPE_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathTable))
                File.Delete(pathTable);
            ds.SaveFileToPath(pathTable, matrixTable);
        }

        private void buttonSaveAnotherFile_PPE_Click(object sender, EventArgs e)
        {
            saveFileDialog_PPE.FileName = "FileTable.csv";
            saveFileDialog_PPE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_PPE.ShowDialog();
            string NewPath = saveFileDialog_PPE.FileName;
            ds.SaveFileToPath(NewPath, matrixTable);
        }

        private void buttonLoadTable_PPE_Click(object sender, EventArgs e)
        {
            openFileDialog_PPE.ShowDialog();
            pathLoadTable = openFileDialog_PPE.FileName;
            if (Path.Exists(pathLoadTable))
            {
                matrixOldTable = matrixTable;
                matrixTable = ds.CreateMatrixFromFileCSV(pathLoadTable);
                UpdateMatrix();
                buttonLoadTableClose_PPE.Visible = true;
                buttonLoadTableSave_PPE.Visible = true;
            }
            buttonSaveTableInFile_PPE.Visible = false;
        }

        private void buttonLoadTableClose_PPE_Click(object sender, EventArgs e)
        {
            matrixTable = matrixOldTable;
            UpdateMatrix();
            buttonLoadTableClose_PPE.Visible = false;
            buttonLoadTableSave_PPE.Visible = false;
            buttonSaveTableInFile_PPE.Visible = true;
        }

        private void buttonLoadTableSave_PPE_Click(object sender, EventArgs e)
        {
            matrixOldTable = ds.RowsAddedInTable(matrixOldTable, matrixTable.GetLength(0) + matrixOldTable.GetLength(0));
            for (int i = 0; i < matrixTable.GetLength(0); i++)
                for (int j = 0; j < matrixTable.GetLength(1); j++)
                    matrixOldTable[i + matrixOldTable.GetLength(0) - matrixTable.GetLength(0), j] = matrixTable[i, j];
            matrixTable = matrixOldTable;
            UpdateMatrix();
            buttonLoadTableClose_PPE.Visible = false;
            buttonLoadTableSave_PPE.Visible = false;
            buttonSaveTableInFile_PPE.Visible = true;
        }

        private void dataGridViewTable_PPE_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && flagChangeValueTable)
            {
                int LineOffset = Convert.ToInt32(dataGridViewTable_PPE.Rows[e.RowIndex].Cells[10].Value);
                if (dataGridViewTable_PPE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    matrixTable[LineOffset, e.ColumnIndex] = dataGridViewTable_PPE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                else
                    matrixTable[LineOffset, e.ColumnIndex] = "";
            }
        }

        private void dataGridViewTable_PPE_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            matrixTable = new string[matrixTable.GetLength(0) - 1, matrixTable.GetLength(1)];
            for (int i = 0; i < matrixTable.GetLength(0); i++)
                for (int j = 0; j < matrixTable.GetLength(1); j++)
                    matrixTable[i, j] = dataGridViewTable_PPE.Rows[i].Cells[j].Value.ToString();
        }

        private void dataGridViewTable_PPE_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (flagChangeValueTable)
            {
                matrixTable = ds.RowsAddedInTable(matrixTable, dataGridViewTable_PPE.RowCount - 1);
                matrixTable[matrixTable.GetLength(0) - 1, 10] = RowNumber.ToString();
                dataGridViewTable_PPE.Rows[matrixTable.GetLength(0) - 1].Cells[10].Value = RowNumber++;
            }
        }

        private void buttonSearch_PPE_Click(object sender, EventArgs e)
        {
            if (textBoxSearch_PPE.Text == "")
            {
                UpdateMatrix();
            }
            else
            {
                string LineIndex = "";
                for (int i = 0; i < matrixTable.GetLength(0); i++)
                    for (int j = 0; j < matrixTable.GetLength(1); j++)
                        if (matrixTable[i, j].ToString().Contains(textBoxSearch_PPE.Text))
                            LineIndex += i.ToString() + ";";
                if (LineIndex == "")
                {
                    flagChangeValueTable = false;
                    dataGridViewTable_PPE.Rows.Clear();
                    flagChangeValueTable = true;
                }
                else
                {
                    int RowsNumber = 0;
                    flagChangeValueTable = false;
                    dataGridViewTable_PPE.Rows.Clear();

                    foreach (string i in LineIndex.Trim(';').Split(';'))
                    {
                        dataGridViewTable_PPE.Rows.Add();
                        for (int j = 0; j < matrixTable.GetLength(1); j++)
                            dataGridViewTable_PPE.Rows[RowsNumber].Cells[j].Value = matrixTable[Convert.ToInt32(i), j];
                        RowsNumber++;
                    }
                    flagChangeValueTable = true;
                }
            }
        }

        private void comboBoxIndexFilterColumn_PPE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxIndexFilterColumn_PPE_TextChanged(object sender, EventArgs e)
        {
            string AllTypes = "";
            groupBoxFilter_PPE.Visible = true;
            indexFilterColumnInComboBox = comboBoxIndexFilterColumn_PPE.SelectedIndex;
            checkedListBoxFilter_PPE.Items.Clear();
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                if (!AllTypes.Trim(';').Split(";").Any(str => str == matrixTable[i, indexFilterColumnInComboBox]))
                    AllTypes += matrixTable[i, indexFilterColumnInComboBox] + ";";
            }
            foreach (string name in AllTypes.Trim(';').Split(";", StringSplitOptions.RemoveEmptyEntries))
                checkedListBoxFilter_PPE.Items.Add(name, true);
        }

        private void buttonResetFilter_PPE_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxFilter_PPE.Items.Count; i++)
            {
                checkedListBoxFilter_PPE.SetItemChecked(i, true);
            }
        }

        private void buttonUseFilter_PPE_Click(object sender, EventArgs e)
        {
            comboBoxIndexStaticColumn_PPE.Text = comboBoxIndexStaticColumn_PPE.Text;
            string CheckItems = "";
            string LineIndex = "";
            foreach (var item in checkedListBoxFilter_PPE.CheckedItems)
                CheckItems += item.ToString() + ";";
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                if (CheckItems.Trim(';').Split(";").Any(str => str == matrixTable[i, indexFilterColumnInComboBox]))
                {
                    LineIndex += i.ToString() + ";";
                }
            }
            flagChangeValueTable = false;
            dataGridViewTable_PPE.Rows.Clear();
            int RowNumber = 0;
            foreach (string i in LineIndex.Trim(';').Split(';'))
            {
                dataGridViewTable_PPE.Rows.Add();
                for (int j = 0; j < matrixTable.GetLength(1); j++)
                    dataGridViewTable_PPE.Rows[RowNumber].Cells[j].Value = matrixTable[Convert.ToInt32(i), j];
                RowNumber++;
            }
            flagChangeValueTable = true;
            chartGraphic_PPE.Titles.Clear();
            chartGraphic_PPE.Series[0].Points.Clear();
            dataGridViewFunction_PPE.Rows.Clear();
            string SummColumn = "";
            for (int i = 0; i < dataGridViewTable_PPE.RowCount - 1; i++)
                SummColumn += dataGridViewTable_PPE.Rows[i].Cells[indexStaticColumnInComboBox].Value.ToString() + ';';
            string[] MassivColumnStr = SummColumn.Trim(';').Split(";", StringSplitOptions.RemoveEmptyEntries);
            dataGridViewFunction_PPE.Rows[0].Cells[0].Value = "Количество";
            dataGridViewFunction_PPE.Rows[0].Cells[1].Value = MassivColumnStr.Count();
            if (MassivColumnStr.All(s => double.TryParse(s, out var pass)))
            {
                double[] MassivColumnDouble = new double[MassivColumnStr.Length];
                for (int i = 0; i < MassivColumnStr.Length; i++)
                    MassivColumnDouble[i] = double.Parse(MassivColumnStr[i]);
                dataGridViewFunction_PPE.Rows.Add("Сумма", MassivColumnDouble.Sum());
                dataGridViewFunction_PPE.Rows.Add("Среднее", double.Round(MassivColumnDouble.Sum() / MassivColumnDouble.Count(), 3));
                dataGridViewFunction_PPE.Rows.Add("Максимум", MassivColumnDouble.Max());
                dataGridViewFunction_PPE.Rows.Add("Минимум", MassivColumnDouble.Min());
                dataGridViewFunction_PPE.Visible = true;
                chartGraphic_PPE.Titles.Add("График выбранного столбца");
                chartGraphic_PPE.ChartAreas[0].AxisX.Title = "Индекс строки";
                chartGraphic_PPE.ChartAreas[0].AxisY.Title = "Значение";
                string[] LineIndexMassiv = LineIndex.Trim(';').Split(';');
                for (int i = 0; i < LineIndexMassiv.GetLength(0); i++)
                {
                    if (matrixTable[Convert.ToInt32(LineIndexMassiv[i]), indexStaticColumnInComboBox] != null && matrixTable[Convert.ToInt32(LineIndexMassiv[i]), indexStaticColumnInComboBox] != "")
                        chartGraphic_PPE.Series[0].Points.AddXY(i + 1, matrixTable[Convert.ToInt32(LineIndexMassiv[i]), indexStaticColumnInComboBox]);
                }
                chartGraphic_PPE.Visible = true;
            }
        }

        private void comboBoxIndexStaticColumn_PPE_TextChanged(object sender, EventArgs e)
        {
            chartGraphic_PPE.Visible = false;
            chartGraphic_PPE.Titles.Clear();
            chartGraphic_PPE.Series[0].Points.Clear();
            dataGridViewFunction_PPE.Rows.Clear();
            string SummColumn = "";
            indexStaticColumnInComboBox = comboBoxIndexStaticColumn_PPE.SelectedIndex;
            for (int i = 0; i < dataGridViewTable_PPE.RowCount - 1; i++)
                SummColumn += dataGridViewTable_PPE.Rows[i].Cells[indexStaticColumnInComboBox].Value.ToString() + ';';
            string[] MassivColumnStr = SummColumn.Trim(';').Split(";", StringSplitOptions.RemoveEmptyEntries);
            dataGridViewFunction_PPE.Visible = true;
            dataGridViewFunction_PPE.Rows[0].Cells[0].Value = "Количество";
            dataGridViewFunction_PPE.Rows[0].Cells[1].Value = MassivColumnStr.Count();
            if (MassivColumnStr.All(s => double.TryParse(s, out var pass)))
            {
                double[] MassivColumnDouble = new double[MassivColumnStr.Length];
                for (int i = 0; i < MassivColumnStr.Length; i++)
                    MassivColumnDouble[i] = double.Parse(MassivColumnStr[i]);
                dataGridViewFunction_PPE.Rows.Add("Сумма", MassivColumnDouble.Sum());
                dataGridViewFunction_PPE.Rows.Add("Среднее", double.Round(MassivColumnDouble.Sum() / MassivColumnDouble.Count(), 3));
                dataGridViewFunction_PPE.Rows.Add("Максимум", MassivColumnDouble.Max());
                dataGridViewFunction_PPE.Rows.Add("Минимум", MassivColumnDouble.Min());
                dataGridViewFunction_PPE.Visible = true;
                chartGraphic_PPE.Titles.Add("График выбранного столбца");
                chartGraphic_PPE.ChartAreas[0].AxisX.Title = "Индекс строки";
                chartGraphic_PPE.ChartAreas[0].AxisY.Title = "Значение";
                for (int i = 0; i < matrixTable.GetLength(0); i++)
                {
                    if (matrixTable[i, indexStaticColumnInComboBox] != null && matrixTable[i, indexStaticColumnInComboBox] != "")
                        chartGraphic_PPE.Series[0].Points.AddXY(i + 1, matrixTable[i, indexStaticColumnInComboBox]);
                }
                chartGraphic_PPE.Visible = true;
            }
        }

        private void buttonResetTable_PPE_Click(object sender, EventArgs e)
        {
            comboBoxIndexStaticColumn_PPE.Text = "";
            comboBoxIndexFilterColumn_PPE.Text = "";
            groupBoxFilter_PPE.Visible = false;
            chartGraphic_PPE.Visible = false;
            dataGridViewFunction_PPE.Visible = false;
            checkedListBoxFilter_PPE.Items.Clear();
            UpdateMatrix();
        }

        private void buttonMenu_PPE_Click(object sender, EventArgs e)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            Location = new Point(resolution.Width / 2 - 150, resolution.Height / 2 - 200);
            ClientSize = new Size(284, 361);
            MinimumSize = new Size(300, 400);
            MaximizeBox = false;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            panelMenu_PPE.Visible = false;
            panelStatistics_PPE.Visible = false;
            panelTable_PPE.Visible = false;
            textBoxInform_PPE.Visible = true;
            buttonAboutProgram_PPE.Visible = true;
            buttonManual_PPE.Visible = true;
            buttonMain_PPE.Visible = true;
        }

        private void buttonManual_PPE_Click(object sender, EventArgs e)
        {
            FormManual fm = new FormManual();
            fm.ShowDialog();
        }

        private void buttonMain_PPE_Click(object sender, EventArgs e)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            Location = new Point(resolution.Width / 2 - 585, resolution.Height / 2 - 361);
            Location = new Point(300, 150);
            ClientSize = new Size(1154, 683);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimumSize = new Size(1170, 722);
            panelMenu_PPE.Visible = true;
            panelStatistics_PPE.Visible = true;
            panelTable_PPE.Visible = true;
            textBoxInform_PPE.Visible = false;
            buttonAboutProgram_PPE.Visible = false;
            buttonManual_PPE.Visible = false;
            buttonMain_PPE.Visible = false;
        }

        private void buttonAboutProgram_PPE_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
    }
}
