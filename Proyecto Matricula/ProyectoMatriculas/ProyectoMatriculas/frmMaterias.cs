using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using LogicaNegocios;
using EntidadesMatricula;

namespace ProyectoMatriculas
{
    public partial class frmMaterias : Form
    {
        public bool NuevoRegistro = true;
        public frmMaterias()
        {
            InitializeComponent();
        }

        public void CargarListaCarreras(string pvc_Condicion = "")
        {
            //Variables
            DataSet vlo_DataSet;
            ClsLogicaCarrera vlo_LogicaCarrera = new ClsLogicaCarrera();
            try
            {
                //Se establede el valor del data set con los valores retonados de la base de datos.
                vlo_DataSet = vlo_LogicaCarrera.ListaCarreras(pvc_Condicion);
                //Se verifica que el retorno no sea vacio.
                if (vlo_DataSet.Tables[0].Rows.Count >= 0)
                {
                    //Se guardan los datos en un gridview.
                    grdListaCarreras.AutoGenerateColumns = false;
                    grdListaCarreras.DataSource = vlo_DataSet;
                    grdListaCarreras.DataMember = vlo_DataSet.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;

            }
        }

        public void CargarListaMaterias(string pvc_Condicion = "")
        {
            //VARIABLES
            ClsLogicaMaterias vlo_LogicaMaterias = new ClsLogicaMaterias();
            DataSet vlo_DataSet = new DataSet();

            try
            {
                //Se guarda el data set de retorno en una variable.
                vlo_DataSet = vlo_LogicaMaterias.ListaMateria(pvc_Condicion);
                if (vlo_DataSet.Tables[0].Rows.Count > 0)
                {
                    //Se guardan los datos en el gridview.
                    grdListaMaterias.AutoGenerateColumns = false;
                    grdListaMaterias.DataSource = vlo_DataSet;
                    grdListaMaterias.DataMember = vlo_DataSet.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnBuscarCarrera_Click(object sender, EventArgs e)
        {
            //VARIABLES
            string vlc_Condicion;
            //SE VERIFICA QUE EL CUADRO DE BUSQUEDA NO SE ENCUENTRE VACIO.
            if (!string.IsNullOrEmpty(txtBusCARRERA.Text))
            {
                //SE ESTABLESE LA CONDICIÓN CONLA CUAL SE REALIZARA LA BUSQUEDA.
                vlc_Condicion = string.Format("NOMBRE_CARRERA LIKE '%{0}%'", txtBusCARRERA.Text);
                //SE CARGA LA LISTA CON EL RESULTADO DE LA BUSQUEDA EN LA BASE DE DATOS.
                CargarListaCarreras(vlc_Condicion);
            }
            else
            {
                // EN CASO CONTRARIO SE CARGA LA LISTA CON TODOS LOS REGISTROS.
                CargarListaCarreras();
            }
        }

        private void Limpiar()
        {
            //SE LIMPIA LA VENTANA RESTABLECIENDO TODOS LOS VALRES DE LA VENTANA.
            txtBuscarCarrera.Text = string.Empty;
            txtBuscarMateriaCodigo.Text = string.Empty;
            txtAABuscarMateriaNombre.Text = string.Empty;
            txtBusCARRERA.Text = string.Empty;
            txtCarrera.Text = string.Empty;
            txtAABuscarMateriaNombre.Text = string.Empty;
            txtAAMATERIACodigo.Text = string.Empty;
            txtAAMATERIACreditos.Text = string.Empty;
            TxtAAMATERIANombre.Text = string.Empty;
            CargarListaCarreras();
            CargarListaMaterias();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            //AL CARGAR LA VENTA SE LIMPIA LA MISMA.
            Limpiar();
        }

        private void grdListaCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //VARIOABLES
            string vlc_Condicion = string.Empty;
            try
            {
                //SE VERIFICA QUE SE HAYA SELECCIONADO ALGÚN REGISTRO.
                if (grdListaCarreras.SelectedRows.Count > 0)
                {
                    //SE ESTABLECE LA CONDICIÓN PARA REALIZAR LA COINSULTA A LA BASE DE DATOS.
                    vlc_Condicion = string.Format("COD_CARRERA = {0}", grdListaCarreras.SelectedRows[0].Cells[0].Value);
                    //SE CARGA EL REGISTRO DE LA BASE DE DATOS.
                    CargarCarrera(vlc_Condicion);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCarrera(string pvc_Condicion)
        {
            //VARIABLES
            ClsEntidadCarreras vlo_EntidadCarrera = new ClsEntidadCarreras();
            ClsLogicaCarrera vlo_LogicaCarrera = new ClsLogicaCarrera();

            try
            {
                //SE CARGA UNA ENTIDAD INVOCANDO A LA FUNCIÓN DE SELECCIONAR REGISTRO.
                vlo_EntidadCarrera = vlo_LogicaCarrera.SelecionarRegistro(pvc_Condicion);
                //SE GUARDA LOS VALORES EN LAS VARIABLES CORRESPONDIENTES PARA SER MOSTRADOS AL USUARIO.
                txtCarrera.Text = vlo_EntidadCarrera.NombreCarrera;
                txtCarrera.Tag = vlo_EntidadCarrera.CodCarrera;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void AgregarActualizar()
        {
            //VARIABLES
            int vln_REsultado = 0;
            int vln_CodCarrera = 0;
            ClsEntidadMaterias vlo_EntidadMateria = new ClsEntidadMaterias();
            ClsLogicaMaterias vlo_ADMaterias = new ClsLogicaMaterias();

            //SE VERIFICA SI ES YN NUEVO REGISTRO.
            if (NuevoRegistro == true)
            {
                // DE SER ASÍ SE CARGAN TODOS LOS ATRIBUTOS A LA FINCION DE ACTUALIZAR AGREGAR REGISTRO.
                if (!string.IsNullOrEmpty(txtAAMATERIACodigo.Text) && !string.IsNullOrEmpty(txtAAMATERIACreditos.Text) && !string.IsNullOrEmpty(TxtAAMATERIANombre.Text) && !string.IsNullOrEmpty(txtCarrera.Text))
                {
                    vlo_EntidadMateria.Cod_Materia = txtAAMATERIACodigo.Text;
                    vlo_EntidadMateria.Creditos = int.Parse(txtAAMATERIACreditos.Text);
                    vlo_EntidadMateria.Nombre = TxtAAMATERIANombre.Text;
                    vln_CodCarrera = (int)txtCarrera.Tag;
                    try
                    {
                        vln_REsultado = vlo_ADMaterias.AgregarActualizar(vlo_EntidadMateria, vln_CodCarrera);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    if (vln_REsultado > 0)
                    {
                        MessageBox.Show("Materia Guardada de forma satisfactoria.");
                    }
                    else
                    {
                        MessageBox.Show("Materia no se guardo de forma satisfactoria.");
                    }
                }
                else
                {
                    MessageBox.Show("Algún campo requerido se encuentra vacío.");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtAAMATERIACodigo.Text) && !string.IsNullOrEmpty(txtAAMATERIACreditos.Text) && !string.IsNullOrEmpty(TxtAAMATERIANombre.Text))
                {
                    vlo_EntidadMateria.Cod_Materia = txtAAMATERIACodigo.Text;
                    vlo_EntidadMateria.Creditos = int.Parse(txtAAMATERIACreditos.Text);
                    vlo_EntidadMateria.Nombre = TxtAAMATERIANombre.Text;
                    //vln_CodCarrera = (int)txtCarrera.Tag;
                    try
                    {
                        vln_REsultado = vlo_ADMaterias.AgregarActualizar(vlo_EntidadMateria, vln_CodCarrera);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    if (vln_REsultado > 0)
                    {
                        MessageBox.Show("Materia Guardada de forma satisfactoria.");
                    }
                    else
                    {
                        MessageBox.Show("Materia no se guardo de forma satisfactoria.");
                    }
                }
                else
                {
                    MessageBox.Show("Algún campo requerido se encuentra vacío.");
                }
            }
            NuevoRegistro = true;
        }

        //SE CIERRA LA VENTANA
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //SE LIMPIA LA VENTANA
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // SE AGREGA UN REGISTRO O SE ACTUALIZA.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarActualizar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //SE BUSCA SEGÚN LO QUE SE SOLICITA
        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            string vlc_Condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtBuscarMateriaCodigo.Text) || !string.IsNullOrEmpty(txtAABuscarMateriaNombre.Text))
                {
                    vlc_Condicion = string.Format("COD_MATERIA LIKE '%{0}%' AND NOMBRE_MATERIA LIKE '%{1}%'", txtBuscarMateriaCodigo.Text, txtAABuscarMateriaNombre.Text);
                    CargarListaMaterias(vlc_Condicion);
                }
                else
                {
                    CargarListaMaterias();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //SE CARGA UN REGISTRO SEGÚN LA SELECCIÓN DEL USUARIO.
        private void CargarRegistro(string Cod_Materia)
        {
            ClsEntidadMaterias vlo_EntidadMateria = new ClsEntidadMaterias();
            ClsLogicaMaterias vlo_LogicaMaterias = new ClsLogicaMaterias();
            try
            {
                vlo_EntidadMateria = vlo_LogicaMaterias.ObtenerMateria(Cod_Materia);
                txtAAMATERIACodigo.Text = vlo_EntidadMateria.Cod_Materia;
                txtAAMATERIACreditos.Text = vlo_EntidadMateria.Creditos.ToString();
                TxtAAMATERIANombre.Text = vlo_EntidadMateria.Nombre.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        //SE INVOCA LA FUNCIÓN DE CARGAR UN REGISTRO Y SE CARGA EL REGISTRO QUE SE DESEA.
        private void grdListaMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string vlc_codMateria = string.Empty;
            if (grdListaMaterias.SelectedRows.Count > 0)
            {
                vlc_codMateria = grdListaMaterias.SelectedRows[0].Cells[0].Value.ToString();
                CargarRegistro(vlc_codMateria);
                NuevoRegistro = false;
            }
        }

        //SE BORRA EL REGISTRO SELECCIONADO.
        private void button3_Click(object sender, EventArgs e)
        {
            int vln_resultado = 0;
            ClsLogicaMaterias vlo_LogicaMaterias = new ClsLogicaMaterias();
            try
            {
                if (!string.IsNullOrEmpty(txtAAMATERIACodigo.Text))
                {
                    vln_resultado = vlo_LogicaMaterias.EliminarMateria(txtAAMATERIACodigo.Text);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Materia no puede ser borrada.");
                }
                if (vln_resultado > 0)
                {
                    MessageBox.Show("Materia eliminada de forma satisfactoria.");
                }
                else
                {
                    MessageBox.Show("Materia no ha sido eliminada de forma satisfatoria.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Limpiar();
            }
        }


    }
}