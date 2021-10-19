using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        #region Constructores
        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        #endregion

        #region Metodos

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial>=4 && this.notaSegundoParcial>=4)
            {
                return random.Next(6,11);
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Alumno {this.nombre}, {this.apellido}, con legajo:{this.legajo}");
            stringBuilder.AppendLine($"Nota primer parcial: {this.notaPrimerParcial} Nota segundo parcial: {this.notaSegundoParcial}");
            stringBuilder.AppendLine($"El promedio es: {CalcularPromedio()}");
            if (CalcularNotaFinal() != -1)
            {
                stringBuilder.AppendLine($"Aprobado, nota final: {CalcularNotaFinal()}");
                
            }
            else
            {
                stringBuilder.AppendLine($"Desaprobado");
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
