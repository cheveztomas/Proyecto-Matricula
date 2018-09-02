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
    public class ClsADProfesor
    {
        string vgc_CadenaConexion;

        #region ConstructorPropiedades
        public ClsADProfesor(string vgc_CadenaConexion)
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

        //Insertar y modificar Profesor.
        public int AgregarActualizarProcedimiento(ClsEntidadesProfesores pvo_EntidadProfesor)
        {
            //Variables
            int vln_Resultado = -1;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            vlo_Command.Connection = vlo_Conexion;
            int vlc_mensaje = 0;
            string vlc_sentencia = string.Empty;
            //inicio
            //Se establece la sentencia en este caso es un procedimiento almacenado.
            vlc_sentencia = "SP_AGREGAR_PROFESOR";

            //Se establecen los valores a guardar en la base de datos.
            vlo_Command.Parameters.AddWithValue("@Id_Profesor", pvo_EntidadProfesor.Identificacion);
            vlo_Command.Parameters.AddWithValue("@Nombre_Profesor", pvo_EntidadProfesor.Nombre);
            vlo_Command.Parameters.AddWithValue("@Primer_Apellido_P", pvo_EntidadProfesor.PrimerApellido);
            vlo_Command.Parameters.AddWithValue("@Segundo_Apellido_P", pvo_EntidadProfesor.SegundoApellido);
            vlo_Command.Parameters.AddWithValue("@Telefono_Profesor", pvo_EntidadProfesor.Telefono);
            vlo_Command.Parameters.AddWithValue("@Correo_Profesor", pvo_EntidadProfesor.Correo);
            vlo_Command.Parameters.AddWithValue("@Borrado", pvo_EntidadProfesor.Borrado);
            //Se establece el tipo de sentencia a enviar.
            vlo_Command.CommandType = CommandType.StoredProcedure;
            //Se establece la sentencia.
            vlo_Command.CommandText = vlc_sentencia;
            try
            {
                //Se abre la conexion con la base de datos.
                vlo_Conexion.Open();
                //Se ejecuta la sentencia.
                vln_Resultado = vlo_Command.ExecuteNonQuery();
                // se cierra la conexion.
                vlo_Conexion.Close();

                //se libera la memoria.
                vlo_Command.Dispose();
                vlo_Conexion.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Resultado;
        }

        public DataSet ListaProfesores(string pvc_Condicion)
        {
            //variables
            DataSet vlo_DataSet = new DataSet();
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlDataAdapter vlo_DataAdapter;
            string vlc_Sentencia = string.Empty;
            try
            {
                //Se establece la senetncia
                vlc_Sentencia = "select cod_Profesor ,id_profesor,nombre_profesor+' '+primer_apellido_p+' '+segundo_apellido_p as nombre_concatenado,telefono_profesor, correo_profesor, borrado from profesores";
                //Se verifica si la condición es nula.
                if (!string.IsNullOrEmpty(pvc_Condicion))
                {
                    vlc_Sentencia = string.Format("{0} where {1}", vlc_Sentencia, pvc_Condicion);
                }
                //Se encia la sentencia y la cadena de conexion
                vlo_DataAdapter = new SqlDataAdapter(vlc_Sentencia, vlo_Conexion);
                //Se guarda en el tada set la tabla resultante.
                vlo_DataAdapter.Fill(vlo_DataSet, "PROFESORES");
                //se libera la memoria.
                vlo_Conexion.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_DataSet;
        }

        public ClsEntidadesProfesores ObtenerProfesor(string pvc_Condicion)
        {
            //Variables
            ClsEntidadesProfesores vlo_EntidadProfesores = new ClsEntidadesProfesores();
            string vlc_sentencia = string.Empty;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            SqlDataReader vlo_DataReader;
            //Se establece la variables de conexion.
            vlo_Command.Connection = vlo_Conexion;

            //Se estable de sentencia.
            vlc_sentencia = "select cod_Profesor ,id_profesor,nombre_profesor,primer_apellido_p,segundo_apellido_p,telefono_profesor, correo_profesor, borrado from profesores";

            //Se verifica si viene alguna condión en el parametro.
            if (!string.IsNullOrEmpty(pvc_Condicion))
            {
                //De ser así se modifica la consulta para que busque según el parametro estblecido.
                vlc_sentencia = string.Format("{0} where {1}", vlc_sentencia, pvc_Condicion);
            }
            //Se envia la sentencia.
            vlo_Command.CommandText = vlc_sentencia;
            try
            {
                //Se abre la conexión y se envia la consulta a la base de  datos.
                vlo_Conexion.Open();
                vlo_DataReader = vlo_Command.ExecuteReader();
                //se verifica quie la consulta tenga valores.
                if (vlo_DataReader.HasRows)
                {
                    vlo_DataReader.Read();
                    vlo_EntidadProfesores.CodProfesor = vlo_DataReader.GetInt32(0);
                    vlo_EntidadProfesores.Identificacion = vlo_DataReader.GetString(1);
                    vlo_EntidadProfesores.Nombre = vlo_DataReader.GetString(2);
                    vlo_EntidadProfesores.PrimerApellido = vlo_DataReader.GetString(3);
                    vlo_EntidadProfesores.SegundoApellido = vlo_DataReader.GetString(4);
                    vlo_EntidadProfesores.Telefono = vlo_DataReader.GetString(5);
                    vlo_EntidadProfesores.Correo = vlo_DataReader.GetString(6);
                    vlo_EntidadProfesores.Borrado = vlo_DataReader.GetBoolean(7);
                    vlo_EntidadProfesores.Existe = true;
                }
                vlo_Conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //Se libera la memoria.
                vlo_Conexion.Dispose();
                vlo_Command.Dispose();
            }
            return vlo_EntidadProfesores;

        }
        public int EliminarRegistro(string pvc_Identificacion)
        {
            int vln_resultado;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            string vlc_Sentencia;
            vlo_Command.Connection = vlo_Conexion;
            try
            {
                vlc_Sentencia = string.Format("select COUNT(PROFESORES.COD_PROFESOR) from profesores inner join MATERIA_ABIERTA on PROFESORES.COD_PROFESOR = MATERIA_ABIERTA.COD_PROFESOR where ID_PROFESOR = '{0}'", pvc_Identificacion);
                vlo_Command.CommandText = vlc_Sentencia;
                vlo_Conexion.Open();
                //Se verifica que tipo de borrado se debe de hacer.
                if (vlo_Command.ExecuteNonQuery() > 0)
                {
                    vlc_Sentencia = string.Format("update PROFESORES set BORRADO=1 where ID_PROFESOR='{0}'", pvc_Identificacion);
                }
                else
                {
                    vlc_Sentencia = string.Format("delete PROFESORES where ID_profesor= '{0}'", pvc_Identificacion);
                }
                vlo_Command.CommandText = vlc_Sentencia;
                vln_resultado = vlo_Command.ExecuteNonQuery();
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
            return vln_resultado;
        }
    }
}
