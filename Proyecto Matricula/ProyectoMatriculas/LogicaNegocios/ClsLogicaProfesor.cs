using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using EntidadesMatricula;
using Configuracion;

namespace LogicaNegocios
{
    public class ClsLogicaProfesor
    {
        public int InsertarActualizarProfesor(ClsEntidadesProfesores pvo_EntidadProfesor)
        {
            //Variables
            int vln_resultado = 0;
            ClsADProfesor vlo_ADProfesor;
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            try
            {
                //Se envia a la clase de profesor la cadena de conexion.
                vlo_ADProfesor = new ClsADProfesor(vlo_Confi.getConnectionString);
                //Se envia la clase a la función de actualizar e insertar.
                vln_resultado = vlo_ADProfesor.AgregarActualizarProcedimiento(pvo_EntidadProfesor);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_resultado;
        }

        public DataSet ListaProfesores(string pvc_Condicion)
        {
            //Variables
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            DataSet vlo_DSProfesores;
            ClsADProfesor vlo_ADProfesor;
            try
            {
                //Se envia la cadena de conexion.
                vlo_ADProfesor = new ClsADProfesor(vlo_Confi.getConnectionString);
                //Se envia la condicion para carhar un data set.
                vlo_DSProfesores = vlo_ADProfesor.ListaProfesores(pvc_Condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_DSProfesores;
        }

        public ClsEntidadesProfesores ObtenerRegistro(string pvc_Condicion)
        {
            ClsConfiguracion vlo_Confi = new ClsConfiguracion();
            ClsEntidadesProfesores vlo_EntidadProfesor;
            ClsADProfesor vlo_ADProfesor;
            try
            {
                vlo_ADProfesor = new ClsADProfesor(vlo_Confi.getConnectionString);
                vlo_EntidadProfesor = vlo_ADProfesor.ObtenerProfesor(pvc_Condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return vlo_EntidadProfesor;
        }

        public int EliminarProfesor(string id_prfesor)
        {
            int vln_resultado;
            ClsConfiguracion vlo_confi = new ClsConfiguracion();
            ClsADProfesor vlo_ADProfesor;
            try
            {
                vlo_ADProfesor = new ClsADProfesor(vlo_confi.getConnectionString);
                vln_resultado = vlo_ADProfesor.EliminarRegistro(id_prfesor);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_resultado;
        }
    }
}
