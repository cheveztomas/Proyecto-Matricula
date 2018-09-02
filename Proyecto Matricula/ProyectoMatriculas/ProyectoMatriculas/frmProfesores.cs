using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using EntidadesMatricula;

namespace ProyectoMatriculas
{
    public partial class frmProfesores : Form
    {
        public frmProfesores()
        {
            InitializeComponent();
        }

        public void CargarDatos(string pvc_Condicion = "")
        {
            //Variables
            ClsLogicaProfesor vlo_LogicaProfesor = new ClsLogicaProfesor();
            DataSet vlo_DS;
            try
            {
                //Se guarda en una variable data set el resultado de la base de datos.
                vlo_DS = vlo_LogicaProfesor.ListaProfesores(pvc_Condicion);
                //Se verifica si el dataset contiene datos.
                if (vlo_DS.Tables[0].Rows.Count >= 0)
                {
                    //Se alamcenan los datos en el gridview.
                    grdLista.AutoGenerateColumns = false;
                    grdLista.DataSource = vlo_DS;
                    grdLista.DataMember = vlo_DS.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Limpiar()
        {
            try
            {
                //Se establecen todos los valores en vacio.
                txtAACorreo.Text = string.Empty;
                txtAAIdentificacion.Text = string.Empty;
                txtAANombre.Text = string.Empty;
                txtAAPrimerApellido.Text = string.Empty;
                txtAASegundoApellido.Text = string.Empty;
                txtAATelefono.Text = string.Empty;
                txtBuscarIdentificacion.Text = string.Empty;
                txtBuscarNombre.Text = string.Empty;
                CargarDatos();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void AgregarActualizar()
        {
            //Variables
            int vln_resultado;
            ClsEntidadesProfesores vlo_EntidadProfesor = new ClsEntidadesProfesores();
            ClsLogicaProfesor vlo_LogicaProfesor = new ClsLogicaProfesor();
            try
            {
                //Se guardan los valores de la bentana en la clase de profesor.
                vlo_EntidadProfesor.Correo = txtAACorreo.Text;
                vlo_EntidadProfesor.Identificacion = txtAAIdentificacion.Text;
                vlo_EntidadProfesor.Nombre = txtAANombre.Text;
                vlo_EntidadProfesor.PrimerApellido = txtAAPrimerApellido.Text;
                vlo_EntidadProfesor.SegundoApellido = txtAASegundoApellido.Text;
                vlo_EntidadProfesor.Telefono = txtAATelefono.Text;
                //Se llama a la funcion en la capa de logica para actualice o inserte un estudiante.
                vln_resultado = vlo_LogicaProfesor.InsertarActualizarProfesor(vlo_EntidadProfesor);

                //se verifica si se realizó el cambio sugerido.
                if (vln_resultado > 0)
                {
                    MessageBox.Show("Operación realizada de forma correcta.");
                }
                else
                {
                    MessageBox.Show("La operción no realizó ningún cambio.");
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void CargarRegistro(string pvc_Cedula)
        {
            //Se establese una variable entidadprofesor
            ClsEntidadesProfesores vlo_EntidadProfesor = new ClsEntidadesProfesores();
            //Se instancia la logica de profesor
            ClsLogicaProfesor vlo_LigicaProfesor = new ClsLogicaProfesor();
            string vlc_Condicion;
            //Se establece la condición que debe cumplir.
            vlc_Condicion = string.Format("ID_PROFESOR='{0}'", pvc_Cedula);
            try
            {
                //Se invoca la función de obtener un registro.
                vlo_EntidadProfesor = vlo_LigicaProfesor.ObtenerRegistro(vlc_Condicion);

                //Se verifaca la existencai del registro.
                if (vlo_EntidadProfesor.Existe == true)
                {
                    //Se muestranlos valores.
                    txtAAIdentificacion.Tag = vlo_EntidadProfesor.CodProfesor;
                    txtAACorreo.Text = vlo_EntidadProfesor.Correo;
                    txtAAIdentificacion.Text = vlo_EntidadProfesor.Identificacion;
                    txtAANombre.Text = vlo_EntidadProfesor.Nombre;
                    txtAAPrimerApellido.Text = vlo_EntidadProfesor.PrimerApellido;
                    txtAASegundoApellido.Text = vlo_EntidadProfesor.SegundoApellido;
                    txtAATelefono.Text = vlo_EntidadProfesor.Telefono;
                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void Buscar()
        {
            //Variables
            string vlc_Condicion;
            try
            {
                //Se verifica si en los cuadros de testo de busque se encuentra algo.
                if (!string.IsNullOrEmpty(txtBuscarIdentificacion.Text) || !string.IsNullOrEmpty(txtBuscarNombre.Text))
                {
                    //Se establece la condición para buscar por los datos brindados en el cuadro de busqueda.
                    vlc_Condicion = string.Format("(NOMBRE_PROFESOR LIKE '%{0}%' OR PRIMER_APELLIDO_P LIKE '%{0}%' OR SEGUNDO_APELLIDO_P LIKE '%{0}%') AND ID_PROFESOR LIKE '%{1}%'", txtBuscarNombre.Text, txtBuscarIdentificacion.Text);
                    //Se llama a cargar datos con la condicion.
                    CargarDatos(vlc_Condicion);
                }
                else
                {
                    //En caso contrario se llama a cargar datos sin la condición por lo tanto va cargar todos los datos de la tabla.
                    CargarDatos();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                EliminarProfesor();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se invoca a la función de agregar o actualizar profesor.
                AgregarActualizar();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Se invoca la función de buscar.
            Buscar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //variable la cual va guardar la identificación del profesor que queremos mostrar.
            string vlc_Identifaciacion = string.Empty;
            try
            {
                //Se verifica que se haya seleccionado algo.
                if (grdLista.SelectedRows.Count > 0)
                {
                    //Se guarda la seleccion en la variable.
                    vlc_Identifaciacion = grdLista.SelectedRows[0].Cells[0].Value.ToString();
                    //Se llama a la función con la identificación del registro.
                    CargarRegistro(vlc_Identifaciacion);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarProfesor()
        {
            string vlc_Identicacion;
            int vln_Resultado = 0;
            ClsLogicaProfesor vlo_LogicaProfesor = new ClsLogicaProfesor();

            try
            {
                vlc_Identicacion = txtAAIdentificacion.Text;
                vln_Resultado = vlo_LogicaProfesor.EliminarProfesor(vlc_Identicacion);

                if (vln_Resultado > 0)
                {
                    MessageBox.Show("Registro eliminado satisfactoriamente.");
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado.");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtAATelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }
    }
}
