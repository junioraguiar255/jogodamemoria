namespace ProjetoJogoMemoria
{
    public partial class PrimeiraFase : Form
    {
        private List<Bitmap> images = new List<Bitmap>();
        PictureBox primeiraCarta;
        PictureBox segundaCarta;
        int faltantes = 8;
        public PrimeiraFase()
        {
            InitializeComponent();
            ImageManager imageManager = new ImageManager();
            images = imageManager.GetImages();
            ajustar();
        }

        public void ajustar()
        {
            imagem1.Image = Properties.Resources.baralho;
            imagem2.Image = Properties.Resources.baralho;
            imagem3.Image = Properties.Resources.baralho;
            imagem4.Image = Properties.Resources.baralho;
        }

        // Este método é chamado quando um cartão é clicado
        private void Carta_Click(object sender, EventArgs e)
        {
            PictureBox cartaClicada = sender as PictureBox;

            if (cartaClicada == null)
                return;

            if (primeiraCarta == null) // Se não houver nenhuma carta virada
            {
                primeiraCarta = cartaClicada;
                cartaClicada.Image = ObterImagemDaCarta(cartaClicada); // Vira a carta clicada
            }
            else if (segundaCarta == null) // Se houver uma carta virada
            {
                segundaCarta = cartaClicada;
                cartaClicada.Image = ObterImagemDaCarta(cartaClicada); // Vira a carta clicada

                VerificarPar(); // Verifica se as cartas formam um par
            }
        }

        private void VerificarPar()
        {
            if (primeiraCarta.Image.Tag == null || segundaCarta.Image.Tag == null)
            {
                MessageBox.Show("Problema de configuracao do projeto!"); // Mostra uma mensagem de falha
            }
            else
            {


                if (primeiraCarta.Image.Tag == segundaCarta.Image.Tag) // Se as imagens das cartas forem iguais
                {
                    MessageBox.Show("Você encontrou um par!"); // Mostra uma mensagem de sucesso


                    primeiraCarta.Enabled = false;
                    segundaCarta.Enabled = false;
                    // Reseta as cartas
                    primeiraCarta = null;
                    segundaCarta = null;
                    faltantes--;
                    txtResultado.Text = "Faltam: " + faltantes;

                    if (faltantes == 0)
                    {
                        MessageBox.Show("Parabéns! Você passou de fase");
                        SegundaFase c = new SegundaFase();
                        c.Show();
                        this.Hide();
                        c.Focus();
                    }


                    return;
                }
            }
            {
                //MessageBox.Show("Tente novamente!"); // Mostra uma mensagem de falha

                // Volta as cartas para a imagem de fundo após um pequeno atraso
                Task.Delay(1000).ContinueWith(_ =>
                {
                    primeiraCarta.Image = Properties.Resources.baralho;
                    segundaCarta.Image = Properties.Resources.baralho;

                    primeiraCarta = null;
                    segundaCarta = null;
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        // Este método retorna a imagem da carta com base na PictureBox clicada
        private Image ObterImagemDaCarta(PictureBox carta)
        {
            if (carta == imagem1 || carta == imagem10)
                return images[0];
            else if (carta == imagem7 || carta == imagem14)
                return images[1];
            else if (carta == imagem11 || carta == imagem4)
                return images[2];
            else if (carta == imagem3 || carta == imagem6)
                return images[3];
            else if (carta == imagem2 || carta == imagem16)
                return images[4];
            else if (carta == imagem9 || carta == imagem13)
                return images[5];
            else if (carta == imagem5 || carta == imagem12)
                return images[6];
            else if (carta == imagem8 || carta == imagem15)
                return images[7];
            else
                return null;
        }




    }
}
