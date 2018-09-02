using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    public class ClsADEstudiantes
    {
        //Variables
        string vgc_CadenaConexion;

        public ClsADEstudiantes()
        {
            vgc_CadenaConexion = string.Empty;
        }

        public ClsADEstudiantes(string pvc_CadenaConexion)
        {
            vgc_CadenaConexion = pvc_CadenaConexion;
        }

        //Carnet Nuevo
        public string NuevoCarnet()
        {
            string vlc_CarnetNuevo = string.Empty;
            


            return vlc_CarnetNuevo;
        }
    }
}
