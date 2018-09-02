using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMatricula
{
    public class ClsEntidadMaterias
    {
        //ATRIBUTOS
        string vgc_Cod_Materia, vgc_Nombre;
        bool vgb_Borrado;
        int vgn_Creditos;

        //PROPIEDADES
        public string Cod_Materia
        {
            get
            {
                return vgc_Cod_Materia;
            }

            set
            {
                vgc_Cod_Materia = value;
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

        public int Creditos
        {
            get
            {
                return vgn_Creditos;
            }

            set
            {
                vgn_Creditos = value;
            }
        }

        //CONSTRUCOTRES
        public ClsEntidadMaterias(string vgc_Cod_Materia, string vgc_Nombre, bool vgb_Borrado, int vgn_Creditos)
        {
            this.vgc_Cod_Materia = vgc_Cod_Materia;
            this.vgc_Nombre = vgc_Nombre;
            this.vgb_Borrado = vgb_Borrado;
            this.vgn_Creditos = vgn_Creditos;
        }

        public ClsEntidadMaterias()
        {
            vgb_Borrado = false;
            vgc_Cod_Materia = string.Empty;
            vgc_Nombre = string.Empty;
            vgn_Creditos = 0;
        }
    }
}
