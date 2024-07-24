namespace Ejercicio2
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
            buttonIniciar = new Button();
            labelVidas = new Label();
            labelPalabra = new Label();
            comboBoxPalabras = new ComboBox();
            textBoxLetra = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(299, 107);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(75, 23);
            buttonIniciar.TabIndex = 0;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click_1;
            // 
            // labelVidas
            // 
            labelVidas.AutoSize = true;
            labelVidas.Location = new Point(308, 21);
            labelVidas.Name = "labelVidas";
            labelVidas.Size = new Size(38, 15);
            labelVidas.TabIndex = 1;
            labelVidas.Text = "Vidas:";
            // 
            // labelPalabra
            // 
            labelPalabra.AutoSize = true;
            labelPalabra.Location = new Point(308, 58);
            labelPalabra.Name = "labelPalabra";
            labelPalabra.Size = new Size(27, 15);
            labelPalabra.TabIndex = 2;
            labelPalabra.Text = "____";
            // 
            // comboBoxPalabras
            // 
            comboBoxPalabras.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxPalabras.FormattingEnabled = true;
            comboBoxPalabras.Location = new Point(132, 18);
            comboBoxPalabras.Name = "comboBoxPalabras";
            comboBoxPalabras.Size = new Size(121, 24);
            comboBoxPalabras.TabIndex = 3;
            comboBoxPalabras.DrawItem += comboBoxPalabras_DrawItem;
            comboBoxPalabras.DropDown += comboBoxPalabras_DropDown;
            // 
            // textBoxLetra
            // 
            textBoxLetra.Location = new Point(132, 55);
            textBoxLetra.Name = "textBoxLetra";
            textBoxLetra.Size = new Size(121, 23);
            textBoxLetra.TabIndex = 4;
            textBoxLetra.KeyDown += textBoxLetra_KeyDown;
            textBoxLetra.KeyPress += textBoxLetra_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 5;
            label1.Text = "Palabras Secreta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 142);
            Controls.Add(label1);
            Controls.Add(textBoxLetra);
            Controls.Add(comboBoxPalabras);
            Controls.Add(labelPalabra);
            Controls.Add(labelVidas);
            Controls.Add(buttonIniciar);
            Name = "Form1";
            Text = "Palabra Secreta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIniciar;
        private Label labelVidas;
        private Label labelPalabra;
        private ComboBox comboBoxPalabras;
        private TextBox textBoxLetra;
        private Label label1;
    }
}
