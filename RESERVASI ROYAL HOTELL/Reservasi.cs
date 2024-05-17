using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESERVASI_ROYAL_HOTELL
{
    public partial class Reservasi : Form
    {
        public Reservasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (typecombo.SelectedItem.ToString() == "Standar")
            {
                if (pembayarancombo.SelectedItem.ToString() == "Cash")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 500000).ToString();
                }
                if (pembayarancombo.SelectedItem.ToString() == "Transfer Bank")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 500000).ToString();
                }
                if (pembayarancombo.SelectedItem.ToString() == "Debit")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 500000).ToString();
                }
                dataGridView1.Rows.Add(namatext.Text, typecombo.Text, pembayarancombo.Text, lamacombo.Text, totaltext.Text);
            }
            if (typecombo.SelectedItem.ToString() == "Deluxe")
            {
                if (pembayarancombo.SelectedItem.ToString() == "Cash")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 850000).ToString();
                }
                if (pembayarancombo.SelectedItem.ToString() == "Transfer Bank")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 850000).ToString();
                }
                if (pembayarancombo.SelectedItem.ToString() == "Debit")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 850000).ToString();
                }
                dataGridView1.Rows.Add(namatext.Text, typecombo.Text, pembayarancombo.Text, lamacombo.Text, totaltext.Text);
            }
            if (typecombo.SelectedItem.ToString() == "Junior Suite")
            {
                if (pembayarancombo.SelectedItem.ToString() == "Cash")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 1500000).ToString();
                }
                if (pembayarancombo.SelectedItem.ToString() == "Transfer Bank")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 1500000).ToString();
                }
                if (pembayarancombo.SelectedItem.ToString() == "Debit")
                {
                    totaltext.Text = (float.Parse(lamacombo.Text) * 1500000).ToString();
                }
                dataGridView1.Rows.Add(namatext.Text, typecombo.Text, pembayarancombo.Text, lamacombo.Text, totaltext.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            namatext.Text = "";
            typecombo.Text = "";
            pembayarancombo.Text = "";
            lamacombo.Text = "";
            totaltext.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
