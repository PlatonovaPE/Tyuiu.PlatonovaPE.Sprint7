namespace Tyuiu.PlatonovaPE.Sprint7.V11
{
    partial class FormManual
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
            tabControlText_PPE = new TabControl();
            UpLeft = new TabPage();
            textBoxUpLeft_PPE = new TextBox();
            UpRight = new TabPage();
            textBoxUpRight_PPE = new TextBox();
            Down = new TabPage();
            textBoxDown_PPE = new TextBox();
            Centre = new TabPage();
            textBoxCentre_PPE = new TextBox();
            buttonClose_PPE = new Button();
            tabControlText_PPE.SuspendLayout();
            UpLeft.SuspendLayout();
            UpRight.SuspendLayout();
            Down.SuspendLayout();
            Centre.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlText_PPE
            // 
            tabControlText_PPE.Controls.Add(UpLeft);
            tabControlText_PPE.Controls.Add(UpRight);
            tabControlText_PPE.Controls.Add(Down);
            tabControlText_PPE.Controls.Add(Centre);
            tabControlText_PPE.Location = new Point(12, 12);
            tabControlText_PPE.Name = "tabControlText_PPE";
            tabControlText_PPE.SelectedIndex = 0;
            tabControlText_PPE.Size = new Size(398, 309);
            tabControlText_PPE.TabIndex = 0;
            // 
            // UpLeft
            // 
            UpLeft.Controls.Add(textBoxUpLeft_PPE);
            UpLeft.Location = new Point(4, 32);
            UpLeft.Name = "UpLeft";
            UpLeft.Padding = new Padding(3);
            UpLeft.Size = new Size(390, 273);
            UpLeft.TabIndex = 0;
            UpLeft.Text = "Верхний левый угол";
            UpLeft.UseVisualStyleBackColor = true;
            // 
            // textBoxUpLeft_PPE
            // 
            textBoxUpLeft_PPE.Location = new Point(6, 6);
            textBoxUpLeft_PPE.Multiline = true;
            textBoxUpLeft_PPE.Name = "textBoxUpLeft_PPE";
            textBoxUpLeft_PPE.Size = new Size(378, 267);
            textBoxUpLeft_PPE.TabIndex = 0;
            // 
            // UpRight
            // 
            UpRight.Controls.Add(textBoxUpRight_PPE);
            UpRight.Location = new Point(4, 29);
            UpRight.Name = "UpRight";
            UpRight.Padding = new Padding(3);
            UpRight.Size = new Size(390, 276);
            UpRight.TabIndex = 1;
            UpRight.Text = "Верхний правый угол";
            UpRight.UseVisualStyleBackColor = true;
            // 
            // textBoxUpRight_PPE
            // 
            textBoxUpRight_PPE.Location = new Point(6, 6);
            textBoxUpRight_PPE.Multiline = true;
            textBoxUpRight_PPE.Name = "textBoxUpRight_PPE";
            textBoxUpRight_PPE.Size = new Size(378, 267);
            textBoxUpRight_PPE.TabIndex = 0;
            // 
            // Down
            // 
            Down.Controls.Add(textBoxDown_PPE);
            Down.Location = new Point(4, 29);
            Down.Name = "Down";
            Down.Size = new Size(390, 276);
            Down.TabIndex = 2;
            Down.Text = "Низ";
            Down.UseVisualStyleBackColor = true;
            // 
            // textBoxDown_PPE
            // 
            textBoxDown_PPE.Location = new Point(6, 6);
            textBoxDown_PPE.Multiline = true;
            textBoxDown_PPE.Name = "textBoxDown_PPE";
            textBoxDown_PPE.Size = new Size(378, 267);
            textBoxDown_PPE.TabIndex = 0;
            // 
            // Centre
            // 
            Centre.Controls.Add(textBoxCentre_PPE);
            Centre.Location = new Point(4, 29);
            Centre.Name = "Centre";
            Centre.Size = new Size(390, 276);
            Centre.TabIndex = 3;
            Centre.Text = "Центр";
            Centre.UseVisualStyleBackColor = true;
            // 
            // textBoxCentre_PPE
            // 
            textBoxCentre_PPE.Location = new Point(6, 6);
            textBoxCentre_PPE.Multiline = true;
            textBoxCentre_PPE.Name = "textBoxCentre_PPE";
            textBoxCentre_PPE.Size = new Size(378, 267);
            textBoxCentre_PPE.TabIndex = 0;
            textBoxCentre_PPE.Text = "В центре расположена таблица.\r\nПри нажании на столбец начинается сортировка по столбцу.\r\nПри нажатии на строку и нажатии кнопки \"DEL\", строка удаляется.";
            // 
            // buttonClose_PPE
            // 
            buttonClose_PPE.Location = new Point(335, 327);
            buttonClose_PPE.Name = "buttonClose_PPE";
            buttonClose_PPE.Size = new Size(75, 26);
            buttonClose_PPE.TabIndex = 1;
            buttonClose_PPE.Text = "Ок";
            buttonClose_PPE.UseVisualStyleBackColor = true;
            buttonClose_PPE.Click += buttonClose_PPE_Click;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 526);
            Controls.Add(buttonClose_PPE);
            Controls.Add(tabControlText_PPE);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormManual";
            tabControlText_PPE.ResumeLayout(false);
            UpLeft.ResumeLayout(false);
            UpLeft.PerformLayout();
            UpRight.ResumeLayout(false);
            UpRight.PerformLayout();
            Down.ResumeLayout(false);
            Down.PerformLayout();
            Centre.ResumeLayout(false);
            Centre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlText_PPE;
        private TabPage UpLeft;
        private TabPage UpRight;
        private TabPage Down;
        private TabPage Centre;
        private TextBox textBoxUpLeft_PPE;
        private TextBox textBoxUpRight_PPE;
        private TextBox textBoxDown_PPE;
        private TextBox textBoxCentre_PPE;
        private Button buttonClose_PPE;
    }
}
