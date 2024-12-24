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
using Project.V11.Lib;
using Tyuiu.PlatonovaPE.Sprint7.V11.Lib;

namespace Project.V11
{
    public partial class FormChartEdit_PPE : Form
    {
        DataService ds = new DataService();
        string chartPath = $@"{Directory.GetCurrentDirectory()}\Сезонность сотрудников.txt";

        public FormChartEdit_PPE()
        {
            InitializeComponent();
        }

        private void FormChartEdit_PPE_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Введите в каждое поле требуемое количество сотрудников. Поля не должны оставаться пустыми. В случае ненадобности сотрудников, введите 0.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            double[] serviceArray = ds.LoadFromDataFile(chartPath);
            textBoxDecemberInput_PPE.Text = Convert.ToString(serviceArray[0]);
            textBoxJanuaryInput_PPE.Text = Convert.ToString(serviceArray[1]);
            textBoxFebruaryInput_PPE.Text = Convert.ToString(serviceArray[2]);
            textBoxMarchInput_PPE.Text = Convert.ToString(serviceArray[3]);
            textBoxAprilInput_PPE.Text = Convert.ToString(serviceArray[4]);
            textBoxMayInput_PPE.Text = Convert.ToString(serviceArray[5]);
            textBoxJuneInput_PPE.Text = Convert.ToString(serviceArray[6]);
            textBoxJulyInput_PPE.Text = Convert.ToString(serviceArray[7]);
            textBoxAugustInput_PPE.Text = Convert.ToString(serviceArray[8]);
            textBoxSeptemberInput_PPE.Text = Convert.ToString(serviceArray[9]);
            textBoxOctoberInput_PPE.Text = Convert.ToString(serviceArray[10]);
            textBoxNovemberInput_PPE.Text = Convert.ToString(serviceArray[11]);



        }

        private void buttonOk_PPE_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDecemberInput_PPE.Text == null || textBoxJanuaryInput_PPE.Text == null || textBoxFebruaryInput_PPE.Text == null || textBoxMarchInput_PPE.Text == null || textBoxAprilInput_PPE.Text == null || textBoxMayInput_PPE.Text == null || textBoxJuneInput_PPE.Text == null || textBoxJulyInput_PPE.Text == null || textBoxAugustInput_PPE.Text == null || textBoxSeptemberInput_PPE.Text == null || textBoxOctoberInput_PPE.Text == null || textBoxNovemberInput_PPE.Text == null)
                {
                    MessageBox.Show("Возникла ошибка. Возможно, не все поля оказались заполнены. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToDouble(textBoxDecemberInput_PPE.Text) < 0 || Convert.ToDouble(textBoxJanuaryInput_PPE.Text) < 0 || Convert.ToDouble(textBoxFebruaryInput_PPE.Text) < 0 || Convert.ToDouble(textBoxMarchInput_PPE.Text) < 0 || Convert.ToDouble(textBoxAprilInput_PPE.Text) < 0 || Convert.ToDouble(textBoxMayInput_PPE.Text) < 0 || Convert.ToDouble(textBoxJuneInput_PPE.Text) < 0 || Convert.ToDouble(textBoxJulyInput_PPE.Text) < 0 || Convert.ToDouble(textBoxAugustInput_PPE.Text) < 0 || Convert.ToDouble(textBoxSeptemberInput_PPE.Text) < 0 || Convert.ToDouble(textBoxOctoberInput_PPE.Text) < 0 || Convert.ToDouble(textBoxNovemberInput_PPE.Text) < 0)
                {
                    MessageBox.Show("Возникла ошибка. Возможно, не все поля оказались заполнены. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] res = new string[12] { textBoxDecemberInput_PPE.Text, textBoxJanuaryInput_PPE.Text, textBoxFebruaryInput_PPE.Text, textBoxMarchInput_PPE.Text, textBoxAprilInput_PPE.Text, textBoxMayInput_PPE.Text, textBoxJuneInput_PPE.Text, textBoxJulyInput_PPE.Text, textBoxAugustInput_PPE.Text, textBoxSeptemberInput_PPE.Text, textBoxOctoberInput_PPE.Text, textBoxNovemberInput_PPE.Text };
                    System.IO.File.WriteAllText(chartPath, textBoxDecemberInput_PPE.Text + "\n" + textBoxJanuaryInput_PPE.Text + "\n" + textBoxFebruaryInput_PPE.Text + "\n" + textBoxMarchInput_PPE.Text + "\n" + textBoxAprilInput_PPE.Text + "\n" + textBoxMayInput_PPE.Text + "\n" + textBoxJuneInput_PPE.Text + "\n" + textBoxJulyInput_PPE.Text + "\n" + textBoxAugustInput_PPE.Text + "\n" + textBoxSeptemberInput_PPE.Text + "\n" + textBoxOctoberInput_PPE.Text + "\n" + textBoxNovemberInput_PPE.Text);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Возможно, некоторые данные некорректны. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}