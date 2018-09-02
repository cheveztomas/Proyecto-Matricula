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
    public class ClsADMaterias
    {
        string vgc_CadenaConexion;

        #region MyRegion
        public ClsADMaterias(string vgc_CadenaConexion)
        {
            this.vgc_CadenaConexion = vgc_CadenaConexion;
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

        public int AgregarActualizar(ClsEntidadMaterias pvo_Materias, int pvn_Codigo)
        {
            //VARIABLES
            int vln_Resultado = 0;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            vlo_Command.Connection = vlo_Conexion;
            string vlc_sentencia = string.Empty;

            //SE ASIGNAN LOS VALORES 
            vlc_sentencia = "SP_AGREGAR_ACTUALIZAR_MATERIA";
            vlo_Command.Parameters.AddWithValue("@Cod_Materia", pvo_Materias.Cod_Materia);
            vlo_Command.Parameters.AddWithValue("@NombreMateria", pvo_Materias.Nombre);
            vlo_Command.Parameters.AddWithValue("@Creditos", pvo_Materias.Creditos);
            vlo_Command.Parameters.AddWithValue("@Borrado", pvo_Materias.Borrado);
            vlo_Command.Parameters.AddWithValue("@Cod_Carrera", pvn_Codigo);
            vlo_Command.CommandType = CommandType.StoredProcedure;
            vlo_Command.CommandText = vlc_sentencia;

            try
            {
                //SE EJECUTA LA SENTENCIA CON LAS VARIABLES
                vlo_Conexion.Open();
                vln_Resultado = vlo_Command.ExecuteNonQuery();
                vlo_Conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                vlo_Command.Dispose();
                vlo_Conexion.Dispose();
            }
            return vln_Resultado;
        }

        public DataSet CargarLista(string pvc_Condicion)
        {
            //variables
            DataSet vlo_DSMaterias = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(vgc_CadenaConexion);
            string vlc_Sentencia;

            //SE ESTABLECE LA SENTENCIA SQL.
            vlc_Sentencia = "SELECT COD_MATERIA, NOMBRE_MATERIA, CREDITOS, BORRADO FROM MATERIAS WHERE BORRADO NOT IN(1)";

            // SE VERIFICA SI EL PARAMETRO TRAE UN VALOR PARA MODIFICAR LA SENTENCIA.
            if (!string.IsNullOrEmpty(pvc_Condicion))
            {
                vlc_Sentencia = string.Format("{0} AND {1}", vlc_Sentencia, pvc_Condicion);
            }

            try
            {
                //SE ENVIA LA SENTENCIA Y LA CONEXION POR MEDIO DEL DATA ADAPTER.
                SqlDataAdapter vlo_DataAdapter = new SqlDataAdapter(vlc_Sentencia, vlo_conexion);
                // SE GURDA LO DEL DATA ADAPTER EN LA VARIABLE DATA SET
                vlo_DataAdapter.Fill(vlo_DSMaterias, "MATERIAS");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                vlo_conexion.Dispose();
            }
            //SE RETORNA EL DATA SET RESULTANTE.
            return vlo_DSMaterias;
        }

        public ClsEntidadMaterias CargarUnaMateria(string pvc_CodMateria)
        {
            //VARAIBLES
            ClsEntidadMaterias vlo_EntidadMateria = new ClsEntidadMaterias();
            string vlc_Sentencia = string.Empty;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            SqlDataReader vlo_DataReader;
            vlo_Command.Connection = vlo_Conexion;

            // SE ESTABLESE LA SENTENCIA CON EL CODIGO QUE PROVIENE DE LA CAPA SUPERIOR.
            vlc_Sentencia = string.Format("SELECT COD_MATERIA, NOMBRE_MATERIA, CREDITOS, BORRADO FROM MATERIAS WHERE COD_MATERIA='{0}'", pvc_CodMateria);
            vlo_Command.CommandText = vlc_Sentencia;
            try
            {
                //SE EJECUTA LA SENTENCIA
                vlo_Conexion.Open();
                vlo_DataReader = vlo_Command.ExecuteReader();
                if (vlo_DataReader.HasRows)
                {
                    // SE CARGAN LOS VALORES EN LA ENTIDAD
                    vlo_DataReader.Read();
                    vlo_EntidadMateria.Cod_Materia = vlo_DataReader.GetString(0);
                    vlo_EntidadMateria.Nombre = vlo_DataReader.GetString(1);
                    vlo_EntidadMateria.Creditos = vlo_DataReader.GetInt32(2);
                    vlo_EntidadMateria.Borrado = vlo_DataReader.GetBoolean(3);
                }
                vlo_Conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                vlo_Command.Dispose();
                vlo_Conexion.Dispose();
            }
            // SE RETORNA LA ENTIDAD CON LOS VALORES CARGADOS.
            return vlo_EntidadMateria;
        }

        public int EliminarMateria(string pvc_CodMateria)
        {
            //VARIABLES
            int vln_Resultado = 0;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            vlo_Command.Connection = vlo_Conexion;
            string vlc_Sentencia = string.Empty;

            //SE ESTABLECE LA SENTENCIA EN ESTE CASO ES UN PROCEDIMIENTO ALMACENADO.
            vlc_Sentencia = "SP_ELIMINAR_MATERIA";
            vlo_Command.Parameters.AddWithValue("@Cod_Materia", pvc_CodMateria);
            vlo_Command.CommandType = CommandType.StoredProcedure;
            vlo_Command.CommandText = vlc_Sentencia;

            try
            {
                //SE EJECUTA LA SENETNCIA.
                vlo_Conexion.Open();
                vln_Resultado = vlo_Command.ExecuteNonQuery();
                vlo_Conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                vlo_Command.Dispose();
                vlo_Conexion.Dispose();
            }

            // SE RETORNA UN VALOR NÚMEROCO CON LA CANTIDAD DE FILAS AFECTADAS.
            return vln_Resultado;
        }
    }
}
