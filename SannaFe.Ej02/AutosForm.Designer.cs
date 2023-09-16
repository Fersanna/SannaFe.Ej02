namespace SannaFe.Ej02
{
    partial class AutosForm
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
            marcaCombo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            modeloText = new TextBox();
            añoText = new TextBox();
            label3 = new Label();
            precioText = new TextBox();
            label4 = new Label();
            aceptarBtn = new Button();
            cancelarBtn = new Button();
            UsuarioText = new Label();
            FechaText = new Label();
            UsuarioTex = new Label();
            SuspendLayout();
            // 
            // marcaCombo
            // 
            marcaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            marcaCombo.FormattingEnabled = true;
            marcaCombo.Items.AddRange(new object[] { "Ford\t", "Fiat ", "Chevrolet", "Audi" });
            marcaCombo.Location = new Point(48, 62);
            marcaCombo.Name = "marcaCombo";
            marcaCombo.Size = new Size(201, 28);
            marcaCombo.TabIndex = 0;
            marcaCombo.SelectedIndexChanged += MarcacomboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Marcas\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 40);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Modelo\r\n";
            label2.Click += label2_Click;
            // 
            // modeloText
            // 
            modeloText.Location = new Point(255, 63);
            modeloText.Name = "modeloText";
            modeloText.Size = new Size(125, 27);
            modeloText.TabIndex = 3;
            modeloText.TextChanged += textBox1_TextChanged;
            // 
            // añoText
            // 
            añoText.Location = new Point(386, 63);
            añoText.Name = "añoText";
            añoText.Size = new Size(125, 27);
            añoText.TabIndex = 5;
            añoText.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 42);
            label3.Name = "label3";
            label3.Size = new Size(36, 40);
            label3.TabIndex = 4;
            label3.Text = "Año\r\n\r\n";
            label3.Click += label3_Click;
            // 
            // precioText
            // 
            precioText.Location = new Point(517, 63);
            precioText.Name = "precioText";
            precioText.Size = new Size(125, 27);
            precioText.TabIndex = 7;
            precioText.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 42);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            label4.Click += label4_Click;
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(448, 146);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(94, 29);
            aceptarBtn.TabIndex = 8;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += button1_Click;
            // 
            // cancelarBtn
            // 
            cancelarBtn.Location = new Point(548, 146);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(94, 29);
            cancelarBtn.TabIndex = 9;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = true;
            cancelarBtn.Click += button2_Click;
            // 
            // UsuarioText
            // 
            UsuarioText.AutoSize = true;
            UsuarioText.Location = new Point(12, 9);
            UsuarioText.Name = "UsuarioText";
            UsuarioText.Size = new Size(0, 20);
            UsuarioText.TabIndex = 10;
            // 
            // FechaText
            // 
            FechaText.Location = new Point(496, 9);
            FechaText.Name = "FechaText";
            FechaText.Size = new Size(177, 20);
            FechaText.TabIndex = 11;
            FechaText.Text = "Fecha";
            FechaText.TextAlign = ContentAlignment.TopRight;
            FechaText.Click += label6_Click;
            // 
            // UsuarioTex
            // 
            UsuarioTex.AutoSize = true;
            UsuarioTex.Location = new Point(18, 9);
            UsuarioTex.Name = "UsuarioTex";
            UsuarioTex.Size = new Size(124, 20);
            UsuarioTex.TabIndex = 12;
            UsuarioTex.Text = "[NombreUsuario]";
            // 
            // AutosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 218);
            Controls.Add(UsuarioTex);
            Controls.Add(FechaText);
            Controls.Add(UsuarioText);
            Controls.Add(cancelarBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(precioText);
            Controls.Add(label4);
            Controls.Add(añoText);
            Controls.Add(label3);
            Controls.Add(modeloText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(marcaCombo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AutosForm";
            Text = "Ejercicio 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox marcaCombo;
        private Label label1;
        private Label label2;
        private TextBox modeloText;
        private TextBox añoText;
        private Label label3;
        private TextBox precioText;
        private Label label4;
        private Button aceptarBtn;
        private Button cancelarBtn;
        private Label UsuarioText;
        private Label FechaText;
        private Label UsuarioTex;
    }
}