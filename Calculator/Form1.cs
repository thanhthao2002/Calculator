namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            if (txtA.Text != String.Empty)
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                ketQua = a + b;
                txtKetQua.Text = ketQua.ToString(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketQua = a - b;
            txtKetQua.Text = ketQua.ToString();
        }
    }
}