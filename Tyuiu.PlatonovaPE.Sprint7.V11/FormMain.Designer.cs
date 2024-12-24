
namespace Project.V11
{
    partial class FormMain_PPE
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_PPE));
            this.panelInfo_PPE = new System.Windows.Forms.Panel();
            this.chartInfo_PPE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonEditEmploye_PPE = new System.Windows.Forms.Button();
            this.buttonChooseFile_PPE = new System.Windows.Forms.Button();
            this.dataGridViewOutput_PPE = new System.Windows.Forms.DataGridView();
            this.contextMenuStripGridDo_PPE = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuRemoveEmploye_PPE = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuEditEmploye_PPE = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAddEmploye_PPE = new System.Windows.Forms.GroupBox();
            this.buttonAddEmploye_PPE = new System.Windows.Forms.Button();
            this.textBoxInsideNumberInput_PPE = new System.Windows.Forms.TextBox();
            this.textBoxInsideNumber_PPE = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateEnter_PPE = new System.Windows.Forms.DateTimePicker();
            this.textBoxDateEnter_PPE = new System.Windows.Forms.TextBox();
            this.textBoxSurnameInput_PPE = new System.Windows.Forms.TextBox();
            this.textBoxSurname_PPE = new System.Windows.Forms.TextBox();
            this.textBoxNameInput_PPE = new System.Windows.Forms.TextBox();
            this.textBoxName_PPE = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_PPE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_PPE = new System.Windows.Forms.ToolTip(this.components);
            this.buttonChartEdit_PPE = new System.Windows.Forms.Button();
            this.panelInfo_PPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_PPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PPE)).BeginInit();
            this.contextMenuStripGridDo_PPE.SuspendLayout();
            this.groupBoxAddEmploye_PPE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo_PPE
            // 
            this.panelInfo_PPE.Controls.Add(this.buttonChartEdit_PPE);
            this.panelInfo_PPE.Controls.Add(this.chartInfo_PPE);
            this.panelInfo_PPE.Controls.Add(this.buttonEditEmploye_PPE);
            this.panelInfo_PPE.Controls.Add(this.buttonChooseFile_PPE);
            this.panelInfo_PPE.Controls.Add(this.dataGridViewOutput_PPE);
            this.panelInfo_PPE.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_PPE.Name = "panelInfo_PPE";
            this.panelInfo_PPE.Size = new System.Drawing.Size(1024, 470);
            this.panelInfo_PPE.TabIndex = 1;
            // 
            // chartInfo_PPE
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo_PPE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInfo_PPE.Legends.Add(legend1);
            this.chartInfo_PPE.Location = new System.Drawing.Point(678, 103);
            this.chartInfo_PPE.Name = "chartInfo_PPE";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Сотрудники";
            this.chartInfo_PPE.Series.Add(series1);
            this.chartInfo_PPE.Size = new System.Drawing.Size(343, 364);
            this.chartInfo_PPE.TabIndex = 5;
            this.toolTip_PPE.SetToolTip(this.chartInfo_PPE, "График востребованности рабочих в разные сезоны");
            // 
            // buttonEditEmploye_PPE
            // 
            this.buttonEditEmploye_PPE.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditEmploye_PPE.Image")));
            this.buttonEditEmploye_PPE.Location = new System.Drawing.Point(791, 13);
            this.buttonEditEmploye_PPE.Name = "buttonEditEmploye_PPE";
            this.buttonEditEmploye_PPE.Size = new System.Drawing.Size(108, 83);
            this.buttonEditEmploye_PPE.TabIndex = 4;
            this.toolTip_PPE.SetToolTip(this.buttonEditEmploye_PPE, "Редактировать данные сотрудника");
            this.buttonEditEmploye_PPE.UseVisualStyleBackColor = true;
            this.buttonEditEmploye_PPE.Click += new System.EventHandler(this.buttonEditEmploye_PPE_Click);
            // 
            // buttonChooseFile_PPE
            // 
            this.buttonChooseFile_PPE.Image = ((System.Drawing.Image)(resources.GetObject("buttonChooseFile_PPE.Image")));
            this.buttonChooseFile_PPE.Location = new System.Drawing.Point(677, 13);
            this.buttonChooseFile_PPE.Name = "buttonChooseFile_PPE";
            this.buttonChooseFile_PPE.Size = new System.Drawing.Size(108, 83);
            this.buttonChooseFile_PPE.TabIndex = 3;
            this.toolTip_PPE.SetToolTip(this.buttonChooseFile_PPE, "Выберите файл сотрудника с его внутренним номером");
            this.buttonChooseFile_PPE.UseVisualStyleBackColor = true;
            this.buttonChooseFile_PPE.Click += new System.EventHandler(this.buttonChooseFile_PPE_Click);
            // 
            // dataGridViewOutput_PPE
            // 
            this.dataGridViewOutput_PPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_PPE.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewOutput_PPE.Name = "dataGridViewOutput_PPE";
            this.dataGridViewOutput_PPE.RowHeadersWidth = 51;
            this.dataGridViewOutput_PPE.RowTemplate.Height = 24;
            this.dataGridViewOutput_PPE.Size = new System.Drawing.Size(659, 393);
            this.dataGridViewOutput_PPE.TabIndex = 0;
            // 
            // contextMenuStripGridDo_PPE
            // 
            this.contextMenuStripGridDo_PPE.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripGridDo_PPE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuRemoveEmploye_PPE,
            this.ContextMenuEditEmploye_PPE});
            this.contextMenuStripGridDo_PPE.Name = "contextMenuStripGridDo_PPE";
            this.contextMenuStripGridDo_PPE.Size = new System.Drawing.Size(355, 52);
            // 
            // ContextMenuRemoveEmploye_PPE
            // 
            this.ContextMenuRemoveEmploye_PPE.Name = "ContextMenuRemoveEmploye_PPE";
            this.ContextMenuRemoveEmploye_PPE.Size = new System.Drawing.Size(354, 24);
            this.ContextMenuRemoveEmploye_PPE.Text = "&Удалить выбранного сотрудника";
            // 
            // ContextMenuEditEmploye_PPE
            // 
            this.ContextMenuEditEmploye_PPE.Name = "ContextMenuEditEmploye_PPE";
            this.ContextMenuEditEmploye_PPE.Size = new System.Drawing.Size(354, 24);
            this.ContextMenuEditEmploye_PPE.Text = "&Редактировать выбранного сотрудника";
            // 
            // groupBoxAddEmploye_PPE
            // 
            this.groupBoxAddEmploye_PPE.Controls.Add(this.buttonAddEmploye_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.textBoxInsideNumberInput_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.textBoxInsideNumber_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.dateTimePickerDateEnter_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.textBoxDateEnter_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.textBoxSurnameInput_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.textBoxSurname_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.textBoxNameInput_PPE);
            this.groupBoxAddEmploye_PPE.Controls.Add(this.textBoxName_PPE);
            this.groupBoxAddEmploye_PPE.Location = new System.Drawing.Point(13, 477);
            this.groupBoxAddEmploye_PPE.Name = "groupBoxAddEmploye_PPE";
            this.groupBoxAddEmploye_PPE.Size = new System.Drawing.Size(1000, 143);
            this.groupBoxAddEmploye_PPE.TabIndex = 3;
            this.groupBoxAddEmploye_PPE.TabStop = false;
            this.groupBoxAddEmploye_PPE.Text = "Добавить нового сотрудника:";
            // 
            // buttonAddEmploye_PPE
            // 
            this.buttonAddEmploye_PPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEmploye_PPE.Location = new System.Drawing.Point(790, 94);
            this.buttonAddEmploye_PPE.Name = "buttonAddEmploye_PPE";
            this.buttonAddEmploye_PPE.Size = new System.Drawing.Size(204, 43);
            this.buttonAddEmploye_PPE.TabIndex = 8;
            this.buttonAddEmploye_PPE.Text = "Добавить сотрудника";
            this.buttonAddEmploye_PPE.UseVisualStyleBackColor = true;
            this.buttonAddEmploye_PPE.Click += new System.EventHandler(this.buttonAddEmploye_PPE_Click);
            // 
            // textBoxInsideNumberInput_PPE
            // 
            this.textBoxInsideNumberInput_PPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsideNumberInput_PPE.Location = new System.Drawing.Point(132, 94);
            this.textBoxInsideNumberInput_PPE.Name = "textBoxInsideNumberInput_PPE";
            this.textBoxInsideNumberInput_PPE.Size = new System.Drawing.Size(155, 22);
            this.textBoxInsideNumberInput_PPE.TabIndex = 7;
            // 
            // textBoxInsideNumber_PPE
            // 
            this.textBoxInsideNumber_PPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInsideNumber_PPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInsideNumber_PPE.Location = new System.Drawing.Point(6, 94);
            this.textBoxInsideNumber_PPE.Name = "textBoxInsideNumber_PPE";
            this.textBoxInsideNumber_PPE.ReadOnly = true;
            this.textBoxInsideNumber_PPE.Size = new System.Drawing.Size(120, 19);
            this.textBoxInsideNumber_PPE.TabIndex = 6;
            this.textBoxInsideNumber_PPE.Text = "Внутр. номер:";
            // 
            // dateTimePickerDateEnter_PPE
            // 
            this.dateTimePickerDateEnter_PPE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateEnter_PPE.Location = new System.Drawing.Point(748, 44);
            this.dateTimePickerDateEnter_PPE.Name = "dateTimePickerDateEnter_PPE";
            this.dateTimePickerDateEnter_PPE.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateEnter_PPE.TabIndex = 5;
            // 
            // textBoxDateEnter_PPE
            // 
            this.textBoxDateEnter_PPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDateEnter_PPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateEnter_PPE.Location = new System.Drawing.Point(539, 45);
            this.textBoxDateEnter_PPE.Name = "textBoxDateEnter_PPE";
            this.textBoxDateEnter_PPE.ReadOnly = true;
            this.textBoxDateEnter_PPE.Size = new System.Drawing.Size(202, 19);
            this.textBoxDateEnter_PPE.TabIndex = 4;
            this.textBoxDateEnter_PPE.Text = "Дата трудоустройства:";
            // 
            // textBoxSurnameInput_PPE
            // 
            this.textBoxSurnameInput_PPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSurnameInput_PPE.Location = new System.Drawing.Point(321, 45);
            this.textBoxSurnameInput_PPE.Name = "textBoxSurnameInput_PPE";
            this.textBoxSurnameInput_PPE.Size = new System.Drawing.Size(202, 22);
            this.textBoxSurnameInput_PPE.TabIndex = 3;
            // 
            // textBoxSurname_PPE
            // 
            this.textBoxSurname_PPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname_PPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname_PPE.Location = new System.Drawing.Point(229, 44);
            this.textBoxSurname_PPE.Name = "textBoxSurname_PPE";
            this.textBoxSurname_PPE.ReadOnly = true;
            this.textBoxSurname_PPE.Size = new System.Drawing.Size(86, 19);
            this.textBoxSurname_PPE.TabIndex = 2;
            this.textBoxSurname_PPE.Text = "Фамилия:";
            // 
            // textBoxNameInput_PPE
            // 
            this.textBoxNameInput_PPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameInput_PPE.Location = new System.Drawing.Point(56, 45);
            this.textBoxNameInput_PPE.Name = "textBoxNameInput_PPE";
            this.textBoxNameInput_PPE.Size = new System.Drawing.Size(155, 22);
            this.textBoxNameInput_PPE.TabIndex = 1;
            // 
            // textBoxName_PPE
            // 
            this.textBoxName_PPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName_PPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName_PPE.Location = new System.Drawing.Point(6, 45);
            this.textBoxName_PPE.Name = "textBoxName_PPE";
            this.textBoxName_PPE.ReadOnly = true;
            this.textBoxName_PPE.Size = new System.Drawing.Size(43, 19);
            this.textBoxName_PPE.TabIndex = 0;
            this.textBoxName_PPE.Text = "Имя:";
            // 
            // openFileDialogTask_PPE
            // 
            this.openFileDialogTask_PPE.FileName = "openFileDialogTask_PPE";
            // 
            // buttonChartEdit_PPE
            // 
            this.buttonChartEdit_PPE.Image = ((System.Drawing.Image)(resources.GetObject("buttonChartEdit_PPE.Image")));
            this.buttonChartEdit_PPE.Location = new System.Drawing.Point(905, 14);
            this.buttonChartEdit_PPE.Name = "buttonChartEdit_PPE";
            this.buttonChartEdit_PPE.Size = new System.Drawing.Size(108, 83);
            this.buttonChartEdit_PPE.TabIndex = 6;
            this.toolTip_PPE.SetToolTip(this.buttonChartEdit_PPE, "Редактировать данные графика");
            this.buttonChartEdit_PPE.UseVisualStyleBackColor = true;
            this.buttonChartEdit_PPE.Click += new System.EventHandler(this.buttonChartEdit_PPE_Click);
            // 
            // FormMain_PPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 632);
            this.Controls.Add(this.groupBoxAddEmploye_PPE);
            this.Controls.Add(this.panelInfo_PPE);
            this.Name = "FormMain_PPE";
            this.Text = "Спринт 7 | Проект | Вариант 11 | Меньшиков Е.А.";
            this.Load += new System.EventHandler(this.FormMain_PPE_Load);
            this.panelInfo_PPE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_PPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PPE)).EndInit();
            this.contextMenuStripGridDo_PPE.ResumeLayout(false);
            this.groupBoxAddEmploye_PPE.ResumeLayout(false);
            this.groupBoxAddEmploye_PPE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_PPE;
        private System.Windows.Forms.Button buttonEditEmploye_PPE;
        private System.Windows.Forms.Button buttonChooseFile_PPE;
        private System.Windows.Forms.DataGridView dataGridViewOutput_PPE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridDo_PPE;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuRemoveEmploye_PPE;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuEditEmploye_PPE;
        private System.Windows.Forms.GroupBox groupBoxAddEmploye_PPE;
        private System.Windows.Forms.TextBox textBoxSurnameInput_PPE;
        private System.Windows.Forms.TextBox textBoxSurname_PPE;
        private System.Windows.Forms.TextBox textBoxNameInput_PPE;
        private System.Windows.Forms.TextBox textBoxName_PPE;
        private System.Windows.Forms.TextBox textBoxInsideNumberInput_PPE;
        private System.Windows.Forms.TextBox textBoxInsideNumber_PPE;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEnter_PPE;
        private System.Windows.Forms.TextBox textBoxDateEnter_PPE;
        private System.Windows.Forms.Button buttonAddEmploye_PPE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_PPE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PPE;
        private System.Windows.Forms.ToolTip toolTip_PPE;
        private System.Windows.Forms.Button buttonChartEdit_PPE;
    }
}
