﻿namespace E_commerce.Presentation_Layer
{
    partial class cart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNO = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(257, 4);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(242, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "products in the cart";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 357);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(484, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Go To Payment";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Farsi Simple Outline", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(106, 67);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(134, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Products NO:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Farsi Simple Outline", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(106, 107);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // productNO
            // 
            this.productNO.AutoSize = true;
            this.productNO.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.productNO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productNO.Location = new System.Drawing.Point(236, 72);
            this.productNO.Name = "productNO";
            this.productNO.Size = new System.Drawing.Size(21, 22);
            this.productNO.TabIndex = 19;
            this.productNO.Text = "6";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TotalPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalPrice.Location = new System.Drawing.Point(236, 110);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(21, 22);
            this.TotalPrice.TabIndex = 20;
            this.TotalPrice.Text = "6";
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.productNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "cart";
            this.Size = new System.Drawing.Size(786, 506);
            this.Load += new System.EventHandler(this.cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productNO;
        private System.Windows.Forms.Label TotalPrice;
    }
}
