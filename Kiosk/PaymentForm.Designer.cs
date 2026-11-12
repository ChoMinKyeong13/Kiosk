namespace Kiosk
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            lblAmount = new Label();
            lblMyPoints = new Label();
            btnPoint = new PictureBox();
            btnCard = new PictureBox();
            listBox_CartItems = new ListBox();
            ((System.ComponentModel.ISupportInitialize)btnPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCard).BeginInit();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(249, 29);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(39, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "label1";
            // 
            // lblMyPoints
            // 
            lblMyPoints.AutoSize = true;
            lblMyPoints.Location = new Point(249, 93);
            lblMyPoints.Name = "lblMyPoints";
            lblMyPoints.Size = new Size(39, 15);
            lblMyPoints.TabIndex = 1;
            lblMyPoints.Text = "label2";
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.Transparent;
            btnPoint.Image = (Image)resources.GetObject("btnPoint.Image");
            btnPoint.Location = new Point(249, 274);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(138, 45);
            btnPoint.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPoint.TabIndex = 2;
            btnPoint.TabStop = false;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnCard
            // 
            btnCard.BackColor = Color.Transparent;
            btnCard.Image = (Image)resources.GetObject("btnCard.Image");
            btnCard.Location = new Point(249, 175);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(138, 50);
            btnCard.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCard.TabIndex = 2;
            btnCard.TabStop = false;
            btnCard.Click += btnCard_Click;
            // 
            // listBox_CartItems
            // 
            listBox_CartItems.FormattingEnabled = true;
            listBox_CartItems.ItemHeight = 15;
            listBox_CartItems.Location = new Point(12, 12);
            listBox_CartItems.Name = "listBox_CartItems";
            listBox_CartItems.Size = new Size(209, 289);
            listBox_CartItems.TabIndex = 3;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(421, 392);
            Controls.Add(listBox_CartItems);
            Controls.Add(btnCard);
            Controls.Add(btnPoint);
            Controls.Add(lblMyPoints);
            Controls.Add(lblAmount);
            DoubleBuffered = true;
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private Label lblMyPoints;
        private PictureBox btnPoint;
        private PictureBox btnCard;
        private ListBox listBox_CartItems;
    }
}