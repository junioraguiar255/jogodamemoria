namespace ProjetoJogoMemoria
{
    public partial class TerceiraFase : Form
    {
        private List<Bitmap> images = new List<Bitmap>();
        PictureBox primeiraCarta;
        PictureBox segundaCarta;
        int faltantes = 32;
        public TerceiraFase()
        {
            InitializeComponent();
            ImageManager imageManager = new ImageManager();
            images = imageManager.GetImages();
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
                    this.Text = "Faltam: " + faltantes;

                    if (faltantes == 0)
                    {
                        MessageBox.Show("Parabéns! Você Zerou o game!");

                        var result = MessageBox.Show("Você quer reiniciar o jogo ?", "Reiniciar ou Sair",
                                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Código para reiniciar o jogo
                            PrimeiraFase c = new PrimeiraFase();
                            c.Show();
                            this.Hide();
                            c.Focus();
                        }
                        else if (result == DialogResult.No)
                        {
                            // Código para sair do jogo
                            Application.Exit();
                        }

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
            if (carta == imagem30 || carta == imagem10)
                return images[0];
            else if (carta == imagem17 || carta == imagem14)
                return images[1];
            else if (carta == imagem11 || carta == imagem34)
                return images[2];
            else if (carta == imagem23 || carta == imagem6)
                return images[3];
            else if (carta == imagem22 || carta == imagem16)
                return images[4];
            else if (carta == imagem29 || carta == imagem13)
                return images[5];
            else if (carta == imagem5 || carta == imagem12)
                return images[6];
            else if (carta == imagem28 || carta == imagem15)
                return images[7];
            else if (carta == imagem25 || carta == imagem24)
                return images[8];
            else if (carta == imagem26 || carta == imagem33)
                return images[9];
            else if (carta == imagem27 || carta == imagem2)
                return images[10];
            else if (carta == imagem8 || carta == imagem21)
                return images[11];
            else if (carta == imagem9 || carta == imagem20)
                return images[12];
            else if (carta == imagem1 || carta == imagem19)
                return images[13];
            else if (carta == imagem31 || carta == imagem18)
                return images[14];
            else if (carta == imagem32 || carta == imagem7)
                return images[15];
            else if (carta == imagem3 || carta == imagem35)
                return images[16];
            else if (carta == imagem36 || carta == imagem4)
                return images[17];
            else if (carta == imagem37 || carta == imagem42)
                return images[18];
            else if (carta == imagem46 || carta == imagem40)
                return images[19];
            else if (carta == imagem41 || carta == imagem38)
                return images[20];
            else if (carta == imagem43 || carta == imagem54)
                return images[21];
            else if (carta == imagem45 || carta == imagem39)
                return images[22];
            else if (carta == imagem51 || carta == imagem48)
                return images[23];
            else if (carta == imagem49 || carta == imagem50)
                return images[24];
            else if (carta == imagem47 || carta == imagem52)
                return images[25];
            else if (carta == imagem53 || carta == imagem44)
                return images[26];
            else if (carta == imagem62 || carta == imagem56)
                return images[27];
            else if (carta == imagem57 || carta == imagem58)
                return images[28];
            else if (carta == imagem63 || carta == imagem60)
                return images[29];
            else if (carta == imagem61 || carta == imagem55)
                return images[30];
            else if (carta == imagem59 || carta == imagem64)
                return images[31];
            else
                return null;
        }

    }
}
