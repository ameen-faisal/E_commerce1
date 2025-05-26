namespace E_commerce.Presentation_Layer
{
    partial class signUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(73, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "create a new account";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "SIGNUP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::E_commerce.Properties.Resources.inputColor;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(20, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 49);
            this.panel1.TabIndex = 15;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordBox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordBox.Location = new System.Drawing.Point(61, 16);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(186, 17);
            this.passwordBox.TabIndex = 9;
            this.passwordBox.Text = "password";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::E_commerce.Properties.Resources.icons8_password_32;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(19, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 21);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::E_commerce.Properties.Resources.icons8user_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(113, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::E_commerce.Properties.Resources.inputColor;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.emailBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(20, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 49);
            this.panel2.TabIndex = 14;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.Gainsboro;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailBox.ForeColor = System.Drawing.Color.DimGray;
            this.emailBox.Location = new System.Drawing.Point(61, 16);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(186, 17);
            this.emailBox.TabIndex = 9;
            this.emailBox.Text = "Enter email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::E_commerce.Properties.Resources.icons8_new_message_32;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(19, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 19);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::E_commerce.Properties.Resources.inputColor;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.passwordBox2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(20, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 49);
            this.panel5.TabIndex = 16;
            // 
            // passwordBox2
            // 
            this.passwordBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordBox2.ForeColor = System.Drawing.Color.DimGray;
            this.passwordBox2.Location = new System.Drawing.Point(61, 16);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.Size = new System.Drawing.Size(186, 17);
            this.passwordBox2.TabIndex = 9;
            this.passwordBox2.Text = "confiem password";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::E_commerce.Properties.Resources.icons8_password_32;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(19, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(23, 21);
            this.panel6.TabIndex = 9;
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "signUp";
            this.Size = new System.Drawing.Size(308, 392);
            this.Load += new System.EventHandler(this.signUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.Panel panel6;
    }
}
