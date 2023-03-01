using Laboratorio1YeisonMauricioÁlvarez.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1YeisonMauricioÁlvarez.Negocio
{
    public class ClsPersona
    {
        public void calcularIMC(Persona info)
        {
            double pro = info.Peso / Math.Pow(info.Altura, 2);
            if (pro < 24)
            {
                Console.WriteLine("Su Peso es Ideal");
            }
            else
            {
                Console.WriteLine("Usted Tiene Sobre Peso");
            }

        }
        public void esMayorDeEdad(Persona info)
        {
            int Edad = info.Edad;
            if (Edad > 18)
            {
                Console.WriteLine("Usted Es Mayor de Edad");
            }
            else
            {
                Console.WriteLine("Usted Es Menor de Edad");
            }
        }
    }
 
    }

