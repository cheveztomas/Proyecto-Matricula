using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMatricula
{
    public class ClsEntidadadMatricula
    {
        //ATRIBUTOS
        int vgn_NumeroRecibo;
        string vgc_Carnet, vgc_Estado;
        DateTime vgd_Fecha;
        double vgn_monto, vgn_Descuento;

        //CONSTRUCTORES
        public ClsEntidadadMatricula()
        {
            vgc_Carnet = string.Empty;
            vgc_Estado = string.Empty;
            vgd_Fecha = DateTime.Today;
            vgn_Descuento = 0;
            vgn_monto = 0;
            vgn_NumeroRecibo = 0;
        }

        public ClsEntidadadMatricula(int pvn_NumeroRecibo, string pvc_Estado, string pvc_Carnet, DateTime pvd_Fecha, double pvn_Monto, double pvn_Descuento)
        {
            vgc_Carnet = pvc_Carnet;
            vgc_Estado = pvc_Estado;
            vgd_Fecha = pvd_Fecha;
            vgn_Descuento = pvn_Descuento;
            vgn_monto = pvn_Monto;
            vgn_NumeroRecibo = pvn_NumeroRecibo;
        }

        //PROPIEDADES
        public int NumeroRecibo
        {
            get
            {
                return vgn_NumeroRecibo;
            }

            set
            {
                vgn_NumeroRecibo = value;
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

        public string Estado
        {
            get
            {
                return vgc_Estado;
            }

            set
            {
                vgc_Estado = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return vgd_Fecha;
            }

            set
            {
                vgd_Fecha = value;
            }
        }

        public double monto
        {
            get
            {
                return vgn_monto;
            }

            set
            {
                vgn_monto = value;
            }
        }

        public double Descuento
        {
            get
            {
                return vgn_Descuento;
            }

            set
            {
                vgn_Descuento = value;
            }
        }
    }
}
