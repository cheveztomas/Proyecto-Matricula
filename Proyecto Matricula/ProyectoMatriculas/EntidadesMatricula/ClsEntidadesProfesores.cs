using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMatricula
{
    public class ClsEntidadesProfesores : ClsEntidadPersonas
    {
        //VARAIBLES
        string vgc_msj;
        int vgn_CodProfesor;
        bool vgb_Borrado, vgb_Existe;

        //CONSTRUCTORES
        public ClsEntidadesProfesores(string msj, int codProfesor, bool borrado, bool existe, string pvc_Correo, string pvc_Identificacion, string pvc_Nombre, string pvc_PrimerApellido, string pvc_SegundoApellido, string pvc_Telefono)
        {
            this.msj = msj;
            CodProfesor = codProfesor;
            Borrado = borrado;
            Existe = existe;
            Correo = pvc_Correo;
            Identificacion = pvc_Identificacion;
            Nombre = pvc_Nombre;
            PrimerApellido = pvc_PrimerApellido;
            SegundoApellido = pvc_SegundoApellido;
            Telefono = pvc_Telefono;
        }

        
        public ClsEntidadesProfesores()
        {
            vgb_Borrado = false;
            vgb_Existe = false;
            vgc_msj = string.Empty;
            vgn_CodProfesor = 0;
        }

        //PROPIEDADES
        public string msj
        {
            get
            {
                return vgc_msj;
            }

            set
            {
                vgc_msj = value;
            }
        }

        public int CodProfesor
        {
            get
            {
                return vgn_CodProfesor;
            }

            set
            {
                vgn_CodProfesor = value;
            }
        }

        public bool Borrado
        {
            get
            {
                return vgb_Borrado;
            }

            set
            {
                vgb_Borrado = value;
            }
        }

        public bool Existe
        {
            get
            {
                return vgb_Existe;
            }

            set
            {
                vgb_Existe = value;
            }
        }
    }
}
