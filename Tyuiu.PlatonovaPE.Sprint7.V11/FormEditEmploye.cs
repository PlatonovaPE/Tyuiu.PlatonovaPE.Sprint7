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

namespace Project.V11
{
    public partial class FormEditEmploye_PPE : Form
    {
        string openFilePath;
        public FormEditEmploye_()
        {
            InitializeComponent();
        }

        private void buttonOk_PPE_Click(object sender, EventArgs e)
        {

            try
            {
                string[] dataString = new string[4] { textBoxSurnameInput_PPE.Text, textBoxNameInput_PPE.Text, dateTimePickerDateEnter_PPE.Text, textBoxInsideNumberInput_PPE.Text };
                if (textBoxSurnameInput_PPE.Text == null)
                {
                    MessageBox.Show("Введены не все данные. Проверьте корректность заполнения полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataString[0] = textBoxSurnameInput_PPE.Text;
                }

                if (textBoxNameInput_PPE.Text == null)
                {
                    MessageBox.Show("Введены не все данные. Проверьте корректность заполнения полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataString[1] = textBoxNameInput_PPE.Text;
                }

                dataString[2] = dateTimePickerDateEnter_PPE.Text;

                if (textBoxInsideNumberInput_PPE.Text == null)
                {
                    MessageBox.Show("Введены не все данные. Проверьте корректность заполнения полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataString[3] = textBoxInsideNumberInput_PPE.Text;
                }

                if (textBoxInsideNumberInput_PPE.Text != null && textBoxNameInput_PPE.Text != null && textBoxSurnameInput_PPE.Text != null)
                {
                    System.IO.File.WriteAllText($@"{Directory.GetCurrentDirectory()}\" + dataString[3] + ".txt", dataString[0] + " " + dataString[1] + " " + dataString[2] + " " + dataString[3]);
                    MessageBox.Show("Редактирование прошло успешно. Для выхода нажмите Cancel или сверните окно для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании данных. Повторите попытку позже или поплачьтесь разработчикам.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_PPE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditEmploye_PPE_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите сотрудника и измените данные которые требуется изменить. Если данные в каком-то поле не требуют изменения, введите информацию без изменения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            openFileDialogTask_PPE.ShowDialog();
            openFilePath = openFileDialogTask_PPE.FileName;
            string[] dataString = File.ReadAllText(openFilePath).Split(' ');
            textBoxSurnameInput_PPE.Text = dataString[0];
            textBoxNameInput_PPE.Text = dataString[1];
            dateTimePickerDateEnter_PPE.Text = dataString[2];
            textBoxInsideNumberInput_PPE.Text = dataString[3];
        }
    }
}