using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntidadesMatricula;

namespace AccesoDatos
{
    public class ClsADCarreras
    {
        string vgc_CadenaConexion;

        #region Propiedades
        public ClsADCarreras(string pvc_CadenaConexion)
        {
            this.vgc_CadenaConexion = pvc_CadenaConexion;
        }

        public ClsADCarreras()
        {
            vgc_CadenaConexion = string.Empty;
        }

        public string CadenaConexion
        {
            get
            {
                return vgc_CadenaConexion;
            }

            set
            {
                vgc_CadenaConexion = value;
            }
        }
        #endregion

        public int AgregarActualizarRegistro(ClsEntidadCarreras pvo_EntidadCarrera)
        {
            //Variables
            int vln_Resultado = -1;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            vlo_Command.Connection = vlo_Conexion;
            string vlc_Sentencia = string.Empty;

            //Se establece la sentencia.
            vlc_Sentencia = "SP_AGREGAR_ACTUALIZAR_CARRERA";
            //Se establecen los valores para la base de datos.
            vlo_Command.Parameters.AddWithValue("@Cod_Carrera", pvo_EntidadCarrera.CodCarrera);
            vlo_Command.Parameters.AddWithValue("@Nombre_Carrera", pvo_EntidadCarrera.NombreCarrera);
            vlo_Command.Parameters.AddWithValue("@Total_Creditos", pvo_EntidadCarrera.TotalCreditos);
            vlo_Command.Parameters.AddWithValue("@Grado", pvo_EntidadCarrera.Grado);
            vlo_Command.Parameters.AddWithValue("@Acreditada", pvo_EntidadCarrera.Acreditada);
            try
            {
                //Se establece la conexión y se ejecuta la sentencia con los datos.
                vlo_Command.CommandType = CommandType.StoredProcedure;
                vlo_Command.CommandText = vlc_Sentencia;
                vlo_Conexion.Open();
                vln_Resultado = vlo_Command.ExecuteNonQuery();
                vlo_Conexion.Close();
            }
            catch (Exception)
            {
                vln_Resultado = -1;
                throw;
            }
            finally
            {
                //Se libera la memoria.
                vlo_Command.Dispose();
                vlo_Conexion.Dispose();
            }

            return vln_Resultado;
        }

        public DataSet ListaCarreras(string pvc_Condicion)
        {
            //VARIABLES
            DataSet vlo_DSCarreras = new DataSet();
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);

            string vlc_Sentencia = String.Empty;

            //SE ESTABLECE LA SENTENCIA
            vlc_Sentencia = "SELECT COD_CARRERA, NOMBRE_CARRERA, TOTAL_CREDITOS, GRADO, ACREDITADA FROM CARRERAS";
            // SE VERIFICA SI SE DEBE CUMPLIR CON UNA CONDICION.
            if (pvc_Condicion != string.Empty)
            {
                vlc_Sentencia = string.Format("{0} WHERE {1}", vlc_Sentencia, pvc_Condicion);
            }
            //SE INSTANCIA UN DATA ADAPTER CON LA SENTENCIA Y LA CADENA DE CONEXION.
            SqlDataAdapter vlo_DataAdapter = new SqlDataAdapter(vlc_Sentencia, vlo_Conexion);
            //SE GUARDA EL RESULTADO EN UNA VARIBLE DATA SET.
            vlo_DataAdapter.Fill(vlo_DSCarreras, "CARRERAS");
            return vlo_DSCarreras;
        }

        public ClsEntidadCarreras CargarCarrera(string pvc_Condicion)
        {
            //varaibles
            ClsEntidadCarreras vlo_EntidadCarreras = new ClsEntidadCarreras();
            SqlDataReader vlo_DataReader;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            string vlc_sentencia = string.Empty;
            vlo_Command.Connection = vlo_Conexion;
            //Se establece la sentencia.
            vlc_sentencia = string.Format("SELECT COD_CARRERA, NOMBRE_CARRERA, TOTAL_CREDITOS, GRADO, ACREDITADA FROM CARRERAS WHERE {0}", pvc_Condicion);
            vlo_Command.CommandText = vlc_sentencia;
            try
            {
                //Se abre la conexión y se egecuta la sentencia.
                vlo_Conexion.Open();
                vlo_DataReader = vlo_Command.ExecuteReader();
                if (vlo_DataReader.HasRows)
                {
                    //Se guaradan los valores en la entidad correspondiente.
                    vlo_DataReader.Read();
                    vlo_EntidadCarreras.CodCarrera = vlo_DataReader.GetInt32(0);
                    vlo_EntidadCarreras.NombreCarrera = vlo_DataReader.GetString(1);
                    vlo_EntidadCarreras.TotalCreditos = vlo_DataReader.GetInt16(2);
                    vlo_EntidadCarreras.Grado = vlo_DataReader.GetString(3);
                    vlo_EntidadCarreras.Acreditada = vlo_DataReader.GetBoolean(4);
                    vlo_EntidadCarreras.Existe = true;
                }
                else
                {
                    vlo_EntidadCarreras.Existe = false;
                }
                vlo_Conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                vlo_Conexion.Dispose();
                vlo_Command.Dispose();
            }
            return vlo_EntidadCarreras;
        }
    }
}
