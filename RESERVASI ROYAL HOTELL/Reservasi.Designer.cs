namespace RESERVASI_ROYAL_HOTELL
{
    partial class Reservasi
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            namatext = new TextBox();
            totaltext = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            typecombo = new ComboBox();
            label7 = new Label();
            pembayarancombo = new ComboBox();
            lamacombo = new ComboBox();
            dataGridView1 = new DataGridView();
            namapemesan = new DataGridViewTextBoxColumn();
            typekamar = new DataGridViewTextBoxColumn();
            metodepembayaran = new DataGridViewTextBoxColumn();
            lamainap = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rumah_removebg_preview;
            pictureBox1.Location = new Point(668, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Clarendon BT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(621, 86);
            label2.Name = "label2";
            label2.Size = new Size(269, 39);
            label2.TabIndex = 3;
            label2.Text = "ROYAL HOTEL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 208);
            label1.Name = "label1";
            label1.Size = new Size(144, 26);
            label1.TabIndex = 4;
            label1.Text = "Nama Pemesan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 342);
            label3.Name = "label3";
            label3.Size = new Size(119, 26);
            label3.TabIndex = 5;
            label3.Text = "Type Kamar :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 411);
            label4.Name = "label4";
            label4.Size = new Size(184, 26);
            label4.TabIndex = 6;
            label4.Text = "Metode Pembayaran :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 471);
            label5.Name = "label5";
            label5.Size = new Size(106, 26);
            label5.TabIndex = 7;
            label5.Text = "Lama Inap :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 534);
            label6.Name = "label6";
            label6.Size = new Size(62, 26);
            label6.TabIndex = 8;
            label6.Text = "Total :";
            // 
            // namatext
            // 
            namatext.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namatext.Location = new Point(314, 208);
            namatext.Name = "namatext";
            namatext.Size = new Size(287, 30);
            namatext.TabIndex = 9;
            // 
            // totaltext
            // 
            totaltext.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totaltext.Location = new Point(314, 534);
            totaltext.Name = "totaltext";
            totaltext.Size = new Size(287, 30);
            totaltext.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(314, 273);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 30);
            dateTimePicker1.TabIndex = 11;
            // 
            // typecombo
            // 
            typecombo.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typecombo.FormattingEnabled = true;
            typecombo.Items.AddRange(new object[] { "Standar", "Deluxe", "Junior Suite" });
            typecombo.Location = new Point(314, 342);
            typecombo.Name = "typecombo";
            typecombo.Size = new Size(287, 34);
            typecombo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(81, 277);
            label7.Name = "label7";
            label7.Size = new Size(151, 26);
            label7.TabIndex = 13;
            label7.Text = "Tanggal Booking :";
            // 
            // pembayarancombo
            // 
            pembayarancombo.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pembayarancombo.FormattingEnabled = true;
            pembayarancombo.Items.AddRange(new object[] { "Cash", "Transfer Bank", "Debit" });
            pembayarancombo.Location = new Point(314, 411);
            pembayarancombo.Name = "pembayarancombo";
            pembayarancombo.Size = new Size(287, 34);
            pembayarancombo.TabIndex = 14;
            // 
            // lamacombo
            // 
            lamacombo.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lamacombo.FormattingEnabled = true;
            lamacombo.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            lamacombo.Location = new Point(314, 471);
            lamacombo.Name = "lamacombo";
            lamacombo.Size = new Size(287, 34);
            lamacombo.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { namapemesan, typekamar, metodepembayaran, lamainap, total });
            dataGridView1.Location = new Point(654, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(816, 352);
            dataGridView1.TabIndex = 16;
            // 
            // namapemesan
            // 
            namapemesan.HeaderText = "Nama Pemesan";
            namapemesan.MinimumWidth = 8;
            namapemesan.Name = "namapemesan";
            namapemesan.Width = 150;
            // 
            // typekamar
            // 
            typekamar.HeaderText = "Type Kamar";
            typekamar.MinimumWidth = 8;
            typekamar.Name = "typekamar";
            typekamar.Width = 150;
            // 
            // metodepembayaran
            // 
            metodepembayaran.HeaderText = "Metode Pembayaran";
            metodepembayaran.MinimumWidth = 8;
            metodepembayaran.Name = "metodepembayaran";
            metodepembayaran.Width = 150;
            // 
            // lamainap
            // 
            lamainap.HeaderText = "Lama Inap";
            lamainap.MinimumWidth = 8;
            lamainap.Name = "lamainap";
            lamainap.Width = 150;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 8;
            total.Name = "total";
            total.Width = 150;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1027, 593);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 17;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1168, 593);
            button2.Name = "button2";
            button2.Size = new Size(112, 48);
            button2.TabIndex = 18;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1305, 593);
            button3.Name = "button3";
            button3.Size = new Size(112, 48);
            button3.TabIndex = 19;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Reservasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1511, 678);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(lamacombo);
            Controls.Add(pembayarancombo);
            Controls.Add(label7);
            Controls.Add(typecombo);
            Controls.Add(dateTimePicker1);
            Controls.Add(totaltext);
            Controls.Add(namatext);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Reservasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox namatext;
        private TextBox totaltext;
        private DateTimePicker dateTimePicker1;
        private ComboBox typecombo;
        private Label label7;
        private ComboBox pembayarancombo;
        private ComboBox lamacombo;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn namapemesan;
        private DataGridViewTextBoxColumn typekamar;
        private DataGridViewTextBoxColumn metodepembayaran;
        private DataGridViewTextBoxColumn lamainap;
        private DataGridViewTextBoxColumn total;
        private Button button2;
        private Button button3;
    }
}