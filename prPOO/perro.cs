using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prPOO
{
    public class perro
    {
        //declaracion de atributos
        private string nombre;
        private string raza;
        private string al   tura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Altura { get => altura; set => altura = value+ "cm"; }

        //Declaracion de operaciones

        public String comer(String carne)
              {
              return this.Nombre + " Mide " + this.Altura + " y va a comer " + carne;
           
              }
        void dormir()
        {

        }
        void ladrar ()
        {

        }

        //Constuctor

        public perro ()
        {

        }
        public perro (string nombre, string altura, string raza)
        {
            this.Nombre = nombre;
            this.Altura = altura;
            this.Raza = raza;

        }
    }
}
