using Biblioteca;
using Forms;
using System.Runtime.CompilerServices;
using System.Text;

namespace Forms
{
    public partial class FormDatos : Form
    {
        public string Materia { get; set; }


        public FormDatos()
        {
            InitializeComponent();
        }


        private void btnSaludar_Click(object sender, EventArgs e)
        {
            bool showSb = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se deben completar los siguientes campos:");

            if (!Validador.ValidarNombre(this.tbNombre.Text) && !Validador.ValidarNombre(this.tbApellido.Text))
            {
                sb.AppendLine(lblNombre.Text);
                sb.AppendLine(lblApellido.Text);
            }
            else if (!Validador.ValidarNombre(this.tbNombre.Text))
            {
                sb.AppendLine(lblNombre.Text);
            }
            else if (!Validador.ValidarNombre(this.tbApellido.Text))
            {
                sb.AppendLine(lblApellido.Text);
            }
            else
            {
                showSb = false;
                int indice = cbx_materias.SelectedIndex;
                Materia = (indice >= 0) ? cbx_materias.Items[indice].ToString() : "Error en la materia seleccionada";

                //Muestro form saludar
                using (FormSaludo formSaludo = new FormSaludo()) // Libero meoria al no utilizar más el formulario
                {
                    formSaludo.EscribirNombreEnSaludo(this.tbNombre.Text, this.tbApellido.Text, this);
                    formSaludo.ShowDialog();
                }
            }

            if (showSb)
            {
                string mensaje = sb.ToString().Trim();
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            cbx_materias.Items.Add("Programación II");
            cbx_materias.Items.Add("Arq. de S.O.");
            cbx_materias.Items.Add("Estadísticas");
            cbx_materias.Items.Add("Matemáticas");

            // Establece la primera materia como opción seleccionada por defecto
            cbx_materias.SelectedIndex = 0;

            // Configura el ComboBox para no permitir el ingreso de nuevas opciones
            //cbx_materias.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
