using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesMatricula;
using Configuracion;
using AccesoDatos;
using System.Data;

namespace LogicaNegocios
{
    public class ClsLogicaCarrera
    {
        public int AgregarActualizarCarrera(ClsEntidadCarreras pvo_EntidadCarrera)
        {
            //Se crea la variable que retorna un entero.
            int vln_Resultado;
            //Es tablece una variable objeto que almacena los datos de una carrera.
            ClsADCarreras vlo_ADCarrera;
            //Se instancia la clase configuración-
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            try
            {
                //Se pasa la cadena de conexión.
                vlo_ADCarrera = new ClsADCarreras(vlo_Confi.getConnectionString);
                //Se invoca la función que agrega o actualiza un registro con los datos obtenidos.
                vln_Resultado = vlo_ADCarrera.AgregarActualizarRegistro(pvo_EntidadCarrera);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Resultado;
        }

        public DataSet ListaCarreras(string pvc_Condision)
        {
            //Se establece una variable de configuracion.
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            ClsADCarreras vlo_ADCarreras;
            DataSet vlo_DataSet;
            try
            {
                //Se instancia el acceso a datos con la cadena de conexion.
                vlo_ADCarreras = new ClsADCarreras(vlo_Confi.getConnectionString);
                //Se invoca a la función que devuelve un data set.
                vlo_DataSet = vlo_ADCarreras.ListaCarreras(pvc_Condision);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_DataSet;
        }

        public ClsEntidadCarreras SelecionarRegistro(string pvc_Condicion)
        {
            ClsEntidadCarreras vlo_EntidadCarrera = new ClsEntidadCarreras();
            ClsConfiguracion vlo_Config = new ClsConfiguracion();
            ClsADCarreras vlo_ADCarreras;
            try
            {
                vlo_ADCarreras = new ClsADCarreras(vlo_Config.getConnectionString);
                vlo_EntidadCarrera = vlo_ADCarreras.CargarCarrera(pvc_Condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_EntidadCarrera;
        }
    }
}
