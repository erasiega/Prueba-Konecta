namespace Ejercicio1
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
            Calcular = new Button();
            textBoxNombre = new TextBox();
            textBoxVenta = new TextBox();
            labelResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(322, 93);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 0;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += button1_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(12, 39);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(210, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxVenta
            // 
            textBoxVenta.Location = new Point(283, 39);
            textBoxVenta.Name = "textBoxVenta";
            textBoxVenta.Size = new Size(114, 23);
            textBoxVenta.TabIndex = 2;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(12, 74);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(10, 15);
            labelResultado.TabIndex = 3;
            labelResultado.Text = " ";
            labelResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(283, 15);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 5;
            label2.Text = "Ventas Totales";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 123);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelResultado);
            Controls.Add(textBoxVenta);
            Controls.Add(textBoxNombre);
            Controls.Add(Calcular);
            Name = "Form1";
            Text = "Ejercicio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calcular;
        private TextBox textBoxNombre;
        private TextBox textBoxVenta;
        private Label labelResultado;
        private Label label1;
        private Label label2;
    }
}
