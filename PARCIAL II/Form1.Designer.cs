namespace PARCIAL_II
{
    partial class cmbform
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
            panel1 = new Panel();
            btnMostrar = new Button();
            combotipo = new ComboBox();
            label14 = new Label();
            Txtnacimiento = new TextBox();
            label7 = new Label();
            Txtedad = new TextBox();
            label6 = new Label();
            Txtapellido = new TextBox();
            label5 = new Label();
            Txtnombre = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panelMaestro = new Panel();
            Txttitulo = new TextBox();
            TxtCAsignada = new TextBox();
            Txtsalario = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            panelEstudiante = new Panel();
            Txtcarrera = new TextBox();
            Txtcum = new TextBox();
            label13 = new Label();
            label12 = new Label();
            Txtciclo = new TextBox();
            label8 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panelMaestro.SuspendLayout();
            panelEstudiante.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(btnMostrar);
            panel1.Controls.Add(combotipo);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(Txtnacimiento);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Txtedad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Txtapellido);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Txtnombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 352);
            panel1.TabIndex = 26;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(96, 303);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(125, 27);
            btnMostrar.TabIndex = 25;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // combotipo
            // 
            combotipo.FormattingEnabled = true;
            combotipo.Items.AddRange(new object[] { "Maestro", "Estudiante" });
            combotipo.Location = new Point(121, 242);
            combotipo.Name = "combotipo";
            combotipo.Size = new Size(126, 23);
            combotipo.TabIndex = 24;
            combotipo.SelectedIndexChanged += combotipo_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(255, 224, 192);
            label14.Location = new Point(14, 245);
            label14.Name = "label14";
            label14.Size = new Size(91, 15);
            label14.TabIndex = 23;
            label14.Text = "Tipo de Persona";
            // 
            // Txtnacimiento
            // 
            Txtnacimiento.Location = new Point(121, 132);
            Txtnacimiento.Name = "Txtnacimiento";
            Txtnacimiento.Size = new Size(123, 23);
            Txtnacimiento.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(14, 114);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 9;
            label7.Text = "Fecha de nacimiento";
            // 
            // Txtedad
            // 
            Txtedad.Location = new Point(120, 181);
            Txtedad.Name = "Txtedad";
            Txtedad.Size = new Size(122, 23);
            Txtedad.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 224, 192);
            label6.Location = new Point(14, 189);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 7;
            label6.Text = "Edad";
            // 
            // Txtapellido
            // 
            Txtapellido.Location = new Point(121, 69);
            Txtapellido.Name = "Txtapellido";
            Txtapellido.Size = new Size(123, 23);
            Txtapellido.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(14, 69);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "Apellido";
            // 
            // Txtnombre
            // 
            Txtnombre.Location = new Point(121, 23);
            Txtnombre.Name = "Txtnombre";
            Txtnombre.Size = new Size(123, 23);
            Txtnombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(14, 26);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Persona";
            // 
            // panelMaestro
            // 
            panelMaestro.BackColor = Color.FromArgb(255, 192, 128);
            panelMaestro.Controls.Add(Txttitulo);
            panelMaestro.Controls.Add(TxtCAsignada);
            panelMaestro.Controls.Add(Txtsalario);
            panelMaestro.Controls.Add(label11);
            panelMaestro.Controls.Add(label10);
            panelMaestro.Controls.Add(label9);
            panelMaestro.Controls.Add(label2);
            panelMaestro.Location = new Point(338, 24);
            panelMaestro.Name = "panelMaestro";
            panelMaestro.Size = new Size(221, 282);
            panelMaestro.TabIndex = 27;
            // 
            // Txttitulo
            // 
            Txttitulo.Location = new Point(67, 42);
            Txttitulo.Name = "Txttitulo";
            Txttitulo.Size = new Size(123, 23);
            Txttitulo.TabIndex = 18;
            Txttitulo.TextChanged += Txttitulo_TextChanged;
            // 
            // TxtCAsignada
            // 
            TxtCAsignada.Location = new Point(67, 147);
            TxtCAsignada.Name = "TxtCAsignada";
            TxtCAsignada.Size = new Size(123, 23);
            TxtCAsignada.TabIndex = 17;
            // 
            // Txtsalario
            // 
            Txtsalario.Location = new Point(67, 229);
            Txtsalario.Name = "Txtsalario";
            Txtsalario.Size = new Size(123, 23);
            Txtsalario.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 224, 192);
            label11.Location = new Point(8, 50);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 14;
            label11.Text = "Titulo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 224, 192);
            label10.Location = new Point(8, 120);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 13;
            label10.Text = "Carrera asignada ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 224, 192);
            label9.Location = new Point(8, 232);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 12;
            label9.Text = "Salario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 17);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Maestro";
            // 
            // panelEstudiante
            // 
            panelEstudiante.Controls.Add(Txtcarrera);
            panelEstudiante.Controls.Add(Txtcum);
            panelEstudiante.Controls.Add(label13);
            panelEstudiante.Controls.Add(label12);
            panelEstudiante.Controls.Add(Txtciclo);
            panelEstudiante.Controls.Add(label8);
            panelEstudiante.Controls.Add(label3);
            panelEstudiante.Location = new Point(565, 24);
            panelEstudiante.Name = "panelEstudiante";
            panelEstudiante.Size = new Size(223, 282);
            panelEstudiante.TabIndex = 28;
            // 
            // Txtcarrera
            // 
            Txtcarrera.Location = new Point(81, 240);
            Txtcarrera.Name = "Txtcarrera";
            Txtcarrera.Size = new Size(123, 23);
            Txtcarrera.TabIndex = 22;
            // 
            // Txtcum
            // 
            Txtcum.Location = new Point(81, 60);
            Txtcum.Name = "Txtcum";
            Txtcum.Size = new Size(123, 23);
            Txtcum.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 224, 192);
            label13.Location = new Point(23, 147);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 20;
            label13.Text = "Cum";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(255, 224, 192);
            label12.Location = new Point(11, 241);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 19;
            label12.Text = "Carrera";
            // 
            // Txtciclo
            // 
            Txtciclo.Location = new Point(81, 147);
            Txtciclo.Name = "Txtciclo";
            Txtciclo.Size = new Size(123, 23);
            Txtciclo.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 224, 192);
            label8.Location = new Point(22, 60);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 11;
            label8.Text = "Ciclo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 17);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Estudiante";
            // 
            // cmbform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panelEstudiante);
            Controls.Add(panelMaestro);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(0, 64, 0);
            Name = "cmbform";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMaestro.ResumeLayout(false);
            panelMaestro.PerformLayout();
            panelEstudiante.ResumeLayout(false);
            panelEstudiante.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMostrar;
        private ComboBox combotipo;
        private Label label14;
        private TextBox Txtnacimiento;
        private Label label7;
        private TextBox Txtedad;
        private Label label6;
        private TextBox Txtapellido;
        private Label label5;
        private TextBox Txtnombre;
        private Label label4;
        private Label label1;
        private Panel panelMaestro;
        private TextBox Txttitulo;
        private TextBox TxtCAsignada;
        private TextBox Txtsalario;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label2;
        private Panel panelEstudiante;
        private TextBox Txtcarrera;
        private TextBox Txtcum;
        private Label label13;
        private Label label12;
        private TextBox Txtciclo;
        private Label label8;
        private Label label3;
    }
}