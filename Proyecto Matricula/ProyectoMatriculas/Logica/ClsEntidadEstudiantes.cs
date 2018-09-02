using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class ClsEntidadEstudiantes : ClsEntidadPersonas
    {

        private string vgc_Carnet, vgc_Provincia, vgc_Canton, vgc_Distrito, vgc_Nacionalidad, vgc_OtrasSenias, vgc_EstadoEstudiante;
        private DateTime vgd_FechaNacimiento, vgd_FechaIngreso;
        #region Propiedades
        public string Canton
        {
            get
            {
                return vgc_Canton;
            }

            set
            {
                vgc_Canton = value;
            }
        }

        public string Carnet
        {
            get
            {
                return vgc_Carnet;
            }

            set
            {
                vgc_Carnet = value;
            }
        }

        public string Distrito
        {
            get
            {
                return vgc_Distrito;
            }

            set
            {
                vgc_Distrito = value;
            }
        }

        public string EstadoEstudiante
        {
            get
            {
                return vgc_EstadoEstudiante;
            }

            set
            {
                vgc_EstadoEstudiante = value;
            }
        }

        public string FechaIngreso
        {
            get
            {
                return vgc_FechaIngreso;
            }

            set
            {
                FechaIngreso = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return vgd_FechaNacimiento;
            }

            set
            {
                vgd_FechaNacimiento = value;
            }
        }

        public DateTime Nacionalidad
        {
            get
            {
                return vgd_Nacionalidad;
            }

            set
            {
                vgd_Nacionalidad = value;
            }
        }

        public string OtrasSenias
        {
            get
            {
                return vgc_OtrasSenias;
            }

            set
            {
                vgc_OtrasSenias = value;
            }
        }

        public string Provincia
        {
            get
            {
                return vgc_Provincia;
            }

            set
            {
                vgc_Provincia = value;
            }
        }
        #endregion

        #region Constructores
        public ClsEntidadEstudiantes()
        {
            vgc_Canton = string.Empty;
            vgc_Carnet = string.Empty;
            vgc_Distrito = string.Empty;
            vgc_EstadoEstudiante = string.Empty;
            vgd_FechaIngreso = DateTime.Now;
            vgd_FechaNacimiento = DateTime.Now;
            vgc_Nacionalidad = string.Empty;
            vgc_OtrasSenias = string.Empty;
            vgc_Provincia = string.Empty;
            Nombre = string.Empty;
            PrimerApellido = string.Empty;
            SegundoApellido = string.Empty;
            Identificacion = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
        }

        public ClsEntidadEstudiantes(string pvc_Canton, string pvc_Carnet, string pvc_Distrito, string pvc_EstadoEstudiante, DateTime pvd_FechaNaciomiento, DateTime pvd_FechaIngreso, string pvc_Nacionalidad, string pvc_Provincia, string pvc_OtrasSenias)
        {
            vgc_Canton = pvc_Canton;
            vgc_Carnet = pvc_Carnet;
            vgc_Distrito = pvc_Distrito;
            vgc_EstadoEstudiante = pvc_EstadoEstudiante;
            vgd_FechaIngreso = pvd_FechaIngreso;
            vgd_FechaNacimiento = pvd_FechaNaciomiento;
            vgc_Nacionalidad = pvc_Nacionalidad;
            vgc_OtrasSenias = pvc_OtrasSenias;
            vgc_Provincia = pvc_Provincia;
        }


        #endregion
    }
}
