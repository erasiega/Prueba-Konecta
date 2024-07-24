namespace ejercicio3
{
    public partial class Form1 : Form
    {
        private string basePath = @"C:\Kosmos";
        private string[] categorias = { "Marketing", "Ventas", "Compras", "Métricas" };

        public Form1()
        {
            InitializeComponent();
            CrearEstructuraDirectorio();
        }

        private void CrearEstructuraDirectorio()
        {
            Directory.CreateDirectory(basePath);
            foreach (var categoria in categorias)
            {
                var path = Path.Combine(basePath, categoria);
                Directory.CreateDirectory(path);
                for (int i = 1; i <= 2; i++)
                {
                    File.WriteAllText(Path.Combine(path, $"informe{i}.txt"), $"Contenido del informe {i} de {categoria}");
                }
            }
        }

        private void buttonCalcularComision_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            if (float.TryParse(textBoxVentas.Text, out float ventas))
            {
                float comision = ventas * 0.20f;
                labelResultado.Text = $"{nombre}, tu comisión es: {comision:C}";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un monto de ventas válido.");
            }
        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            if (radioButtonLeer.Checked)
            {
                LeerInforme();
            }
            else if (radioButtonCrearInforme.Checked)
            {
                CrearInforme();
            }
            else if (radioButtonCrearCategoria.Checked)
            {
                CrearCategoria();
            }
            else if (radioButtonEliminarInforme.Checked)
            {
                EliminarInforme();
            }
            else if (radioButtonEliminarCategoria.Checked)
            {
                EliminarCategoria();
            }
            else if (radioButtonSalir.Checked)
            {
                Application.Exit();
            }
        }

        private void LeerInforme()
        {
            string categoria = SeleccionarCategoria();
            if (categoria != null)
            {
                string informe = SeleccionarInforme(categoria);
                if (informe != null)
                {
                    string contenido = File.ReadAllText(informe);
                    MessageBox.Show(contenido, "Contenido del Informe");
                }
            }
        }

        private void CrearInforme()
        {
            string categoria = SeleccionarCategoria();
            if (categoria != null)
            {
                string nombreInforme = Prompt.ShowDialog("Nombre del informe:", "Crear Informe");
                string contenido = Prompt.ShowDialog("Contenido del informe:", "Crear Informe");
                File.WriteAllText(Path.Combine(categoria, nombreInforme + ".txt"), contenido);
                MessageBox.Show("Informe creado exitosamente.");
            }
        }

        private void CrearCategoria()
        {
            string nuevaCategoria = Prompt.ShowDialog("Nombre de la nueva categoría:", "Crear Categoría");
            Directory.CreateDirectory(Path.Combine(basePath, nuevaCategoria));
            MessageBox.Show("Categoría creada exitosamente.");
        }

        private void EliminarInforme()
        {
            string categoria = SeleccionarCategoria();
            if (categoria != null)
            {
                string informe = SeleccionarInforme(categoria);
                if (informe != null)
                {
                    File.Delete(informe);
                    MessageBox.Show("Informe eliminado exitosamente.");
                }
            }
        }

        private void EliminarCategoria()
        {
            string categoria = SeleccionarCategoria();
            if (categoria != null)
            {
                Directory.Delete(categoria, true);
                MessageBox.Show("Categoría eliminada exitosamente.");
            }
        }

        private string SeleccionarCategoria()
        {
            using (var form = new Form())
            {
                form.Text = "Seleccionar Categoría";
                var listBox = new ListBox { Dock = DockStyle.Fill };
                listBox.Items.AddRange(Directory.GetDirectories(basePath).Select(Path.GetFileName).ToArray());
                form.Controls.Add(listBox);
                form.ShowDialog();
                return listBox.SelectedItem != null ? Path.Combine(basePath, listBox.SelectedItem.ToString()) : null;
            }
        }

        private string SeleccionarInforme(string categoria)
        {
            using (var form = new Form())
            {
                form.Text = "Seleccionar Informe";
                var listBox = new ListBox { Dock = DockStyle.Fill };
                listBox.Items.AddRange(Directory.GetFiles(categoria).Select(Path.GetFileName).ToArray());
                form.Controls.Add(listBox);
                form.ShowDialog();
                return listBox.SelectedItem != null ? Path.Combine(categoria, listBox.SelectedItem.ToString()) : null;
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form
            {
                Width = 500,
                Height = 150,
                Text = caption
            };
            Label textLabel = new Label { Left = 50, Top = 20, Text = text, Width = 400 };
            TextBox textBox = new TextBox { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
