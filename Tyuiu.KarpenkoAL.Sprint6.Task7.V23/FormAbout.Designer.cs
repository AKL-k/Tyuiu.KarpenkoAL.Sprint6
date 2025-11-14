namespace Tyuiu.KarpenkoAL.Sprint6.Task7.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxInfo = new PictureBox();
            groupBoxInfo = new GroupBox();
            textBoxInfo = new TextBox();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).BeginInit();
            groupBoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxInfo
            // 
            pictureBoxInfo.BackgroundImage = Properties.Resources.fr1;
            pictureBoxInfo.Location = new Point(27, 24);
            pictureBoxInfo.Name = "pictureBoxInfo";
            pictureBoxInfo.Size = new Size(290, 318);
            pictureBoxInfo.TabIndex = 0;
            pictureBoxInfo.TabStop = false;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(textBoxInfo);
            groupBoxInfo.Location = new Point(336, 24);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(421, 318);
            groupBoxInfo.TabIndex = 2;
            groupBoxInfo.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Dock = DockStyle.Fill;
            textBoxInfo.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInfo.Location = new Point(3, 23);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(415, 292);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(685, 345);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(52, 27);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 377);
            Controls.Add(buttonOK);
            Controls.Add(groupBoxInfo);
            Controls.Add(pictureBoxInfo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxInfo;
        private GroupBox groupBoxInfo;
        private TextBox textBoxInfo;
        private Button buttonOK;
    }
}