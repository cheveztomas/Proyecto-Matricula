using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntidadesMatricula;
using AccesoDatos;
using Configuracion;

namespace LogicaNegocios
{
    public class ClsLogicaEstudiante
    {
        
        public string InsertarEstudiante(ClsEntidadEstudiantes pvo_EntidadEstudiantes)
        {
            //VARIABLES
            string vlc_Resultado = string.Empty;
            ClsADEstudiante vlo_ADEstudiante;
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            try
            {
                //SE INSTANCIA LA VARIABLE DE ACCESO A DATOS CON LA CADENA DE CONEXION.
                vlo_ADEstudiante = new ClsADEstudiante(vlo_Confi.getConnectionString);
                //SE OBTIENE EL RESULTADO DE AGREGAR UN ESTUDIANTE INVOCANDO AL METODO.
                vlc_Resultado = vlo_ADEstudiante.Insertar(pvo_EntidadEstudiantes);
            }
            catch (Exception)
            {

                throw;
            }
            //SE RETORNA LA CANTIDAD DE FILAS AFECTADAS
            return vlc_Resultado;
        }

        //EN SINTESIS EL RESTO DE METODOS DE ESTA CAPA HACEN LO MISMO.
        public int ModificarEstudiante(ClsEntidadEstudiantes pvo_EntidadEstudiantes)
        {
            int vln_Resultado = 0;
            ClsADEstudiante vlo_ADEstudiante;
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            try
            {
                vlo_ADEstudiante = new ClsADEstudiante(vlo_Confi.getConnectionString);
                vln_Resultado = vlo_ADEstudiante.Modificar(pvo_EntidadEstudiantes);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Resultado;
        }

        public DataSet ListaEstudiantes(string pvc_Condicion)
        {
            DataSet vlo_DSCliente;
            ClsADEstudiante vlo_ADEstudiantes;
            ClsConfiguracion vlo_Config = new ClsConfiguracion();
            try
            {
                vlo_ADEstudiantes = new ClsADEstudiante(vlo_Config.getConnectionString);
                vlo_DSCliente = vlo_ADEstudiantes.ListRegistro(pvc_Condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_DSCliente;
        }

        public ClsEntidadEstudiantes ObtenerEstudiante(string pvc_Condicion)
        {
            ClsEntidadEstudiantes vlo_EntidadEstudiantes;
            ClsADEstudiante vlo_ADEstudiante;
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            try
            {
                vlo_ADEstudiante = new ClsADEstudiante(vlo_Confi.getConnectionString);
                vlo_EntidadEstudiantes = vlo_ADEstudiante.ObtenerRegistro(pvc_Condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_EntidadEstudiantes;
        }

        public int EliminarEstudiante(ClsEntidadEstudiantes pvo_EntidadEstudiante)
        {
            int vln_Resultado = 0;
            ClsADEstudiante vlo_ADEstudiantes;
            ClsConfiguracion vlo_confi = new ClsConfiguracion();
            try
            {
                vlo_ADEstudiantes = new ClsADEstudiante(vlo_confi.getConnectionString);
                vln_Resultado = vlo_ADEstudiantes.Eliminar(pvo_EntidadEstudiante);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Resultado;
        }
    }
}
