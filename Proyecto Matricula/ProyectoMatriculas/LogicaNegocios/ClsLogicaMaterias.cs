using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesMatricula;
using Configuracion;
using System.Data;

namespace LogicaNegocios
{
    public class ClsLogicaMaterias
    {

        public int AgregarActualizar(ClsEntidadMaterias pvo_EntidadMateria, int pvn_Cod_Carrera)
        {
            //Variables
            int vln_Resultado = 0;
            ClsConfiguracion vlo_Config = new ClsConfiguracion();
            ClsADMaterias vlo_ADMateria;
            try
            {
                //Se envia la caddena de conexión
                vlo_ADMateria = new ClsADMaterias(vlo_Config.getConnectionString);
                //Se invoca al metodo a degregar ay actualizar.
                vln_Resultado = vlo_ADMateria.AgregarActualizar(pvo_EntidadMateria, pvn_Cod_Carrera);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Resultado;
        }

        //EN SINTESIS EL RESTO DE METODOS DE ESTA CLASE FUNCIONAN DE FORMA PARECIDA A LA ANTERIOR.
        public DataSet ListaMateria(string pvc_Condicion)
        {
            DataSet vlo_DataSet = new DataSet();
            ClsConfiguracion vlo_config = new ClsConfiguracion();
            ClsADMaterias vlo_ADMaterias;
            try
            {
                vlo_ADMaterias = new ClsADMaterias(vlo_config.getConnectionString);
                vlo_DataSet = vlo_ADMaterias.CargarLista(pvc_Condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_DataSet;
        }

        public ClsEntidadMaterias ObtenerMateria(string pvc_CodMateria)
        {
            ClsEntidadMaterias vlo_EntidadMateria = new ClsEntidadMaterias();
            ClsConfiguracion vlo_Config = new ClsConfiguracion();
            ClsADMaterias vlo_ADMaterias;
            try
            {
                vlo_ADMaterias = new ClsADMaterias(vlo_Config.getConnectionString);
                vlo_EntidadMateria = vlo_ADMaterias.CargarUnaMateria(pvc_CodMateria);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_EntidadMateria;
        }

        public int EliminarMateria(string vlc_CodMateria)
        {
            ClsConfiguracion vlo_Config = new ClsConfiguracion();
            ClsADMaterias vlo_ADMaterias;
            int vln_Resultado = 0;

            try
            {
                vlo_ADMaterias = new ClsADMaterias(vlo_Config.getConnectionString);
                vln_Resultado = vlo_ADMaterias.EliminarMateria(vlc_CodMateria);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Resultado;
        }
    }
}
