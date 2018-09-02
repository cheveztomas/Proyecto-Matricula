using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesMatricula;
using System.Data;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public class ClsADEstudiante
    {
        //Variables
        string vgc_CadenaConexion;

        public ClsADEstudiante()
        {
            vgc_CadenaConexion = string.Empty;
        }

        public ClsADEstudiante(string pvc_CadenaConexion)
        {
            vgc_CadenaConexion = pvc_CadenaConexion;
        }

        //Carnet Nuevo
        public string NuevoCarnet()
        {
            //VARIABLES
            string vlc_CarnetNuevo = string.Empty, vlc_AnioActual = string.Empty, vlc_Prefijo = string.Empty, vlc_sentencia = string.Empty, consecut = string.Empty;
            int Consecutivo;
            char Letra;
            //SE EXTRAE EL AÑO DE LA FECHA ACTUAL.
            vlc_AnioActual = DateTime.Now.Year.ToString();
            //SE EXTRAE EL PENULTIMO VALOR DEL AÑO.
            vlc_Prefijo += vlc_AnioActual[2];
            //SE CONVIERTE ESTE VALOR EN UN SU VALOR ASCCI QUE SE HACE SUMANDOLE 65 AL PENULTIMO NÚMERO DEL AÑO Y S EGUARDA EN LA VARIABLE LETRA..
            Letra = (char)(int.Parse(vlc_Prefijo) + 65);
            //SE LIMPIA EL VALOR DEL STRING.
            vlc_Prefijo = string.Empty;
            //SE GUARDA LA LETRA YA CONVERTIDA EN EL STRING.
            vlc_Prefijo = Letra.ToString();
            //SE LE CONCATENA EL ULTIMO DIGITO DEL AÑO.
            vlc_Prefijo += vlc_AnioActual[3];
            //SE ESTABLECE LAS VARIABLES DEL CLIENTE SQL.
            SqlCommand vlo_Command = new SqlCommand();
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            //SE ESTABLECE LA CONEXION CON LA BASE DE DATOS
            vlo_Command.Connection = vlo_Conexion;
            // SE ESTABLECE LA SENTENCIA LA CUAL VERIFICA LA CANTIDA DE CON ESE PREFIJO DE CARNET.
            vlc_sentencia = string.Format("select COUNT(CARNET) from ESTUDIANTES where CARNET like '%{0}%'", vlc_Prefijo);
            try
            {
                //SE ABRE LA CONEXION
                vlo_Conexion.Open();
                vlo_Command.CommandText = vlc_sentencia;

                // SE VERIFICA QUE SI LA CANTIDAD DE REGISTRO CON ESE PREFIJO ES CERO.
                if (Convert.ToInt32(vlo_Command.ExecuteScalar()) == 0)
                {
                    //SI ES CERO SE GUARDA EL CARNE CON EL PREFIJO Y SE CONCATENA QUE ES EL PRIMER REGISTRO.
                    vlc_CarnetNuevo = vlc_Prefijo + "0001";
                }
                else
                {
                    // DE CASO CONTRARIO SE BUSCA EL MAXIMO VALORCON ESE PREFIJO Y VALOR NÚMERO CO MAYOR.
                    vlc_sentencia = string.Format("select max(CONVERT(int,SUBSTRING(CARNET,3,LEN(CARNET)))) from ESTUDIANTES where CARNET like '%{0}%'", vlc_Prefijo);
                    vlo_Command.CommandText = vlc_sentencia;

                    //EL VALOR CONSECUTIVO OBTENIDO SE LE SUMA UNO PARA GENERAR EL SIGUIENTE CARNET.
                    Consecutivo = int.Parse(vlo_Command.ExecuteScalar().ToString()) + 1;
                    vlo_Conexion.Close();
                    //SE CONVIRTE ESTE NÚMERO A STRING
                    consecut = Consecutivo.ToString();
                    // SE VERIFICA LA LONGITUD DE ESTE Y SE LE CONCATENA CEROS ANTES DEL VALOR SEGÚN LO QUE SEA NECESARIO.
                    if (consecut.Length == 1)
                    {
                        vlc_CarnetNuevo = vlc_Prefijo + "000" + consecut;
                    }
                    else
                    {
                        if (consecut.Length == 2)
                        {
                            vlc_CarnetNuevo = vlc_Prefijo + "00" + consecut;
                        }
                        else
                        {
                            if (consecut.Length == 3)
                            {
                                vlc_CarnetNuevo = vlc_Prefijo + "0" + consecut;
                            }
                            else
                            {
                                if (consecut.Length == 4)
                                {
                                    vlc_CarnetNuevo = vlc_Prefijo + consecut;
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            // SE RETORNA EL CARNET NUEVO.
            return vlc_CarnetNuevo;
        }

        //Insertar Estudiantes
        public string Insertar(ClsEntidadEstudiantes pvo_EntidadEstudiante)
        {
            //Se establece las variables de conexion y de acceso a comandos sql.
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            //Variables
            string vlc_Carnet = string.Empty;
            string vlc_Sentencia = string.Empty;
            //Inicio
            vlo_Command.Connection = vlo_Conexion;
            try
            {
                // SE INVOCA EL METODO DE GENERAR GARNET EL CUAL CREA UN NUEVO CARNET.
                pvo_EntidadEstudiante.Carnet = NuevoCarnet();
                //SE PASAN LOS VALORES OBTENIDOS DE LA CAPA SUPERIOR A LA BASE DE DATOS.
                vlc_Sentencia = "INSERT INTO ESTUDIANTES(CARNET,ID_ESTUDIANTE,NOMBRE_ESTUDIANTE,PRIMER_APELLIDO_E,SEGUNDO_APELLIDO_E,TELEFONO_ESTUDIANTE,CORREO_ESTUDIANTE,PROVINCIA_ESTUDIANTE,CANTON_ESTUDIANTE,DISTRITO_ESTUDIANTE,OTRAS_SENIAS,NACIONALIDAD,FECHA_NACIMIENTO,FECHA_INGRESO,ESTADO,BORRADO) VALUES(@Carnet, @Id_Estudiante, @Nombre_Estudiante, @Primer_Apellido_E, @Segundo_Apellido_E, @Telefono_Estudiante, @Correo_Estudiante, @Provincia_Estudiante, @Canton_Estudiante, @Distrito_Estudiante, @Otras_Senias_E, @Nacionalidad, @Fecha_Nacimiento, @Fecha_Ingreso, @Estado, @Borrado)";
                vlo_Command.Parameters.AddWithValue("@Carnet", pvo_EntidadEstudiante.Carnet);
                vlo_Command.Parameters.AddWithValue("@Id_Estudiante", pvo_EntidadEstudiante.Identificacion);
                vlo_Command.Parameters.AddWithValue("@Nombre_Estudiante", pvo_EntidadEstudiante.Nombre);
                vlo_Command.Parameters.AddWithValue("Primer_Apellido_E", pvo_EntidadEstudiante.PrimerApellido);
                vlo_Command.Parameters.AddWithValue("@Segundo_Apellido_E", pvo_EntidadEstudiante.SegundoApellido);
                vlo_Command.Parameters.AddWithValue("@Telefono_Estudiante", pvo_EntidadEstudiante.Telefono);
                vlo_Command.Parameters.AddWithValue("@Correo_Estudiante", pvo_EntidadEstudiante.Correo);
                vlo_Command.Parameters.AddWithValue("@Provincia_Estudiante", pvo_EntidadEstudiante.Provincia);
                vlo_Command.Parameters.AddWithValue("@Canton_Estudiante", pvo_EntidadEstudiante.Canton);
                vlo_Command.Parameters.AddWithValue("@Distrito_Estudiante", pvo_EntidadEstudiante.Distrito);
                vlo_Command.Parameters.AddWithValue("@Otras_Senias_E", pvo_EntidadEstudiante.OtrasSenias);
                vlo_Command.Parameters.AddWithValue("@Nacionalidad", pvo_EntidadEstudiante.Nacionalidad);
                vlo_Command.Parameters.AddWithValue("@Fecha_Nacimiento", pvo_EntidadEstudiante.FechaNacimiento);
                vlo_Command.Parameters.AddWithValue("@Fecha_Ingreso", pvo_EntidadEstudiante.FechaIngreso);
                vlo_Command.Parameters.AddWithValue("@Estado", pvo_EntidadEstudiante.EstadoEstudiante);
                vlo_Command.Parameters.AddWithValue("@Borrado", pvo_EntidadEstudiante.Borrado);
                vlo_Command.CommandText = vlc_Sentencia;
                //SE ABRE LA CONEXION
                vlo_Conexion.Open();
                // SE EJECUTA LA SENTENCIA CON LOS VALORES.
                vlo_Command.ExecuteScalar();
                vlo_Conexion.Close();
                // YA QUE EL VALOR DE CARNET ES GENERADO POR CODIGO ENTONCES SE GUARDA ESTE VALOR DE LA VARIABLE DONDE SE GUARDÓ EL CARNET
                vlc_Carnet = pvo_EntidadEstudiante.Carnet;
            }
            catch (Exception)
            {
                vlc_Carnet = string.Empty;
                throw;
            }
            finally
            {
                vlo_Conexion.Dispose();
                vlo_Command.Dispose();
            }
            return vlc_Carnet;
        }

        public int Modificar(ClsEntidadEstudiantes pvo_EntidadEstudiante)
        {
            //VARIABLES
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            int vln_Resultado = -1;
            //SE ESTABLECE LA CONEXION CON LA BASE DE DATOS.
            vlo_Command.Connection = vlo_Conexion;
            string vlc_Sentencia;

            //SE ESTABLECEN LOS VALORES QUE SE VAN A GUARDAR EN LA BASE DE DATOS QUE PROVIENEN DE LA CAPA SUPERIOR.
            vlo_Command.Parameters.AddWithValue("@Carnet", pvo_EntidadEstudiante.Carnet);
            vlo_Command.Parameters.AddWithValue("@Id_Estudiante", pvo_EntidadEstudiante.Identificacion);
            vlo_Command.Parameters.AddWithValue("@Nombre_Estudiante", pvo_EntidadEstudiante.Nombre);
            vlo_Command.Parameters.AddWithValue("Primer_Apellido_E", pvo_EntidadEstudiante.PrimerApellido);
            vlo_Command.Parameters.AddWithValue("@Segundo_Apellido_E", pvo_EntidadEstudiante.SegundoApellido);
            vlo_Command.Parameters.AddWithValue("@Telefono_Estudiante", pvo_EntidadEstudiante.Telefono);
            vlo_Command.Parameters.AddWithValue("@Correo_Estudiante", pvo_EntidadEstudiante.Correo);
            vlo_Command.Parameters.AddWithValue("@Provincia_Estudiante", pvo_EntidadEstudiante.Provincia);
            vlo_Command.Parameters.AddWithValue("@Canton_Estudiante", pvo_EntidadEstudiante.Canton);
            vlo_Command.Parameters.AddWithValue("@Distrito_Estudiante", pvo_EntidadEstudiante.Distrito);
            vlo_Command.Parameters.AddWithValue("@Otras_Senias_E", pvo_EntidadEstudiante.OtrasSenias);
            vlo_Command.Parameters.AddWithValue("@Nacionalidad", pvo_EntidadEstudiante.Nacionalidad);
            vlo_Command.Parameters.AddWithValue("@Fecha_Nacimiento", pvo_EntidadEstudiante.FechaNacimiento);
            vlo_Command.Parameters.AddWithValue("@Fecha_Ingreso", pvo_EntidadEstudiante.FechaIngreso);
            vlo_Command.Parameters.AddWithValue("@Estado", pvo_EntidadEstudiante.EstadoEstudiante);
            vlo_Command.Parameters.AddWithValue("@Borrado", pvo_EntidadEstudiante.Borrado);
            //SE ESTABLECE LA SENTENCIA SQL.
            vlc_Sentencia = "UPDATE ESTUDIANTES SET ID_ESTUDIANTE=@Id_Estudiante,NOMBRE_ESTUDIANTE=@Nombre_Estudiante,PRIMER_APELLIDO_E=@Primer_Apellido_E,SEGUNDO_APELLIDO_E=@Segundo_Apellido_E,TELEFONO_ESTUDIANTE=@Telefono_Estudiante,CORREO_ESTUDIANTE=@Correo_Estudiante,PROVINCIA_ESTUDIANTE=@Provincia_Estudiante,CANTON_ESTUDIANTE=@Canton_Estudiante,DISTRITO_ESTUDIANTE=@Distrito_Estudiante,OTRAS_SENIAS=@Otras_Senias_E,NACIONALIDAD=@Nacionalidad,FECHA_NACIMIENTO=@Fecha_Nacimiento,FECHA_INGRESO=@Fecha_Ingreso,ESTADO=@Estado,BORRADO=@Borrado WHERE CARNET=@Carnet";
            try
            {
                // SE EJECUTA LA SENTENCIA SQL CON LOS VALORES NECESARIO.
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
                vlo_Conexion.Dispose();
                vlo_Command.Dispose();
            }
            //SE RETORNA UN ENTERO CON LA CANTIDAD DE VALORES MODIFICADOS.
            return vln_Resultado;
        }

        public DataSet ListRegistro(string pvc_Condicion)
        {
            //VARAIBLES
            DataSet vlo_DataSet = new DataSet();
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlDataAdapter vlo_DataAdapter;
            string vlc_sentencia = string.Empty;
            try
            {
                //SE ESTABLECE LA SENTENCIA SQL.
                vlc_sentencia = "SELECT CARNET, ID_ESTUDIANTE, NOMBRE_ESTUDIANTE+' '+PRIMER_APELLIDO_E+' '+SEGUNDO_APELLIDO_E AS NOMBRECONCATENADO, TELEFONO_ESTUDIANTE, CORREO_ESTUDIANTE,PROVINCIA_ESTUDIANTE,CANTON_ESTUDIANTE,DISTRITO_ESTUDIANTE, OTRAS_SENIAS, NACIONALIDAD,FECHA_NACIMIENTO,FECHA_INGRESO,ESTADO,BORRADO FROM ESTUDIANTES WHERE BORRADO=0";
                // SE VERIFICA QUE ÉXISTA UNA CONDICION PARA MODIFICAR LA SENTENCI EN CASO DE SER NECESAIO.
                if (!string.IsNullOrEmpty(pvc_Condicion))
                {
                    // SE MODIFICA LA SENTENCIA.
                    vlc_sentencia = string.Format("{0} AND {1}", vlc_sentencia, pvc_Condicion);
                }
                //SE ESTABLCE EL DATA ADAPTER CON LA SENETNCIA Y LA CADENA DE CONEXION.
                vlo_DataAdapter = new SqlDataAdapter(vlc_sentencia, vlo_Conexion);
                //SE RELLENA EL DATA SET CON LOS VALORES QUE DIERON COMO RESULTADO DE LA SENETCNIA EN ESTE CASO ES UAN TABLA CON LOS VALORES.
                vlo_DataAdapter.Fill(vlo_DataSet, "ESTUDIANTES");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                vlo_Conexion.Dispose();
            }
            // SE RETORNA UN DATA SET CON LA TABLA OBTENIDA DE LA BASE DE DATOS.
            return vlo_DataSet;
        }

        public ClsEntidadEstudiantes ObtenerRegistro(string pvc_Condicion)
        {
            //VARIABLES
            ClsEntidadEstudiantes vlo_EntidadEstudiantes = new ClsEntidadEstudiantes();
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            SqlDataReader vlo_DataReader;
            string vlc_sentencia = string.Empty;

            // SE ESTABLESE LA CONEXION CON LA BASE DE DATOS.
            vlo_Command.Connection = vlo_Conexion;

            //SE ESTABLESE LA SENETENCIA SQL.
            vlc_sentencia = "SELECT CARNET, ID_ESTUDIANTE, NOMBRE_ESTUDIANTE, PRIMER_APELLIDO_E, SEGUNDO_APELLIDO_E, TELEFONO_ESTUDIANTE, CORREO_ESTUDIANTE,PROVINCIA_ESTUDIANTE,CANTON_ESTUDIANTE,DISTRITO_ESTUDIANTE, OTRAS_SENIAS, NACIONALIDAD,FECHA_NACIMIENTO,FECHA_INGRESO,ESTADO,BORRADO FROM ESTUDIANTES";

            //SE VERIFICA SI EL PARAMETRO TIENEN VALORES PARA MODIFICAR LA SENTENCIA EN CASO DE SER NECESARIO.
            if (!string.IsNullOrEmpty(pvc_Condicion))
            {
                vlc_sentencia = string.Format("{0} where {1}", vlc_sentencia, pvc_Condicion);

            }
            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS Y ESTA RETORNA UN REGISTRO QUE CORRSPONDE CON LA CONSULTA.
                vlo_Command.CommandText = vlc_sentencia;
                vlo_Conexion.Open();
                vlo_DataReader = vlo_Command.ExecuteReader();
                if (vlo_DataReader.HasRows)
                {
                    //SE LEEN LOS DATOS RESULTANTES Y SE GUARDAN EN LA ENTIDAD QUE LE CORRESPONDE.
                    vlo_DataReader.Read();
                    vlo_EntidadEstudiantes.Carnet = vlo_DataReader.GetString(0);
                    vlo_EntidadEstudiantes.Identificacion = vlo_DataReader.GetString(1);
                    vlo_EntidadEstudiantes.Nombre = vlo_DataReader.GetString(2);
                    vlo_EntidadEstudiantes.PrimerApellido = vlo_DataReader.GetString(3);
                    vlo_EntidadEstudiantes.SegundoApellido = vlo_DataReader.GetString(4);
                    vlo_EntidadEstudiantes.Telefono = vlo_DataReader.GetString(5);
                    vlo_EntidadEstudiantes.Correo = vlo_DataReader.GetString(6);
                    vlo_EntidadEstudiantes.Provincia = vlo_DataReader.GetString(7);
                    vlo_EntidadEstudiantes.Canton = vlo_DataReader.GetString(8);
                    vlo_EntidadEstudiantes.Distrito = vlo_DataReader.GetString(9);
                    vlo_EntidadEstudiantes.OtrasSenias = vlo_DataReader.GetString(10);
                    vlo_EntidadEstudiantes.Nacionalidad = vlo_DataReader.GetString(11);
                    vlo_EntidadEstudiantes.FechaNacimiento = vlo_DataReader.GetDateTime(12);
                    vlo_EntidadEstudiantes.FechaIngreso = vlo_DataReader.GetDateTime(13);
                    vlo_EntidadEstudiantes.EstadoEstudiante = vlo_DataReader.GetString(14);
                    vlo_EntidadEstudiantes.Borrado = vlo_DataReader.GetBoolean(15);
                    vlo_EntidadEstudiantes.Existe = true;

                }
                // SE CIERRA LA C0NEXION
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
            //SE RETORNA LA ENTIDAD CON LOS VALORES RESULTANTES.
            return vlo_EntidadEstudiantes;
        }

        public int Eliminar(ClsEntidadEstudiantes pvo_EntidadEstudiante)
        {
            //VARIABLES
            int vln_Resultado = -1;
            SqlConnection vlo_Conexion = new SqlConnection(vgc_CadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            string vlc_setencia = string.Empty;

            //SE ESTABLECE LA CADENA DE CONEXION.
            vlo_Command.Connection = vlo_Conexion;
            vlo_Command.Parameters.AddWithValue("@carnet", pvo_EntidadEstudiante.Carnet);
            vlc_setencia = "select count(carnet) from matricula where carnet=@carnet";
            try
            {
                //SE ABRE LA CONEXION A LA BASE DE DATOS.
                vlo_Conexion.Open();
                vlo_Command.CommandText = vlc_setencia;
                //SE EJECUTA LA SENTENCIA SQL EL CUAL VERIFICA QUE CLASE DE BORRADO SE DEBE HACER.
                vln_Resultado = vlo_Command.ExecuteNonQuery();
                //SEGUN EL RESULTADO SE HACE UN BORRADO LOGICO O BORRADO DE LA BASE DE DATOS.
                if (vln_Resultado > 0)
                {
                    vlc_setencia = "update estudiantes set borrado=1 where carnet=@carnet";

                }
                else
                {
                    vlc_setencia = "DELETE FROM ESTUDIANTES WHERE CARNET=@CARNET";

                }
                //SE EJECUTA LA SENTENCIA CON EL VALOR QUE SE DESEA BORRAR.
                vlo_Command.CommandText = vlc_setencia;
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
                vlo_Command.Dispose();
                vlo_Conexion.Dispose();
            }
            return vln_Resultado;
        }
    }
}
