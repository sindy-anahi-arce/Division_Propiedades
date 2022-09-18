using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Propiedades
{
    class cldivi
    {
        //Atributos
        private float num1;
        private float num2;

        //Propiedades
        public float Nume1
        {
            get => num1; set => num1 = value;
        }
        public float Nume2
        {
            get => num2; set => num2 = value;
        }

        //Método
        public float division()
        {
            return (num1 / num2);
        }
    }
}
