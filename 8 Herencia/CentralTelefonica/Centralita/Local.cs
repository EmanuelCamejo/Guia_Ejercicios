using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        private float costo;


        #region Propiedades
        public float Costo { get => costo; set => costo = value; }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen,float duracion, string destino, float costo):base(duracion,destino,origen)
        {
            
        }

        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float resultado;
            resultado = Duracion * costo;
            return resultado;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("" + base.Mostrar());
            sb.AppendLine("" + this.CalcularCosto());
            return sb.ToString();
        }
        #endregion

    }
}
