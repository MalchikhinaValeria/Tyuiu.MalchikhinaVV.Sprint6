namespace Tyuiu.MalchikhinaVV.Sprint6.Task7.V28
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
            pictureBoxAvatar_MVV = new PictureBox();
            labelAbout_MVV = new Label();
            buttonOK_MVV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MVV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_MVV
            // 
            pictureBoxAvatar_MVV.BackgroundImage = (Image)resources.GetObject("pictureBoxAvatar_MVV.BackgroundImage");
            pictureBoxAvatar_MVV.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxAvatar_MVV.Location = new Point(12, 12);
            pictureBoxAvatar_MVV.Name = "pictureBoxAvatar_MVV";
            pictureBoxAvatar_MVV.Size = new Size(163, 216);
            pictureBoxAvatar_MVV.TabIndex = 0;
            pictureBoxAvatar_MVV.TabStop = false;
            // 
            // labelAbout_MVV
            // 
            labelAbout_MVV.AutoSize = true;
            labelAbout_MVV.Location = new Point(190, 12);
            labelAbout_MVV.Name = "labelAbout_MVV";
            labelAbout_MVV.Size = new Size(387, 200);
            labelAbout_MVV.TabIndex = 1;
            labelAbout_MVV.Text = resources.GetString("labelAbout_MVV.Text");
            // 
            // buttonOK_MVV
            // 
            buttonOK_MVV.BackColor = Color.FromArgb(128, 255, 255);
            buttonOK_MVV.Location = new Point(483, 215);
            buttonOK_MVV.Name = "buttonOK_MVV";
            buttonOK_MVV.Size = new Size(94, 29);
            buttonOK_MVV.TabIndex = 2;
            buttonOK_MVV.Text = "OK";
            buttonOK_MVV.UseVisualStyleBackColor = false;
            buttonOK_MVV.Click += buttonOK_MVV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 259);
            Controls.Add(buttonOK_MVV);
            Controls.Add(labelAbout_MVV);
            Controls.Add(pictureBoxAvatar_MVV);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_MVV;
        private Label labelAbout_MVV;
        private Button buttonOK_MVV;
    }
}