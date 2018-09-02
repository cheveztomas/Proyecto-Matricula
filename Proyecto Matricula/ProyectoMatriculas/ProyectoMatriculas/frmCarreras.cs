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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        public void CargarListaRegistros(string pvc_Condicion = "")
        {
            //Variables
            DataSet vlo_DataSet;
            ClsLogicaCarrera vlo_LogicaCarrera = new ClsLogicaCarrera();
            try
            {
                //Se establede el valor del data set con los valores retonados de la base de datos.
                vlo_DataSet = vlo_LogicaCarrera.ListaCarreras(pvc_Condicion);
                //Se verifica que el retorno no sea vacio.
                if (vlo_DataSet.Tables[0].Rows.Count > 0)
                {
                    //Se guardan los datos en un gridview.
                    grdLista.AutoGenerateColumns = false;
                    grdLista.DataSource = vlo_DataSet;
                    grdLista.DataMember = vlo_DataSet.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarCarrera(string pvc_Condicion)
        {
            //VARAIBLES
            ClsEntidadCarreras vlo_EntidadCarrera = new ClsEntidadCarreras();
            ClsLogicaCarrera vlo_LogicaCarrera = new ClsLogicaCarrera();

            try
            {
                //SE INVOCA LA FUNCION DE SELECCIONAL EL CUAL RETORNA UNA ENTIDAD CARRERA CON LOS DATOS DE LA CARRERA
                vlo_EntidadCarrera = vlo_LogicaCarrera.SelecionarRegistro(pvc_Condicion);

                //SE GUARDAN LOS DATOS EN  LAS VARIABLES DE LA VENTANA PARA SER MOSTRADOS.
                txtAACodigo.Text = vlo_EntidadCarrera.CodCarrera.ToString();
                txtAACreditos.Text = vlo_EntidadCarrera.TotalCreditos.ToString();
                txtAANombre.Text = vlo_EntidadCarrera.NombreCarrera.ToString();
                cmbAAGrado.Text = vlo_EntidadCarrera.Grado.ToString();
                if (vlo_EntidadCarrera.Acreditada == true)
                {
                    cmbAAAcreditado.Text = "SI";
                }
                else
                {
                    cmbAAAcreditado.Text = "NO";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Buscar()
        {
            string vlc_Condicion = string.Empty;
            try
            {
                vlc_Condicion = string.Format("COD_CARRERA LIKE '%{0}%' AND NOMBRE_CARRERA LIKE '%{1}%'", txtBuscarCodigo.Text, txtBuscarNombre.Text);
                CargarListaRegistros(vlc_Condicion);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AgregarActualizar()
        {
            int vln_resultado;
            ClsEntidadCarreras vlo_EntidadCarreras = new ClsEntidadCarreras();
            ClsLogicaCarrera vlo_LogicaCarreras = new ClsLogicaCarrera();

            if (!string.IsNullOrEmpty(txtAACreditos.Text) && !string.IsNullOrEmpty(txtAANombre.Text) && !string.IsNullOrEmpty(cmbAAAcreditado.Text) && !string.IsNullOrEmpty(cmbAAGrado.Text))
            {
                //Se verifica si va actualizar o a insertar un registro.
                if (string.IsNullOrEmpty(txtAACodigo.Text))
                {
                    vlo_EntidadCarreras.CodCarrera = -1;
                }
                else
                {
                    vlo_EntidadCarreras.CodCarrera = int.Parse(txtAACodigo.Text);
                }

                //Se pasan los valores pertinentes a la entidad.
                vlo_EntidadCarreras.Grado = cmbAAGrado.Text;
                vlo_EntidadCarreras.NombreCarrera = txtAANombre.Text;
                vlo_EntidadCarreras.TotalCreditos = int.Parse(txtAACreditos.Text);

                //Verifico la desición sobre la acredicación de la carrera.
                if (cmbAAAcreditado.Text == "SI")
                {
                    vlo_EntidadCarreras.Acreditada = true;
                }
                else
                {
                    vlo_EntidadCarreras.Acreditada = false;
                }
                try
                {
                    //Se invoca la función de agregar o actualizar una carrera.
                    vln_resultado = vlo_LogicaCarreras.AgregarActualizarCarrera(vlo_EntidadCarreras);
                    if (vln_resultado > 0)
                    {
                        MessageBox.Show("Se guardó registro de forma correcta.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar registro de forma correcta.");
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se puede guardar, un campo reqquerido está vacio.");
            }
        }

        //ESTA FUNCIÓN INICIA TODOS LOS VALORES.
        public void Limpiar()
        {
            try
            {
                txtAACodigo.Text = string.Empty;
                txtAACreditos.Text = 0.ToString();
                txtAANombre.Text = string.Empty;
                txtBuscarCodigo.Text = string.Empty;
                txtBuscarNombre.Text = string.Empty;
                cmbAAAcreditado.Text = string.Empty;
                cmbAAGrado.Text = string.Empty;
                CargarListaRegistros();
            }
            catch (Exception)
            {
                throw;

            }
        }

        //SE GUARDA UN REGISTRO.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //SE CONVOCA AL METODO AGREGAR ACTUALIZAR UN REGISTRO.
            AgregarActualizar();
            //SE RECARGAN LOS VALORES 
            Limpiar();
        }

        //SE CIERRA LA VENTANA.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {// SE LIMPIA LA VENTANA Y SE CARGAN LAS LISTAS.
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            //CUANDO SE CARGA LA VENTANA SE ESTABLECEN
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtAACreditos_KeyDown(object sender, KeyEventArgs e)
        {
            //En mi visual studio me marca un error.


            ////Para obligar a que sólo se introduzcan números 
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    //el resto de teclas pulsadas se desactivan 
            //    e.Handled = true;
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //EN EL EVENTO BUSCAR SE INBOCA AL METODO DE BUSCAR.
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void grdLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //VARIABLES
            string vlc_Condicion = string.Empty;
            try
            {
                //SE VERIFICA SI HAY UN ELEMENTO SELECCIONADO
                if (grdLista.SelectedRows.Count > 0)
                {
                    // EN CASO DE QUE SEA ASPI SE ESTABLECE LA CONDICION PARA ENVIARLO EN EL METODO DE CARGAR CARRERA
                    vlc_Condicion = string.Format("COD_CARRERA = {0}", grdLista.SelectedRows[0].Cells[0].Value);
                    //SE CARGA LA CARRERA INBOCANDO CARGAR CARRERA.
                    CargarCarrera(vlc_Condicion);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtAACreditos_KeyPress(object sender, KeyPressEventArgs e)
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
