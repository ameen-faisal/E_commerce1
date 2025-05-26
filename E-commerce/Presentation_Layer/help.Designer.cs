namespace E_commerce.Presentation_Layer
{
    partial class help
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(172, 27);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(406, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hello, How can we help you?";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::E_commerce.Properties.Resources.icons8_searc_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(26, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 32);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::E_commerce.Properties.Resources.search2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(71, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 96);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(67, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Ask a Question";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.BlueViolet;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(509, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 36);
            this.button8.TabIndex = 13;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "help";
            this.Size = new System.Drawing.Size(786, 506);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
    }
}
