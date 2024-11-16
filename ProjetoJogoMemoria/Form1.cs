namespace ProjetoJogoMemoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrimeiraFase primeiraFase = new PrimeiraFase();
            this.Hide();
            primeiraFase.Show();
            primeiraFase.Focus();
        }
    }
}