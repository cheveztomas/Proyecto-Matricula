using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMatricula
{
    class ClsDetallesMatricula
    {
        //ARGUMENTOS
        int vgn_NumeroRecibo, vgn_CodMateriaAbierta;
        double vgn_PorecentajeDescuento, vgn_NotaFinal;
        string vgc_Estado, vgc_Observaciones;

        //CONSTRUCTORES
        public ClsDetallesMatricula()
        {
            vgc_Estado = string.Empty;
            vgc_Observaciones = string.Empty;
            vgn_CodMateriaAbierta = 0;
            vgn_NotaFinal = 0;
            vgn_NumeroRecibo = 0;
            vgn_PorecentajeDescuento = 0;
        }

        //PROPIEDADES
        public ClsDetallesMatricula(string pvc_Estado, string pvc_Observaciones, double pvn_PorcentajeDescuento, double pvn_NotaFinal, int pvn_NumeroRecibo, int pvn_CodMateriaAbierta)
        {
            vgc_Estado = pvc_Estado;
            vgc_Observaciones = pvc_Observaciones;
            vgn_CodMateriaAbierta = pvn_CodMateriaAbierta;
            vgn_NotaFinal = pvn_NotaFinal;
            vgn_NumeroRecibo = pvn_NumeroRecibo;
            vgn_PorecentajeDescuento = pvn_PorcentajeDescuento;
        }


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

        public int CodMateriaAbierta
        {
            get
            {
                return vgn_CodMateriaAbierta;
            }

            set
            {
                vgn_CodMateriaAbierta = value;
            }
        }

        public double PorecentajeDescuento
        {
            get
            {
                return vgn_PorecentajeDescuento;
            }

            set
            {
                vgn_PorecentajeDescuento = value;
            }
        }

        public double NotaFinal
        {
            get
            {
                return vgn_NotaFinal;
            }

            set
            {
                vgn_NotaFinal = value;
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

        public string Observaciones
        {
            get
            {
                return vgc_Observaciones;
            }

            set
            {
                vgc_Observaciones = value;
            }
        }
    }
}
