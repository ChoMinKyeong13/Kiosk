namespace Kiosk
{
    partial class CardPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPaymentForm));
            lblAmount = new Label();
            comboBox_CardCompany = new ComboBox();
            comboBox_Installment = new ComboBox();
            checkBox_Agree = new CheckBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(38, 42);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(39, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "label1";
            // 
            // comboBox_CardCompany
            // 
            comboBox_CardCompany.FormattingEnabled = true;
            comboBox_CardCompany.Location = new Point(38, 93);
            comboBox_CardCompany.Name = "comboBox_CardCompany";
            comboBox_CardCompany.Size = new Size(93, 23);
            comboBox_CardCompany.TabIndex = 1;
            // 
            // comboBox_Installment
            // 
            comboBox_Installment.FormattingEnabled = true;
            comboBox_Installment.Location = new Point(152, 93);
            comboBox_Installment.Name = "comboBox_Installment";
            comboBox_Installment.Size = new Size(93, 23);
            comboBox_Installment.TabIndex = 1;
            // 
            // checkBox_Agree
            // 
            checkBox_Agree.AutoSize = true;
            checkBox_Agree.Location = new Point(262, 191);
            checkBox_Agree.Name = "checkBox_Agree";
            checkBox_Agree.Size = new Size(134, 19);
            checkBox_Agree.TabIndex = 2;
            checkBox_Agree.Text = "개인정보 동의(필수)";
            checkBox_Agree.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(78, 248);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "결제하기";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(201, 248);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "취소하기";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CardPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(395, 391);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(checkBox_Agree);
            Controls.Add(comboBox_Installment);
            Controls.Add(comboBox_CardCompany);
            Controls.Add(lblAmount);
            DoubleBuffered = true;
            Name = "CardPaymentForm";
            Text = "CardPaymentForm";
            Load += CardPaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private ComboBox comboBox_CardCompany;
        private ComboBox comboBox_Installment;
        private CheckBox checkBox_Agree;
        private Button btnConfirm;
        private Button btnCancel;
    }
}