namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del vendedor y el valor de la venta
            string nombre = textBoxNombre.Text;
            string ventaStr = textBoxVenta.Text;

            // Convertir el valor de la venta a un float
            if (float.TryParse(ventaStr, out float venta))
            {
                // Calcular la comisión
                float comision = venta * 0.20f;

                // Mostrar el resultado en el label
                labelResultado.Text = $"{nombre}, su comisión de este mes es de {comision.ToString("C")}";
            }
            else
            {
                // Mostrar un mensaje de error si el valor de la venta no es válido
                MessageBox.Show("Por favor, ingrese un número válido para las ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
