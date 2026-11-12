namespace Kiosk
{
    partial class Categoryform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoryform));
            burger = new PictureBox();
            rice = new PictureBox();
            ramen = new PictureBox();
            snack = new PictureBox();
            drink = new PictureBox();
            icecream = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)burger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ramen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icecream).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // burger
            // 
            burger.Image = (Image)resources.GetObject("burger.Image");
            burger.Location = new Point(61, 173);
            burger.Name = "burger";
            burger.Size = new Size(133, 105);
            burger.SizeMode = PictureBoxSizeMode.StretchImage;
            burger.TabIndex = 0;
            burger.TabStop = false;
            burger.Click += burger_Click;
            // 
            // rice
            // 
            rice.Image = (Image)resources.GetObject("rice.Image");
            rice.Location = new Point(272, 173);
            rice.Name = "rice";
            rice.Size = new Size(133, 105);
            rice.SizeMode = PictureBoxSizeMode.StretchImage;
            rice.TabIndex = 0;
            rice.TabStop = false;
            rice.Click += rice_Click;
            // 
            // ramen
            // 
            ramen.Image = (Image)resources.GetObject("ramen.Image");
            ramen.Location = new Point(61, 329);
            ramen.Name = "ramen";
            ramen.Size = new Size(133, 105);
            ramen.SizeMode = PictureBoxSizeMode.StretchImage;
            ramen.TabIndex = 0;
            ramen.TabStop = false;
            ramen.Click += ramen_Click;
            // 
            // snack
            // 
            snack.Image = (Image)resources.GetObject("snack.Image");
            snack.Location = new Point(272, 329);
            snack.Name = "snack";
            snack.Size = new Size(133, 105);
            snack.SizeMode = PictureBoxSizeMode.StretchImage;
            snack.TabIndex = 0;
            snack.TabStop = false;
            snack.Click += snack_Click;
            // 
            // drink
            // 
            drink.Image = (Image)resources.GetObject("drink.Image");
            drink.Location = new Point(61, 499);
            drink.Name = "drink";
            drink.Size = new Size(133, 105);
            drink.SizeMode = PictureBoxSizeMode.StretchImage;
            drink.TabIndex = 0;
            drink.TabStop = false;
            drink.Click += drink_Click;
            // 
            // icecream
            // 
            icecream.Image = (Image)resources.GetObject("icecream.Image");
            icecream.Location = new Point(272, 499);
            icecream.Name = "icecream";
            icecream.Size = new Size(133, 105);
            icecream.SizeMode = PictureBoxSizeMode.StretchImage;
            icecream.TabIndex = 0;
            icecream.TabStop = false;
            icecream.Click += icecream_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Categoryform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(485, 671);
            Controls.Add(pictureBox1);
            Controls.Add(rice);
            Controls.Add(snack);
            Controls.Add(icecream);
            Controls.Add(drink);
            Controls.Add(ramen);
            Controls.Add(burger);
            DoubleBuffered = true;
            Name = "Categoryform";
            Text = "Categoryform";
            
            ((System.ComponentModel.ISupportInitialize)burger).EndInit();
            ((System.ComponentModel.ISupportInitialize)rice).EndInit();
            ((System.ComponentModel.ISupportInitialize)ramen).EndInit();
            ((System.ComponentModel.ISupportInitialize)snack).EndInit();
            ((System.ComponentModel.ISupportInitialize)drink).EndInit();
            ((System.ComponentModel.ISupportInitialize)icecream).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox burger;
        private PictureBox rice;
        private PictureBox ramen;
        private PictureBox snack;
        private PictureBox drink;
        private PictureBox icecream;
        private PictureBox pictureBox1;
    }
}