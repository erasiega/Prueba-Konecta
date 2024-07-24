namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private List<string> palabras = new List<string> { "gato", "perro", "casa", "auto" };
        private string palabraSecreta;
        private char[] palabraAdivinada;
        private int vidas = 5;

        public Form1()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            foreach (var palabra in palabras)
            {
                comboBoxPalabras.Items.Add(palabra);
            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLetra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                char letra = e.KeyCode.ToString().ToLower()[0];
                e.SuppressKeyPress = true;
                ProcesarLetra(letra);
                textBoxLetra.Clear();
            }
        }

        private void ProcesarLetra(char letra)
        {
            if (palabraSecreta.Contains(letra))
            {
                for (int i = 0; i < palabraSecreta.Length; i++)
                {
                    if (palabraSecreta[i] == letra)
                    {
                        palabraAdivinada[i] = letra;
                    }
                }
            }
            else
            {
                vidas--;
            }

            if (vidas <= 0)
            {
                MessageBox.Show($"Perdiste! La palabra era: {palabraSecreta}");
                textBoxLetra.Enabled = false;
            }
            else if (new string(palabraAdivinada) == palabraSecreta)
            {
                MessageBox.Show("¡Felicidades! Adivinaste la palabra.");
                textBoxLetra.Enabled = false;
            }

            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            labelPalabra.Text = new string(palabraAdivinada);
            labelVidas.Text = $"Vidas: {vidas}";
        }

        private void buttonIniciar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxPalabras.SelectedItem != null)
            {
                palabraSecreta = comboBoxPalabras.SelectedItem.ToString();
                palabraAdivinada = new string('_', palabraSecreta.Length).ToCharArray();
                vidas = 5;
                ActualizarPantalla();
                textBoxLetra.Enabled = true;
                textBoxLetra.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione una palabra para empezar el juego.");
            }
        }

        private void textBoxLetra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
