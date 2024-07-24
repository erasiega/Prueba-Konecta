namespace ejercicio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxVentas = new TextBox();
            labelResultado = new Label();
            groupBox1 = new GroupBox();
            radioButtonSalir = new RadioButton();
            radioButtonEliminarCategoria = new RadioButton();
            radioButtonEliminarInforme = new RadioButton();
            radioButtonCrearCategoria = new RadioButton();
            radioButtonCrearInforme = new RadioButton();
            radioButtonLeer = new RadioButton();
            buttonEjecutar = new Button();
            buttonCalcularComision = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(280, 32);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxVentas
            // 
            textBoxVentas.Location = new Point(286, 91);
            textBoxVentas.Name = "textBoxVentas";
            textBoxVentas.Size = new Size(100, 23);
            textBoxVentas.TabIndex = 1;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(321, 183);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(84, 15);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "labelResultado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonSalir);
            groupBox1.Controls.Add(radioButtonEliminarCategoria);
            groupBox1.Controls.Add(radioButtonEliminarInforme);
            groupBox1.Controls.Add(radioButtonCrearCategoria);
            groupBox1.Controls.Add(radioButtonCrearInforme);
            groupBox1.Controls.Add(radioButtonLeer);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 211);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acción a Realizar ";
            // 
            // radioButtonSalir
            // 
            radioButtonSalir.AutoSize = true;
            radioButtonSalir.Location = new Point(22, 184);
            radioButtonSalir.Name = "radioButtonSalir";
            radioButtonSalir.Size = new Size(47, 19);
            radioButtonSalir.TabIndex = 5;
            radioButtonSalir.TabStop = true;
            radioButtonSalir.Text = "Salir";
            radioButtonSalir.UseVisualStyleBackColor = true;
            // 
            // radioButtonEliminarCategoria
            // 
            radioButtonEliminarCategoria.AutoSize = true;
            radioButtonEliminarCategoria.Location = new Point(22, 153);
            radioButtonEliminarCategoria.Name = "radioButtonEliminarCategoria";
            radioButtonEliminarCategoria.Size = new Size(122, 19);
            radioButtonEliminarCategoria.TabIndex = 4;
            radioButtonEliminarCategoria.TabStop = true;
            radioButtonEliminarCategoria.Text = "Eliminar Categoria";
            radioButtonEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // radioButtonEliminarInforme
            // 
            radioButtonEliminarInforme.AutoSize = true;
            radioButtonEliminarInforme.Location = new Point(22, 122);
            radioButtonEliminarInforme.Name = "radioButtonEliminarInforme";
            radioButtonEliminarInforme.Size = new Size(113, 19);
            radioButtonEliminarInforme.TabIndex = 3;
            radioButtonEliminarInforme.TabStop = true;
            radioButtonEliminarInforme.Text = "Eliminar Informe";
            radioButtonEliminarInforme.UseVisualStyleBackColor = true;
            // 
            // radioButtonCrearCategoria
            // 
            radioButtonCrearCategoria.AutoSize = true;
            radioButtonCrearCategoria.Location = new Point(22, 91);
            radioButtonCrearCategoria.Name = "radioButtonCrearCategoria";
            radioButtonCrearCategoria.Size = new Size(107, 19);
            radioButtonCrearCategoria.TabIndex = 2;
            radioButtonCrearCategoria.TabStop = true;
            radioButtonCrearCategoria.Text = "Crear Categoria";
            radioButtonCrearCategoria.UseVisualStyleBackColor = true;
            // 
            // radioButtonCrearInforme
            // 
            radioButtonCrearInforme.AutoSize = true;
            radioButtonCrearInforme.Location = new Point(22, 60);
            radioButtonCrearInforme.Name = "radioButtonCrearInforme";
            radioButtonCrearInforme.Size = new Size(98, 19);
            radioButtonCrearInforme.TabIndex = 1;
            radioButtonCrearInforme.TabStop = true;
            radioButtonCrearInforme.Text = "Crear Informe";
            radioButtonCrearInforme.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeer
            // 
            radioButtonLeer.AutoSize = true;
            radioButtonLeer.Location = new Point(22, 29);
            radioButtonLeer.Name = "radioButtonLeer";
            radioButtonLeer.Size = new Size(47, 19);
            radioButtonLeer.TabIndex = 0;
            radioButtonLeer.TabStop = true;
            radioButtonLeer.Text = "Leer";
            radioButtonLeer.UseVisualStyleBackColor = true;
            // 
            // buttonEjecutar
            // 
            buttonEjecutar.Location = new Point(92, 229);
            buttonEjecutar.Name = "buttonEjecutar";
            buttonEjecutar.Size = new Size(75, 23);
            buttonEjecutar.TabIndex = 4;
            buttonEjecutar.Text = "Ejecutar";
            buttonEjecutar.UseVisualStyleBackColor = true;
            buttonEjecutar.Click += buttonEjecutar_Click;
            // 
            // buttonCalcularComision
            // 
            buttonCalcularComision.Location = new Point(446, 251);
            buttonCalcularComision.Name = "buttonCalcularComision";
            buttonCalcularComision.Size = new Size(75, 23);
            buttonCalcularComision.TabIndex = 5;
            buttonCalcularComision.Text = "Calcular";
            buttonCalcularComision.UseVisualStyleBackColor = true;
            buttonCalcularComision.Click += buttonCalcularComision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalcularComision);
            Controls.Add(buttonEjecutar);
            Controls.Add(groupBox1);
            Controls.Add(labelResultado);
            Controls.Add(textBoxVentas);
            Controls.Add(textBoxNombre);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxVentas;
        private Label labelResultado;
        private GroupBox groupBox1;
        private RadioButton radioButtonLeer;
        private RadioButton radioButtonCrearInforme;
        private RadioButton radioButtonCrearCategoria;
        private RadioButton radioButtonEliminarInforme;
        private RadioButton radioButtonEliminarCategoria;
        private RadioButton radioButtonSalir;
        private Button buttonEjecutar;
        private Button buttonCalcularComision;
    }
}
