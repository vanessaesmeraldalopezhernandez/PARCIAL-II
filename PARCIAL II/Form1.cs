namespace PARCIAL_II
{
    public partial class cmbform : Form
    {
        Persona Objpersona = new Persona();
        int TipoPersona;
        public cmbform()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Objpersona.Nombre = Txtnombre.Text;
            Objpersona.Apellido = Txtapellido.Text;
            Objpersona.Edad = int.Parse(Txtedad.Text);
            Objpersona.Fecha_nacimiento = Txtnacimiento.Text;
            Objpersona.MostrarNombreCompleto();





            MessageBox.Show("nombres:" + Objpersona.Nombre + "\n apellido:" + Objpersona.Apellido +
                "\n edad: " + Objpersona.Edad + "\n fecha_nacimiento: " + Objpersona.Fecha_nacimiento);





        }

        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPersona = this.combotipo.SelectedIndex;
            if (TipoPersona == 0)
            {
                this.panelMaestro.Visible = false;
                this.panelEstudiante.Visible = true;
            }
            else if (TipoPersona == 1)
            {
                this.panelEstudiante.Visible = true;
                this.panelMaestro.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelMaestro.Visible = false;
            this.panelEstudiante.Visible = false;

        }

        private void Txttitulo_TextChanged(object sender, EventArgs e)
        {
            
            
           
        }
    }
}