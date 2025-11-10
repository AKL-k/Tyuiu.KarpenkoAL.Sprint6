namespace Tyuiu.KarpenkoAL.Sprint6.Task6.V10
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
            pictureBoxF = new PictureBox();
            groupBoxInfo = new GroupBox();
            textBoxInfo = new TextBox();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxF).BeginInit();
            groupBoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxF
            // 
            pictureBoxF.Image = Properties.Resources.fr;
            pictureBoxF.Location = new Point(15, 14);
            pictureBoxF.Name = "pictureBoxF";
            pictureBoxF.Size = new Size(292, 319);
            pictureBoxF.TabIndex = 0;
            pictureBoxF.TabStop = false;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(textBoxInfo);
            groupBoxInfo.Location = new Point(324, 15);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(421, 276);
            groupBoxInfo.TabIndex = 1;
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
            textBoxInfo.Size = new Size(415, 250);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo.Location = new Point(678, 307);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 26);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Ок";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 354);
            Controls.Add(buttonInfo);
            Controls.Add(groupBoxInfo);
            Controls.Add(pictureBoxF);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О прорамме";
            ((System.ComponentModel.ISupportInitialize)pictureBoxF).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxF;
        private GroupBox groupBoxInfo;
        private TextBox textBoxInfo;
        private Button buttonInfo;
    }
}