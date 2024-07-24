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
            SuspendLayout();
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(271, 177);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(75, 23);
            buttonIniciar.TabIndex = 0;
            buttonIniciar.Text = "button1";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click_1;
            // 
            // labelVidas
            // 
            labelVidas.AutoSize = true;
            labelVidas.Location = new Point(400, 58);
            labelVidas.Name = "labelVidas";
            labelVidas.Size = new Size(38, 15);
            labelVidas.TabIndex = 1;
            labelVidas.Text = "label1";
            // 
            // labelPalabra
            // 
            labelPalabra.AutoSize = true;
            labelPalabra.Location = new Point(504, 164);
            labelPalabra.Name = "labelPalabra";
            labelPalabra.Size = new Size(38, 15);
            labelPalabra.TabIndex = 2;
            labelPalabra.Text = "label2";
            // 
            // comboBoxPalabras
            // 
            comboBoxPalabras.FormattingEnabled = true;
            comboBoxPalabras.Location = new Point(128, 102);
            comboBoxPalabras.Name = "comboBoxPalabras";
            comboBoxPalabras.Size = new Size(121, 23);
            comboBoxPalabras.TabIndex = 3;
            // 
            // textBoxLetra
            // 
            textBoxLetra.Location = new Point(294, 18);
            textBoxLetra.Name = "textBoxLetra";
            textBoxLetra.Size = new Size(100, 23);
            textBoxLetra.TabIndex = 4;
            textBoxLetra.KeyDown += textBoxLetra_KeyDown;
            textBoxLetra.KeyPress += textBoxLetra_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxLetra);
            Controls.Add(comboBoxPalabras);
            Controls.Add(labelPalabra);
            Controls.Add(labelVidas);
            Controls.Add(buttonIniciar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIniciar;
        private Label labelVidas;
        private Label labelPalabra;
        private ComboBox comboBoxPalabras;
        private TextBox textBoxLetra;
    }
}
