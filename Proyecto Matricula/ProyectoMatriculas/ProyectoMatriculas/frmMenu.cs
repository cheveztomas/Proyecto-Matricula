using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMatriculas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frm_Estudiantes FormEstudiantes = new frm_Estudiantes();
            FormEstudiantes.ShowDialog();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmProfesores Profesores = new frmProfesores();
            Profesores.ShowDialog();
        }

        private void Carreras_Click(object sender, EventArgs e)
        {
            frmCarreras Carreras = new frmCarreras();
            Carreras.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmMaterias Materias = new frmMaterias();
            Materias.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
