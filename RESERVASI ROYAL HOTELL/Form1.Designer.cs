namespace RESERVASI_ROYAL_HOTELL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usertext = new TextBox();
            passwordtext = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Clarendon BT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(515, 98);
            label1.Name = "label1";
            label1.Size = new Size(130, 39);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(419, 225);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(419, 307);
            label3.Name = "label3";
            label3.Size = new Size(99, 26);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // usertext
            // 
            usertext.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usertext.Location = new Point(601, 225);
            usertext.Name = "usertext";
            usertext.Size = new Size(254, 30);
            usertext.TabIndex = 3;
            // 
            // passwordtext
            // 
            passwordtext.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtext.Location = new Point(601, 304);
            passwordtext.Name = "passwordtext";
            passwordtext.PasswordChar = '*';
            passwordtext.Size = new Size(254, 30);
            passwordtext.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(428, 419);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(581, 419);
            button2.Name = "button2";
            button2.Size = new Size(112, 52);
            button2.TabIndex = 6;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(730, 419);
            button3.Name = "button3";
            button3.Size = new Size(112, 52);
            button3.TabIndex = 7;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rumah_removebg_preview;
            pictureBox1.Location = new Point(98, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1055, 583);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passwordtext);
            Controls.Add(usertext);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usertext;
        private TextBox passwordtext;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
