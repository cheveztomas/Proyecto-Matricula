using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesMatricula;
using LogicaNegocios;

namespace ProyectoMatriculas
{
    public partial class frm_Estudiantes : Form
    {
        //ESTAS VARIABLES DETERMINAN EL ESTADO DE LOS REGISTROS.
        public static bool RegistroNuevo;
        public static ClsEntidadEstudiantes EntidadRegistrada;
        public frm_Estudiantes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //SE CIERRA LA VENTANA CUANDO EL SE PRECIONA EL BOTON CERRAR.
            Close();
        }

        //SE CARGAN LOS DATOS DEL DATA SET A AL GRID VIEW
        private void CargarDatos(string pvc_Condicion = "")
        {
            //VARAIBLES
            ClsLogicaEstudiante vlo_LogicaCliente = new ClsLogicaEstudiante();
            DataSet vlo_DS;
            try
            {
                //SE INVOCA A LA FUNCIÓN DE QUE CARGA UN DATA SET CON LOS VALORES DETERMINADOS POR LA CONDICION.
                vlo_DS = vlo_LogicaCliente.ListaEstudiantes(pvc_Condicion);
                if (vlo_DS.Tables[0].Rows.Count >= 0)
                {
                    //SE ALAMCENA LA LISTA DE VALORES EN EL GRID VIEW
                    grdLista.DataSource = vlo_DS;
                    grdLista.DataMember = vlo_DS.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private ClsEntidadEstudiantes GenerarDatos()
        {
            //VARIABLES
            ClsEntidadEstudiantes vlo_EntidadEstudiantes;

            // EN CASO DE QUE LA VARIABLE GLOVAL REGISTRO NUEVO ESTÉ EN TRUE SE INSTANCIA LA CLASE.
            if (RegistroNuevo == true)
            {
                vlo_EntidadEstudiantes = new ClsEntidadEstudiantes();
            }
            else
            {
                //EN CASO CONTRARIO SE IGUALA A LA DE ENTIDAD REGISTRADA.
                vlo_EntidadEstudiantes = EntidadRegistrada;
            }
            //SE ESTABLESE LOS VALORES DE LA ENTIDAD.
            vlo_EntidadEstudiantes.Canton = txtAACanton.Text;
            //vlo_EntidadEstudiantes.Carnet = txtAACarnet.Text;
            vlo_EntidadEstudiantes.Correo = txtAACorreo.Text;
            vlo_EntidadEstudiantes.Distrito = txtAADistrito.Text;
            vlo_EntidadEstudiantes.EstadoEstudiante = CmbEstado.Text;
            vlo_EntidadEstudiantes.FechaIngreso = DateTime.Today;
            vlo_EntidadEstudiantes.FechaNacimiento = txtAAFechaNacimiento.Value;
            vlo_EntidadEstudiantes.Identificacion = txtAAIdentificacion.Text;
            vlo_EntidadEstudiantes.Nacionalidad = txtAANacionalidad.Text;
            vlo_EntidadEstudiantes.Nombre = txtAANombre.Text;
            vlo_EntidadEstudiantes.OtrasSenias = txtAAOtrasSenias.Text;
            vlo_EntidadEstudiantes.PrimerApellido = txtAAPrimerApellido.Text;
            vlo_EntidadEstudiantes.Provincia = CmbAAProvincia.Text;
            vlo_EntidadEstudiantes.SegundoApellido = txtAASegundoApellido.Text;
            vlo_EntidadEstudiantes.Telefono = txtAATel.Text;

            return vlo_EntidadEstudiantes;
        }

        private void Limpiar()
        {
            try
            {
                //SE INICIALIZAN TODOS LOS VALORES DE LA VENTANA Y SE CARGAN LOS DATOS AL GRIDVIEW.
                grdLista.AutoGenerateColumns = false;
                txtAACanton.Text = string.Empty;
                txtAACarnet.Text = string.Empty;
                txtAACorreo.Text = string.Empty;
                txtAADistrito.Text = string.Empty;
                txtAAFechaIngreso.Text = DateTime.Today.ToString();
                txtAAFechaNacimiento.Value = DateTime.Now;
                txtAAIdentificacion.Text = string.Empty;
                txtAANacionalidad.Text = "COSTA RICA";
                txtAANombre.Text = string.Empty;
                txtAAOtrasSenias.Text = string.Empty;
                txtAAPrimerApellido.Text = string.Empty;
                txtAASegundoApellido.Text = string.Empty;
                txtAATel.Text = string.Empty;
                txtBuscarCarnet.Text = string.Empty;
                txtBuscarIdentificación.Text = string.Empty;
                txtBuscarNombre.Text = string.Empty;
                CmbAAProvincia.Text = string.Empty;
                CmbEstado.Text = "ACT";
                RegistroNuevo = true;
                CargarDatos();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarRegistros(string pvc_Carnet)
        {
            //VARIABLES
            ClsEntidadEstudiantes vlo_EntidadEstudiante;
            ClsLogicaEstudiante vlo_LogicaCliente = new ClsLogicaEstudiante();
            // ESTABLECE LA CONDICIÓN PARA CARGAR EL REGISTRO DEL ESTUDIANTE.
            string vlc_Condicion = string.Format("CARNET='{0}'", pvc_Carnet);
            try
            {
                //SE INVOCA AL METODO DE OBTENER UN ESTUDIANTE.
                vlo_EntidadEstudiante = vlo_LogicaCliente.ObtenerEstudiante(vlc_Condicion);
                if (vlo_EntidadEstudiante.Existe == true)
                {
                    txtAACanton.Text = vlo_EntidadEstudiante.Canton;
                    txtAACarnet.Text = vlo_EntidadEstudiante.Carnet;
                    txtAACorreo.Text = vlo_EntidadEstudiante.Correo;
                    txtAADistrito.Text = vlo_EntidadEstudiante.Distrito;
                    txtAAFechaIngreso.Text = vlo_EntidadEstudiante.FechaIngreso.ToString();
                    txtAAFechaNacimiento.Value = vlo_EntidadEstudiante.FechaNacimiento;
                    txtAAIdentificacion.Text = vlo_EntidadEstudiante.Identificacion;
                    txtAANacionalidad.Text = vlo_EntidadEstudiante.Nacionalidad;
                    txtAANombre.Text = vlo_EntidadEstudiante.Nombre;
                    txtAAOtrasSenias.Text = vlo_EntidadEstudiante.OtrasSenias;
                    txtAAPrimerApellido.Text = vlo_EntidadEstudiante.PrimerApellido;
                    txtAASegundoApellido.Text = vlo_EntidadEstudiante.SegundoApellido;
                    txtAATel.Text = vlo_EntidadEstudiante.Telefono;
                    CmbAAProvincia.Text = vlo_EntidadEstudiante.Provincia;
                    CmbEstado.Text = vlo_EntidadEstudiante.EstadoEstudiante;
                    EntidadRegistrada = vlo_EntidadEstudiante;
                    RegistroNuevo = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //SE VERIFICA QUE NINGÚN CAMPO REQUERIDO SE ENCUENTRE VACIO.
            if (string.IsNullOrEmpty(txtAACanton.Text) || string.IsNullOrEmpty(txtAACorreo.Text) || string.IsNullOrEmpty(txtAADistrito.Text) || string.IsNullOrEmpty(txtAAFechaIngreso.Text) || string.IsNullOrEmpty(txtAAIdentificacion.Text) || string.IsNullOrEmpty(txtAANacionalidad.Text) || string.IsNullOrEmpty(txtAANombre.Text) || string.IsNullOrEmpty(txtAAOtrasSenias.Text) || string.IsNullOrEmpty(txtAAPrimerApellido.Text) || string.IsNullOrEmpty(txtAASegundoApellido.Text) || string.IsNullOrEmpty(txtAATel.Text) || string.IsNullOrEmpty(CmbAAProvincia.Text) || string.IsNullOrEmpty(CmbEstado.Text))
            {
                MessageBox.Show("Algún campo requerido se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //SE HACE LA INSTANCIACION A LAS CLSES NECESARIAS.
                ClsEntidadEstudiantes vlo_EntidadEstudiante;
                ClsLogicaEstudiante vlo_LogicaEstudiantes = new ClsLogicaEstudiante();
                string vlc_Resultado = string.Empty;
                try
                {
                    //SE INVOCA A LA FUNCIÓN DE GENERAR DATOS, LA CUAL DA COMO RESULTADO UNA ENTIDAD CON LOS DATOS DE LA VENTANA.
                    vlo_EntidadEstudiante = GenerarDatos();

                    //SE VERIFICA SI EL REGISTRO ES NUEVO O SI HAY QUE ANTUALIZAR UN REGISTRO.
                    if (RegistroNuevo == true)
                    {
                        //EN CASO DE QUE EL REGISTRO ES NUEVO SE INSERTA
                        vlc_Resultado = vlo_LogicaEstudiantes.InsertarEstudiante(vlo_EntidadEstudiante);
                    }
                    else
                    {
                        // EN CASO CONTRARIO SE ACTUALIZA EL REGISTRO.
                        vlc_Resultado = vlo_LogicaEstudiantes.ModificarEstudiante(vlo_EntidadEstudiante).ToString();
                    }

                    if (vlc_Resultado != string.Empty)
                    {
                        //SE MUESTRA UN MENSAJE SEGÚN EL RESULTADO.
                        MessageBox.Show("Operación realizada satisfactoriamente.");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("La operación no realizó ningún cambio.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void frm_Estudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                //AL CARGAR LA VENTA SE INVOCA EL METODO DE LIMPIAR QUE REINICIA LA VENTANA.
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //EVENTO DOBLRE CLICK SOBRE UN REGISTRODEL GRID VIEW
        private void grdLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //VARIABLES
            string vlc_Carnet = string.Empty;
            try
            {
                //SE VERIFICA SI HAY UN REGISTRO SELECCIONADO.
                if (grdLista.SelectedRows.Count > 0)
                {
                    //SE GUARDA EL VALOR DE LA CELDA UNO EN LA VARIABLE.
                    vlc_Carnet = grdLista.SelectedRows[0].Cells[0].Value.ToString();

                    // Y SE INVOCA A CARGAR REGISTRO CON EL CARNET PARA QUE SE CARGUEN LOS VALORES DEL CARNET.
                    CargarRegistros(vlc_Carnet);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Buscar()
        {
            string vlc_condicion;
            try
            {
                //SE VERIFICA QUE POR LO MENOS UN CAMPO DE BUSQUEDA SE ENCUENTRE LLENO.
                if (!string.IsNullOrEmpty(txtBuscarNombre.Text) || !string.IsNullOrEmpty(txtBuscarCarnet.Text) || !string.IsNullOrEmpty(txtBuscarIdentificación.Text))
                {
                    //SE ESTABLECE LA CONDICIÓN DE BUSQUEDA.
                    vlc_condicion = string.Format("(Nombre_Estudiante like '%{0}%' or primer_apellido_e like '%{0}%' or segundo_apellido_e like '%{0}%') and carnet like '%{1}%' and Id_Estudiante like '%{2}%'", txtBuscarNombre.Text, txtBuscarCarnet.Text, txtBuscarIdentificación.Text);
                    //SE INVICA AL METOD DE CARGAR DATOS CON LA CONDICIÓN QUE DA COMO RESULTADO LA LISTA DE LOS REGISTROS QUE COINSIDEN CON LA BUSQUEDA.
                    CargarDatos(vlc_condicion);
                }
                else
                {
                    // EN CASO CONTRARIO SE CARGAN TODOS LOS REGISTROS.
                    CargarDatos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                // EN EL EVENTO DEL BOTON DE BUSCAR SE INVOCA A LA FUNCIÓN DE BUSCAR LA CUAL CARGA LOS REGISTROS DE LA BUSQUEDA.
                Buscar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //SE RESTABLECEN LOS VALORES DE LA VENTANA.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // SE LIMPIA LA VENTA Y SE CARAGN LOS DATOS.
            Limpiar();
        }

        //ESTE EL EVENTO ELIMINAR UN ESTUDIANTE.
        private void button1_Click(object sender, EventArgs e)
        {
            //VARIABLES
            ClsLogicaEstudiante vlo_LogicaEstudiantes = new ClsLogicaEstudiante();
            ClsEntidadEstudiantes vlo_EntidadEstudiantes;
            string vlc_Condicion = string.Empty;
            int vlnResultado = 0;
            try
            {
                //SE VERIFICA QUE EL CAMPO DE CARNET NO SE ENCUENTRE VACIO.
                if (!string.IsNullOrEmpty(txtAACarnet.Text))
                {
                    //SE ESTABLECE LA CONDICIÓN PARA PODER ELIMINAR A UN ESTUIDIANTE.
                    vlc_Condicion = string.Format("carnet = '{0}'", txtAACarnet.Text);
                    //SE OBTIENE EL REGISTRO DEL ESTUDIANTE A ELIMIANAR.
                    vlo_EntidadEstudiantes = vlo_LogicaEstudiantes.ObtenerEstudiante(vlc_Condicion);

                    //SE VERIFICA QUE EL ESTUADIANTE A ELIMINAR EXISTA
                    if (vlo_EntidadEstudiantes.Existe == true)
                    {
                        vlnResultado = vlo_LogicaEstudiantes.EliminarEstudiante(vlo_EntidadEstudiantes);
                        if (vlnResultado > 0)
                        {
                            MessageBox.Show("Registro eliminado satisfactoriamente.");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error al eliminar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe");
                    }
                }
                else
                {
                    MessageBox.Show("Ningún estudiante seleccionado.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtAATel_KeyPress(object sender, KeyPressEventArgs e)
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
