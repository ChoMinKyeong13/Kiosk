namespace Kiosk
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            textBox_Id = new TextBox();
            textBox_Name = new TextBox();
            textBox_Tel = new TextBox();
            btnRegister = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnRegister).BeginInit();
            SuspendLayout();
            // 
            // textBox_Id
            // 
            textBox_Id.Location = new Point(132, 38);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(100, 23);
            textBox_Id.TabIndex = 0;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(132, 92);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(100, 23);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_Tel
            // 
            textBox_Tel.Location = new Point(132, 157);
            textBox_Tel.Name = "textBox_Tel";
            textBox_Tel.Size = new Size(100, 23);
            textBox_Tel.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(81, 203);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(182, 50);
            btnRegister.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegister.TabIndex = 1;
            btnRegister.TabStop = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 157);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "전화번호";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(326, 265);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(textBox_Tel);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_Id);
            DoubleBuffered = true;
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)btnRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Id;
        private TextBox textBox_Name;
        private TextBox textBox_Tel;
        private PictureBox btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}