namespace Kiosk
{
    partial class Cartform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartform));
            listBox_Cart = new ListBox();
            lblTotal = new Label();
            btnRemoveFromCart = new PictureBox();
            btnCheckout = new PictureBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnRemoveFromCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCheckout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // listBox_Cart
            // 
            listBox_Cart.FormattingEnabled = true;
            listBox_Cart.ItemHeight = 15;
            listBox_Cart.Location = new Point(34, 12);
            listBox_Cart.Name = "listBox_Cart";
            listBox_Cart.Size = new Size(175, 274);
            listBox_Cart.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(257, 24);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "label1";
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.BackColor = Color.Transparent;
            btnRemoveFromCart.Image = (Image)resources.GetObject("btnRemoveFromCart.Image");
            btnRemoveFromCart.Location = new Point(257, 67);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(164, 51);
            btnRemoveFromCart.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRemoveFromCart.TabIndex = 2;
            btnRemoveFromCart.TabStop = false;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Transparent;
            btnCheckout.Image = (Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.Location = new Point(257, 143);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(164, 46);
            btnCheckout.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCheckout.TabIndex = 2;
            btnCheckout.TabStop = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(257, 220);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(183, 50);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // Cartform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(452, 308);
            Controls.Add(btnClose);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblTotal);
            Controls.Add(listBox_Cart);
            DoubleBuffered = true;
            Name = "Cartform";
            Text = "Cartform";
            Load += Cartform_Load;
            ((System.ComponentModel.ISupportInitialize)btnRemoveFromCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCheckout).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_Cart;
        private Label lblTotal;
        private PictureBox btnRemoveFromCart;
        private PictureBox btnCheckout;
        private PictureBox btnClose;
    }
}