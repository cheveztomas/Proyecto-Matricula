using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMatricula
{
    public class ClsEntidadPersonas
    {
        #region Atributos
        private string vgc_Identificacion, vgc_Nombre, vgc_PrimerApellido, vgc_SegundoApellido, vgc_Telefono, vgc_Correo;
        #endregion

        #region Propiedades
        public string Correo
        {
            get
            {
                return vgc_Correo;
            }

            set
            {
                vgc_Correo = value;
            }
        }

        public string Identificacion
        {
            get
            {
                return vgc_Identificacion;
            }

            set
            {
                vgc_Identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return vgc_Nombre;
            }

            set
            {
                vgc_Nombre = value;
            }
        }

        public string PrimerApellido
        {
            get
            {
                return vgc_PrimerApellido;
            }

            set
            {
                vgc_PrimerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return vgc_SegundoApellido;
            }

            set
            {
                vgc_SegundoApellido = value;
            }
        }

        public string Telefono
        {
            get
            {
                return vgc_Telefono;
            }

            set
            {
                vgc_Telefono = value;
            }
        }
        #endregion

        #region Constructor
        public ClsEntidadPersonas()
        {
            vgc_Correo = string.Empty;
            vgc_Identificacion = string.Empty;
            vgc_Nombre = string.Empty;
            vgc_PrimerApellido = string.Empty;
            vgc_SegundoApellido = string.Empty;
            vgc_Telefono = string.Empty;
        }

        

        #endregion
    }
}
