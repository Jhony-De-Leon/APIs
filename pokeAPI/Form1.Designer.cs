namespace pokeAPI
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
            lblNombre = new Label();
            textBox1 = new TextBox();
            lblPeso = new Label();
            lblAltura = new Label();
            lblTipo = new Label();
            pictureBox1 = new PictureBox();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            buttonExportar = new Button();
            buttonCatAPI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(33, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(117, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 1;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(33, 112);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(56, 18);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltura.Location = new Point(33, 162);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(77, 18);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(39, 208);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(50, 18);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(363, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 280);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.WhiteSmoke;
            buttonBuscar.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(70, 293);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(86, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.WhiteSmoke;
            buttonLimpiar.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(173, 293);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(81, 23);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonExportar
            // 
            buttonExportar.BackColor = Color.WhiteSmoke;
            buttonExportar.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExportar.Location = new Point(84, 342);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(170, 41);
            buttonExportar.TabIndex = 8;
            buttonExportar.Text = "Exportar Informacion";
            buttonExportar.UseVisualStyleBackColor = false;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // buttonCatAPI
            // 
            buttonCatAPI.BackColor = Color.WhiteSmoke;
            buttonCatAPI.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCatAPI.Location = new Point(496, 363);
            buttonCatAPI.Name = "buttonCatAPI";
            buttonCatAPI.Size = new Size(122, 31);
            buttonCatAPI.TabIndex = 9;
            buttonCatAPI.Text = "The Cat API";
            buttonCatAPI.UseVisualStyleBackColor = false;
            buttonCatAPI.Click += buttonCatAPI_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCatAPI);
            Controls.Add(buttonExportar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(lblTipo);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(textBox1);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox textBox1;
        private Label lblPeso;
        private Label lblAltura;
        private Label lblTipo;
        private PictureBox pictureBox1;
        private Button buttonBuscar;
        private Button buttonLimpiar;
        private Button buttonExportar;
        private Button buttonCatAPI;
    }
}
