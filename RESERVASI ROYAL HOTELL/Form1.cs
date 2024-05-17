namespace RESERVASI_ROYAL_HOTELL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usertext.Text == "Nabila" && passwordtext.Text == "1234")
            {
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK);
                this.Hide();
                Reservasi co=new Reservasi();
                co.Show();
            }
            else
            {
                MessageBox.Show("User Name and Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usertext.Text = "";
            passwordtext.Text = "";
        }
    }
}
