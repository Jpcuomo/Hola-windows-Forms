using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormSaludo : Form
    {
        public FormSaludo()
        {
            InitializeComponent();
        }

        private void FormSaludo_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Text = "¡Hola, Windows Forms!";
        }

        public void EscribirNombreEnSaludo(string nombre, string apellido, FormDatos formDatos)
        {
            this.lblNombreSaludo.Text = $"Soy {nombre} {apellido} y mi materia favorita es {formDatos.Materia}";
        }
    }
}
