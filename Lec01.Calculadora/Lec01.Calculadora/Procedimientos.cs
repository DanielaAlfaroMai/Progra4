using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec01.Calculadora
{
    public class Procedimientos
    {
 
        public String RealizarOperacion(String txtNum1, String txtNum2, String cmbOperaciones)
        {
            double num1 = (Convert.ToDouble(txtNum1));
            double num2 = (Convert.ToDouble(txtNum2));
            EnumeradoOperadores op = ConvierteStringEnEnumerado(cmbOperaciones);
            String Resultado = "Hubo un error en la operacion";
            if (Calcular(num1, num2, op) != null) {
                Resultado = Calcular(num1, num2, op).ToString();
            }
            
            return Resultado;
        }

        private EnumeradoOperadores ConvierteStringEnEnumerado(string op)
        {
            EnumeradoOperadores Result;
            switch (op)
            {
                case "Suma":
                case "Add":
                    Result = EnumeradoOperadores.Suma;
                    break;
                case "Resta":
                case "Subtraction":
                    Result = EnumeradoOperadores.Resta;
                    break;
                case "Division":
                    Result = EnumeradoOperadores.Division;
                    break;
                case "Multiplicacion":
                case "Multiply":
                    Result = EnumeradoOperadores.Multiplicacion;
                    break;

                default:
                   Result = EnumeradoOperadores.Desconocido;
                    break;
            }
            return Result;
        }



        public double? Calcular(double num1,double num2, EnumeradoOperadores elOperador)
        {
            double? Resultado = 0.0;
            switch (elOperador)
            {
                case EnumeradoOperadores.Suma:
                    Resultado = num1 + num2;
                    break;
                case EnumeradoOperadores.Resta:
                    Resultado = num1 - num2;
                    break;
                case EnumeradoOperadores.Multiplicacion:
                    Resultado = num1*num2;
                    break;
                case EnumeradoOperadores.Division:
                    if (num2 != 0)
                    {
                        Resultado = num1 / num2;
                    }
                    else
                    {
                        Resultado = null;
                    }
                    break;
                case EnumeradoOperadores.Desconocido:
                    Resultado = null;
                    break;

            }
            return Resultado;
        }
    }
}
