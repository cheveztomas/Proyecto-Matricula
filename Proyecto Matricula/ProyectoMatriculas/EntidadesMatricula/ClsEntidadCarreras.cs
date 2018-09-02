using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMatricula
{
    public class ClsEntidadCarreras
    {
        //ATRIBUTOS
        string vgc_NombreCarrera, vgc_Grado;
        int vgn_CodCarrera, vgn_TotalCreditos;
        bool vgb_Acreditada, existe;

        //PROPIEDADES
        public string NombreCarrera
        {
            get
            {
                return vgc_NombreCarrera;
            }

            set
            {
                vgc_NombreCarrera = value;
            }
        }

        public string Grado
        {
            get
            {
                return vgc_Grado;
            }

            set
            {
                vgc_Grado = value;
            }
        }

        public int CodCarrera
        {
            get
            {
                return vgn_CodCarrera;
            }

            set
            {
                vgn_CodCarrera = value;
            }
        }

        public int TotalCreditos
        {
            get
            {
                return vgn_TotalCreditos;
            }

            set
            {
                vgn_TotalCreditos = value;
            }
        }

        public bool Acreditada
        {
            get
            {
                return vgb_Acreditada;
            }

            set
            {
                vgb_Acreditada = value;
            }
        }

        public bool Existe
        {
            get
            {
                return existe;
            }

            set
            {
                existe = value;
            }
        }


        //CONSTRUCTORES
        public ClsEntidadCarreras()
        {
            vgb_Acreditada = false;
            vgc_Grado = string.Empty;
            vgc_NombreCarrera = string.Empty;
            vgn_CodCarrera = 0;
            vgn_TotalCreditos = 0;
            existe = false;
        }

        public ClsEntidadCarreras(string vgc_NombreCarrera, string vgc_Grado, int vgn_CodCarrera, int vgn_TotalCreditos, bool vgb_Acreditada, bool existe)
        {
            this.vgc_NombreCarrera = vgc_NombreCarrera;
            this.vgc_Grado = vgc_Grado;
            this.vgn_CodCarrera = vgn_CodCarrera;
            this.vgn_TotalCreditos = vgn_TotalCreditos;
            this.vgb_Acreditada = vgb_Acreditada;
            this.existe = existe;
        }
    }
}
