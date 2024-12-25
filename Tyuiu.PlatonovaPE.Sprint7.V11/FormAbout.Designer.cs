namespace Tyuiu.PlatonovaPE.Sprint7.V11
{
    partial class FormAbout
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
            textBoxInformation_PPE = new TextBox();
            buttonClose_PPE = new Button();
            SuspendLayout();
            // 
            // textBoxInformation_PPE
            // 
            textBoxInformation_PPE.Location = new Point(12, 12);
            textBoxInformation_PPE.Multiline = true;
            textBoxInformation_PPE.Name = "textBoxInformation_PPE";
            textBoxInformation_PPE.ReadOnly = true;
            textBoxInformation_PPE.Size = new Size(230, 226);
            textBoxInformation_PPE.TabIndex = 0;
            // 
            // buttonClose_PPE
            // 
            buttonClose_PPE.Location = new Point(167, 244);
            buttonClose_PPE.Name = "buttonClose_PPE";
            buttonClose_PPE.Size = new Size(75, 26);
            buttonClose_PPE.TabIndex = 1;
            buttonClose_PPE.Text = "Ок";
            buttonClose_PPE.UseVisualStyleBackColor = true;
            buttonClose_PPE.Click += buttonClose_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 286);
            Controls.Add(buttonClose_PPE);
            Controls.Add(textBoxInformation_PPE);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInformation_PPE;
        private Button buttonClose_PPE;
    }
}
