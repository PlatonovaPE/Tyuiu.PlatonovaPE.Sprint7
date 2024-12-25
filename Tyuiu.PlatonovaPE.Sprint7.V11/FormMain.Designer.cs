namespace Tyuiu.PlatonovaPE.Sprint7.V11
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelMenu_PPE = new Panel();
            groupBoxSearch_PPE = new GroupBox();
            textBoxSearch_PPE = new TextBox();
            buttonSearch_PPE = new Button();
            buttonMenu_PPE = new Button();
            buttonResetTable_PPE = new Button();
            buttonSaveAnotherFile_PPE = new Button();
            buttonLoadTableClose_PPE = new Button();
            buttonLoadTableSave_PPE = new Button();
            buttonLoadTable_PPE = new Button();
            buttonSaveTableInFile_PPE = new Button();
            panelTable_PPE = new Panel();
            dataGridViewTable_PPE = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Patronymic = new DataGridViewTextBoxColumn();
            HomeAddress = new DataGridViewTextBoxColumn();
            Telephone = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            DateOfEnrollment = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            Education = new DataGridViewTextBoxColumn();
            NumberRow = new DataGridViewTextBoxColumn();
            openFileDialog_PPE = new OpenFileDialog();
            panelStatistics_PPE = new Panel();
            groupBoxFilter_PPE = new GroupBox();
            checkedListBoxFilter_PPE = new CheckedListBox();
            buttonResetFilter_PPE = new Button();
            buttonUseFilter_PPE = new Button();
            chartGraphic_PPE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_PPE = new DataGridView();
            Function = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            comboBoxIndexStaticColumn_PPE = new ComboBox();
            comboBoxIndexFilterColumn_PPE = new ComboBox();
            saveFileDialog_PPE = new SaveFileDialog();
            toolTip_PPE = new ToolTip(components);
            buttonMain_PPE = new Button();
            buttonManual_PPE = new Button();
            buttonAboutProgram_PPE = new Button();
            textBoxInform_PPE = new TextBox();
            panelMenu_PPE.SuspendLayout();
            groupBoxSearch_PPE.SuspendLayout();
            panelTable_PPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_PPE).BeginInit();
            panelStatistics_PPE.SuspendLayout();
            groupBoxFilter_PPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphic_PPE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_PPE).BeginInit();
            SuspendLayout();
            // 
            // panelMenu_PPE
            // 
            panelMenu_PPE.Controls.Add(groupBoxSearch_PPE);
            panelMenu_PPE.Controls.Add(buttonMenu_PPE);
            panelMenu_PPE.Controls.Add(buttonResetTable_PPE);
            panelMenu_PPE.Controls.Add(buttonSaveAnotherFile_PPE);
            panelMenu_PPE.Controls.Add(buttonLoadTableClose_PPE);
            panelMenu_PPE.Controls.Add(buttonLoadTableSave_PPE);
            panelMenu_PPE.Controls.Add(buttonLoadTable_PPE);
            panelMenu_PPE.Controls.Add(buttonSaveTableInFile_PPE);
            panelMenu_PPE.Dock = DockStyle.Top;
            panelMenu_PPE.Location = new Point(0, 0);
            panelMenu_PPE.Name = "panelMenu_PPE";
            panelMenu_PPE.Size = new Size(1282, 119);
            panelMenu_PPE.TabIndex = 0;
            panelMenu_PPE.Visible = false;
            // 
            // groupBoxSearch_PPE
            // 
            groupBoxSearch_PPE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxSearch_PPE.Controls.Add(textBoxSearch_PPE);
            groupBoxSearch_PPE.Controls.Add(buttonSearch_PPE);
            groupBoxSearch_PPE.Font = new Font("Segoe UI", 10F);
            groupBoxSearch_PPE.Location = new Point(1123, 0);
            groupBoxSearch_PPE.Name = "groupBoxSearch_PPE";
            groupBoxSearch_PPE.Size = new Size(153, 53);
            groupBoxSearch_PPE.TabIndex = 11;
            groupBoxSearch_PPE.TabStop = false;
            groupBoxSearch_PPE.Text = "Поиск";
            // 
            // textBoxSearch_PPE
            // 
            textBoxSearch_PPE.Location = new Point(6, 22);
            textBoxSearch_PPE.Name = "textBoxSearch_PPE";
            textBoxSearch_PPE.Size = new Size(117, 30);
            textBoxSearch_PPE.TabIndex = 9;
            // 
            // buttonSearch_PPE
            // 
            buttonSearch_PPE.BackColor = SystemColors.Window;
            buttonSearch_PPE.FlatStyle = FlatStyle.Flat;
            buttonSearch_PPE.Location = new Point(122, 22);
            buttonSearch_PPE.Name = "buttonSearch_PPE";
            buttonSearch_PPE.Size = new Size(25, 25);
            buttonSearch_PPE.TabIndex = 10;
            toolTip_PPE.SetToolTip(buttonSearch_PPE, "Поиск по заданному слову");
            buttonSearch_PPE.UseVisualStyleBackColor = false;
            buttonSearch_PPE.Click += buttonSearch_PPE_Click;
            // 
            // buttonMenu_PPE
            // 
            buttonMenu_PPE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMenu_PPE.Font = new Font("Segoe UI", 10F);
            buttonMenu_PPE.Location = new Point(1211, 59);
            buttonMenu_PPE.Name = "buttonMenu_PPE";
            buttonMenu_PPE.Size = new Size(65, 29);
            buttonMenu_PPE.TabIndex = 8;
            buttonMenu_PPE.Text = "Меню";
            toolTip_PPE.SetToolTip(buttonMenu_PPE, "Выйти в меню");
            buttonMenu_PPE.UseVisualStyleBackColor = true;
            buttonMenu_PPE.Click += buttonMenu_PPE_Click;
            // 
            // buttonResetTable_PPE
            // 
            buttonResetTable_PPE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonResetTable_PPE.Font = new Font("Segoe UI", 10F);
            buttonResetTable_PPE.Location = new Point(1123, 59);
            buttonResetTable_PPE.Name = "buttonResetTable_PPE";
            buttonResetTable_PPE.Size = new Size(87, 29);
            buttonResetTable_PPE.TabIndex = 19;
            buttonResetTable_PPE.Text = "Сбросить";
            toolTip_PPE.SetToolTip(buttonResetTable_PPE, "Вернуть основную таблицу без изменений");
            buttonResetTable_PPE.UseVisualStyleBackColor = true;
            buttonResetTable_PPE.Click += buttonResetTable_PPE_Click;
            // 
            // buttonSaveAnotherFile_PPE
            // 
            buttonSaveAnotherFile_PPE.Font = new Font("Segoe UI", 10F);
            buttonSaveAnotherFile_PPE.Location = new Point(12, 82);
            buttonSaveAnotherFile_PPE.Name = "buttonSaveAnotherFile_PPE";
            buttonSaveAnotherFile_PPE.Size = new Size(113, 29);
            buttonSaveAnotherFile_PPE.TabIndex = 5;
            buttonSaveAnotherFile_PPE.Text = "Сохранить как";
            toolTip_PPE.SetToolTip(buttonSaveAnotherFile_PPE, "Сохранить основную таблицу в отдельный файл");
            buttonSaveAnotherFile_PPE.UseVisualStyleBackColor = true;
            buttonSaveAnotherFile_PPE.Click += buttonSaveAnotherFile_PPE_Click;
            // 
            // buttonLoadTableClose_PPE
            // 
            buttonLoadTableClose_PPE.Font = new Font("Segoe UI", 10F);
            buttonLoadTableClose_PPE.Location = new Point(113, 12);
            buttonLoadTableClose_PPE.Name = "buttonLoadTableClose_PPE";
            buttonLoadTableClose_PPE.Size = new Size(150, 29);
            buttonLoadTableClose_PPE.TabIndex = 2;
            buttonLoadTableClose_PPE.Text = "Закрыть таблицу";
            toolTip_PPE.SetToolTip(buttonLoadTableClose_PPE, "Закрыть загруженную таблицу");
            buttonLoadTableClose_PPE.UseVisualStyleBackColor = true;
            buttonLoadTableClose_PPE.Visible = false;
            buttonLoadTableClose_PPE.Click += buttonLoadTableClose_PPE_Click;
            // 
            // buttonLoadTableSave_PPE
            // 
            buttonLoadTableSave_PPE.Font = new Font("Segoe UI", 10F);
            buttonLoadTableSave_PPE.Location = new Point(269, 12);
            buttonLoadTableSave_PPE.Name = "buttonLoadTableSave_PPE";
            buttonLoadTableSave_PPE.Size = new Size(160, 29);
            buttonLoadTableSave_PPE.TabIndex = 2;
            buttonLoadTableSave_PPE.Text = "Сохранить таблицу";
            toolTip_PPE.SetToolTip(buttonLoadTableSave_PPE, "Переместить таблицу в низ основной таблицы");
            buttonLoadTableSave_PPE.UseVisualStyleBackColor = true;
            buttonLoadTableSave_PPE.Visible = false;
            buttonLoadTableSave_PPE.Click += buttonLoadTableSave_PPE_Click;
            // 
            // buttonLoadTable_PPE
            // 
            buttonLoadTable_PPE.Font = new Font("Segoe UI", 10F);
            buttonLoadTable_PPE.Location = new Point(12, 12);
            buttonLoadTable_PPE.Name = "buttonLoadTable_PPE";
            buttonLoadTable_PPE.Size = new Size(95, 29);
            buttonLoadTable_PPE.TabIndex = 1;
            buttonLoadTable_PPE.Text = "Загрузить таблицу";
            toolTip_PPE.SetToolTip(buttonLoadTable_PPE, "Загрузка CSV файла");
            buttonLoadTable_PPE.UseVisualStyleBackColor = true;
            buttonLoadTable_PPE.Click += buttonLoadTable_PPE_Click;
            // 
            // buttonSaveTableInFile_PPE
            // 
            buttonSaveTableInFile_PPE.FlatStyle = FlatStyle.System;
            buttonSaveTableInFile_PPE.Font = new Font("Segoe UI", 10F);
            buttonSaveTableInFile_PPE.Location = new Point(12, 47);
            buttonSaveTableInFile_PPE.Name = "buttonSaveTableInFile_PPE";
            buttonSaveTableInFile_PPE.Size = new Size(95, 29);
            buttonSaveTableInFile_PPE.TabIndex = 0;
            buttonSaveTableInFile_PPE.Text = "Сохранить";
            toolTip_PPE.SetToolTip(buttonSaveTableInFile_PPE, "Сохранить основную таблицу");
            buttonSaveTableInFile_PPE.UseVisualStyleBackColor = true;
            buttonSaveTableInFile_PPE.Click += buttonSaveFileInTable_PPE_Click;
            // 
            // panelTable_PPE
            // 
            panelTable_PPE.Controls.Add(dataGridViewTable_PPE);
            panelTable_PPE.Dock = DockStyle.Fill;
            panelTable_PPE.Location = new Point(0, 119);
            panelTable_PPE.Name = "panelTable_PPE";
            panelTable_PPE.Size = new Size(1282, 310);
            panelTable_PPE.TabIndex = 0;
            panelTable_PPE.Visible = false;
            // 
            // dataGridViewTable_PPE
            // 
            dataGridViewTable_PPE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTable_PPE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_PPE.Columns.AddRange(new DataGridViewColumn[] { LastName, FirstName, Patronymic, HomeAddress, Telephone, DateOfBirth, Position, DateOfEnrollment, Salary, Education, NumberRow });
            dataGridViewTable_PPE.Dock = DockStyle.Fill;
            dataGridViewTable_PPE.Location = new Point(0, 0);
            dataGridViewTable_PPE.Name = "dataGridViewTable_PPE";
            dataGridViewTable_PPE.RowHeadersWidth = 51;
            dataGridViewTable_PPE.Size = new Size(1282, 310);
            dataGridViewTable_PPE.TabIndex = 0;
            dataGridViewTable_PPE.CellValueChanged += dataGridViewTable_PPE_CellValueChanged;
            dataGridViewTable_PPE.RowsAdded += dataGridViewTable_PPE_RowsAdded;
            dataGridViewTable_PPE.UserDeletedRow += dataGridViewTable_PPE_UserDeletedRow;
            // 
            // LastName
            // 
            LastName.HeaderText = "Фамилия";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Имя";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // Patronymic
            // 
            Patronymic.HeaderText = "Отчество";
            Patronymic.MinimumWidth = 6;
            Patronymic.Name = "Patronymic";
            // 
            // HomeAddress
            // 
            HomeAddress.HeaderText = "Домашний адрес";
            HomeAddress.MinimumWidth = 6;
            HomeAddress.Name = "HomeAddress";
            // 
            // Telephone
            // 
            Telephone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Telephone.HeaderText = "Телефон";
            Telephone.MinimumWidth = 6;
            Telephone.Name = "Telephone";
            Telephone.Width = 125;
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DateOfBirth.HeaderText = "День рождения";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 85;
            // 
            // Position
            // 
            Position.HeaderText = "Должность";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            // 
            // DateOfEnrollment
            // 
            DateOfEnrollment.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DateOfEnrollment.HeaderText = "Дата зачисления";
            DateOfEnrollment.MinimumWidth = 6;
            DateOfEnrollment.Name = "DateOfEnrollment";
            DateOfEnrollment.Width = 85;
            // 
            // Salary
            // 
            Salary.HeaderText = "Оклад";
            Salary.MinimumWidth = 6;
            Salary.Name = "Salary";
            // 
            // Education
            // 
            Education.HeaderText = "Образование";
            Education.MinimumWidth = 6;
            Education.Name = "Education";
            // 
            // NumberRow
            // 
            NumberRow.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NumberRow.HeaderText = "Номер строки";
            NumberRow.MinimumWidth = 6;
            NumberRow.Name = "NumberRow";
            NumberRow.ReadOnly = true;
            NumberRow.Visible = false;
            NumberRow.Width = 6;
            // 
            // panelStatistics_PPE
            // 
            panelStatistics_PPE.Controls.Add(groupBoxFilter_PPE);
            panelStatistics_PPE.Controls.Add(chartGraphic_PPE);
            panelStatistics_PPE.Controls.Add(dataGridViewFunction_PPE);
            panelStatistics_PPE.Controls.Add(comboBoxIndexStaticColumn_PPE);
            panelStatistics_PPE.Controls.Add(comboBoxIndexFilterColumn_PPE);
            panelStatistics_PPE.Dock = DockStyle.Bottom;
            panelStatistics_PPE.Location = new Point(0, 429);
            panelStatistics_PPE.Name = "panelStatistics_PPE";
            panelStatistics_PPE.Size = new Size(1282, 165);
            panelStatistics_PPE.TabIndex = 1;
            panelStatistics_PPE.Visible = false;
            // 
            // groupBoxFilter_PPE
            // 
            groupBoxFilter_PPE.Controls.Add(checkedListBoxFilter_PPE);
            groupBoxFilter_PPE.Controls.Add(buttonResetFilter_PPE);
            groupBoxFilter_PPE.Controls.Add(buttonUseFilter_PPE);
            groupBoxFilter_PPE.Font = new Font("Segoe UI", 10F);
            groupBoxFilter_PPE.Location = new Point(954, 1);
            groupBoxFilter_PPE.Name = "groupBoxFilter_PPE";
            groupBoxFilter_PPE.Size = new Size(200, 164);
            groupBoxFilter_PPE.TabIndex = 21;
            groupBoxFilter_PPE.TabStop = false;
            groupBoxFilter_PPE.Text = "Фильтер";
            groupBoxFilter_PPE.Visible = false;
            // 
            // checkedListBoxFilter_PPE
            // 
            checkedListBoxFilter_PPE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkedListBoxFilter_PPE.Font = new Font("Segoe UI", 10F);
            checkedListBoxFilter_PPE.Location = new Point(9, 24);
            checkedListBoxFilter_PPE.Name = "checkedListBoxFilter_PPE";
            checkedListBoxFilter_PPE.Size = new Size(185, 104);
            checkedListBoxFilter_PPE.TabIndex = 13;
            toolTip_PPE.SetToolTip(checkedListBoxFilter_PPE, "Настройка фильтра");
            // 
            // buttonResetFilter_PPE
            // 
            buttonResetFilter_PPE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonResetFilter_PPE.Font = new Font("Segoe UI", 10F);
            buttonResetFilter_PPE.Location = new Point(9, 128);
            buttonResetFilter_PPE.Name = "buttonResetFilter_PPE";
            buttonResetFilter_PPE.Size = new Size(80, 29);
            buttonResetFilter_PPE.TabIndex = 18;
            buttonResetFilter_PPE.Text = "Сбросить";
            toolTip_PPE.SetToolTip(buttonResetFilter_PPE, "Сбросить фильтр");
            buttonResetFilter_PPE.UseVisualStyleBackColor = true;
            buttonResetFilter_PPE.Click += buttonResetFilter_PPE_Click;
            // 
            // buttonUseFilter_PPE
            // 
            buttonUseFilter_PPE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUseFilter_PPE.Font = new Font("Segoe UI", 10F);
            buttonUseFilter_PPE.Location = new Point(95, 128);
            buttonUseFilter_PPE.Name = "buttonUseFilter_PPE";
            buttonUseFilter_PPE.Size = new Size(99, 29);
            buttonUseFilter_PPE.TabIndex = 18;
            buttonUseFilter_PPE.Text = "Применить";
            toolTip_PPE.SetToolTip(buttonUseFilter_PPE, "Применить фильтр");
            buttonUseFilter_PPE.UseVisualStyleBackColor = true;
            buttonUseFilter_PPE.Click += buttonUseFilter_PPE_Click;
            // 
            // chartGraphic_PPE
            // 
            chartGraphic_PPE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartGraphic_PPE.ChartAreas.Add(chartArea1);
            legend1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartGraphic_PPE.Legends.Add(legend1);
            chartGraphic_PPE.Location = new Point(401, 0);
            chartGraphic_PPE.Name = "chartGraphic_PPE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraphic_PPE.Series.Add(series1);
            chartGraphic_PPE.Size = new Size(433, 159);
            chartGraphic_PPE.TabIndex = 20;
            chartGraphic_PPE.Text = "chart1";
            toolTip_PPE.SetToolTip(chartGraphic_PPE, "График по выбранному столбцу");
            chartGraphic_PPE.Visible = false;
            // 
            // dataGridViewFunction_PPE
            // 
            dataGridViewFunction_PPE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewFunction_PPE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFunction_PPE.BackgroundColor = SystemColors.Control;
            dataGridViewFunction_PPE.BorderStyle = BorderStyle.None;
            dataGridViewFunction_PPE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_PPE.Columns.AddRange(new DataGridViewColumn[] { Function, Result });
            dataGridViewFunction_PPE.Location = new Point(840, 0);
            dataGridViewFunction_PPE.Name = "dataGridViewFunction_PPE";
            dataGridViewFunction_PPE.RowHeadersVisible = false;
            dataGridViewFunction_PPE.RowHeadersWidth = 51;
            dataGridViewFunction_PPE.RowTemplate.ReadOnly = true;
            dataGridViewFunction_PPE.ScrollBars = ScrollBars.None;
            dataGridViewFunction_PPE.Size = new Size(240, 188);
            dataGridViewFunction_PPE.TabIndex = 17;
            toolTip_PPE.SetToolTip(dataGridViewFunction_PPE, "Статистика выбранного столбца");
            dataGridViewFunction_PPE.Visible = false;
            // 
            // Function
            // 
            Function.HeaderText = "Функция";
            Function.MinimumWidth = 6;
            Function.Name = "Function";
            Function.ReadOnly = true;
            Function.Width = 125;
            // 
            // Result
            // 
            Result.HeaderText = "Значение";
            Result.MinimumWidth = 6;
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Width = 125;
            // 
            // comboBoxIndexStaticColumn_PPE
            // 
            comboBoxIndexStaticColumn_PPE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxIndexStaticColumn_PPE.Font = new Font("Segoe UI", 10F);
            comboBoxIndexStaticColumn_PPE.FormattingEnabled = true;
            comboBoxIndexStaticColumn_PPE.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Домашний адрес", "Телефон", "День рождения", "Должность", "Дата зачисления", "Оклад", "Образование" });
            comboBoxIndexStaticColumn_PPE.Location = new Point(12, 89);
            comboBoxIndexStaticColumn_PPE.Name = "comboBoxIndexStaticColumn_PPE";
            comboBoxIndexStaticColumn_PPE.Size = new Size(121, 31);
            comboBoxIndexStaticColumn_PPE.TabIndex = 15;
            toolTip_PPE.SetToolTip(comboBoxIndexStaticColumn_PPE, "Выбор столбца для статистики");
            comboBoxIndexStaticColumn_PPE.TextChanged += comboBoxIndexStaticColumn_PPE_TextChanged;
            comboBoxIndexStaticColumn_PPE.KeyPress += comboBoxIndexFilterColumn_PPE_KeyPress;
            // 
            // comboBoxIndexFilterColumn_PPE
            // 
            comboBoxIndexFilterColumn_PPE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxIndexFilterColumn_PPE.Font = new Font("Segoe UI", 10F);
            comboBoxIndexFilterColumn_PPE.FormattingEnabled = true;
            comboBoxIndexFilterColumn_PPE.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Домашний адрес", "Телефон", "День рождения", "Должность", "Дата зачисления", "Оклад", "Образование" });
            comboBoxIndexFilterColumn_PPE.Location = new Point(12, 120);
            comboBoxIndexFilterColumn_PPE.Name = "comboBoxIndexFilterColumn_PPE";
            comboBoxIndexFilterColumn_PPE.Size = new Size(121, 31);
            comboBoxIndexFilterColumn_PPE.TabIndex = 15;
            toolTip_PPE.SetToolTip(comboBoxIndexFilterColumn_PPE, "Выбор столбца для фильтра");
            comboBoxIndexFilterColumn_PPE.TextChanged += comboBoxIndexFilterColumn_PPE_TextChanged;
            comboBoxIndexFilterColumn_PPE.KeyPress += comboBoxIndexFilterColumn_PPE_KeyPress;
            // 
            // buttonMain_PPE
            // 
            buttonMain_PPE.Font = new Font("Segoe UI", 16F);
            buttonMain_PPE.Location = new Point(37, 109);
            buttonMain_PPE.Name = "buttonMain_PPE";
            buttonMain_PPE.Size = new Size(210, 70);
            buttonMain_PPE.TabIndex = 2;
            buttonMain_PPE.Text = "Таблица";
            toolTip_PPE.SetToolTip(buttonMain_PPE, "Открывает рабочее пространство");
            buttonMain_PPE.UseVisualStyleBackColor = true;
            buttonMain_PPE.Click += buttonMain_PPE_Click;
            // 
            // buttonManual_PPE
            // 
            buttonManual_PPE.Font = new Font("Segoe UI", 16F);
            buttonManual_PPE.Location = new Point(37, 185);
            buttonManual_PPE.Name = "buttonManual_PPE";
            buttonManual_PPE.Size = new Size(210, 70);
            buttonManual_PPE.TabIndex = 2;
            buttonManual_PPE.Text = "Руководство";
            toolTip_PPE.SetToolTip(buttonManual_PPE, "Открывает руководство по приложению");
            buttonManual_PPE.UseVisualStyleBackColor = true;
            buttonManual_PPE.Click += buttonManual_PPE_Click;
            // 
            // buttonAboutProgram_PPE
            // 
            buttonAboutProgram_PPE.Font = new Font("Segoe UI", 16F);
            buttonAboutProgram_PPE.Location = new Point(37, 261);
            buttonAboutProgram_PPE.Name = "buttonAboutProgram_PPE";
            buttonAboutProgram_PPE.Size = new Size(210, 70);
            buttonAboutProgram_PPE.TabIndex = 2;
            buttonAboutProgram_PPE.Text = "О приложении";
            toolTip_PPE.SetToolTip(buttonAboutProgram_PPE, "Об авторе приложения");
            buttonAboutProgram_PPE.UseVisualStyleBackColor = true;
            buttonAboutProgram_PPE.Click += buttonAboutProgram_PPE_Click;
            // 
            // textBoxInform_PPE
            // 
            textBoxInform_PPE.BackColor = SystemColors.Control;
            textBoxInform_PPE.BorderStyle = BorderStyle.None;
            textBoxInform_PPE.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInform_PPE.Location = new Point(37, 46);
            textBoxInform_PPE.Multiline = true;
            textBoxInform_PPE.Name = "textBoxInform_PPE";
            textBoxInform_PPE.ReadOnly = true;
            textBoxInform_PPE.Size = new Size(210, 57);
            textBoxInform_PPE.TabIndex = 3;
            textBoxInform_PPE.Text = "Приложение для отдела кадров";
            textBoxInform_PPE.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 594);
            Controls.Add(textBoxInform_PPE);
            Controls.Add(buttonAboutProgram_PPE);
            Controls.Add(buttonManual_PPE);
            Controls.Add(buttonMain_PPE);
            Controls.Add(panelTable_PPE);
            Controls.Add(panelStatistics_PPE);
            Controls.Add(panelMenu_PPE);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(284, 361);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отдел кадров";
            panelMenu_PPE.ResumeLayout(false);
            groupBoxSearch_PPE.ResumeLayout(false);
            groupBoxSearch_PPE.PerformLayout();
            panelTable_PPE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_PPE).EndInit();
            panelStatistics_PPE.ResumeLayout(false);
            groupBoxFilter_PPE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGraphic_PPE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_PPE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu_PPE;
        private Panel panelTable_PPE;
        private DataGridView dataGridViewTable_PPE;
        private Button buttonSaveTableInFile_PPE;
        private Button buttonLoadTable_PPE;
        private OpenFileDialog openFileDialog_PPE;
        private Button buttonLoadTableClose_PPE;
        private Button buttonLoadTableSave_PPE;
        private Panel panelStatistics_PPE;
        private Button buttonSaveAnotherFile_PPE;
        private SaveFileDialog saveFileDialog_PPE;
        private Button buttonMenu_PPE;
        private GroupBox groupBoxSearch_PPE;
        private TextBox textBoxSearch_PPE;
        private Button buttonSearch_PPE;
        private CheckedListBox checkedListBoxFilter_PPE;
        private ComboBox comboBoxIndexFilterColumn_PPE;
        private DataGridView dataGridViewFunction_PPE;
        private DataGridViewTextBoxColumn Function;
        private DataGridViewTextBoxColumn Result;
        private Button buttonResetFilter_PPE;
        private Button buttonUseFilter_PPE;
        private Button buttonResetTable_PPE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic_PPE;
        private ToolTip toolTip_PPE;
        private GroupBox groupBoxFilter_PPE;
        private Button buttonMain_PPE;
        private Button buttonManual_PPE;
        private Button buttonAboutProgram_PPE;
        private TextBox textBoxInform_PPE;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Patronymic;
        private DataGridViewTextBoxColumn HomeAddress;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn DateOfEnrollment;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Education;
        private DataGridViewTextBoxColumn NumberRow;
        private ComboBox comboBoxIndexStaticColumn_PPE;
    }
}
