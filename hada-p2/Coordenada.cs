using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    class Coordenada
    {
        public int Fila { get; set; }
        public int Columna { get; set; }

        public Coordenada()
        {

        }
        public Coordenada(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }
        public Coordenada(String fila, String columna)
        {
            try
            {
                Fila = Int32.Parse(fila);
                Columna = Int32.Parse(columna);
            }
            catch (FormatException)
            {
                Console.WriteLine("FORMATO INCORRECTO");
            }
        }
        public Coordenada(Coordenada c)
        {
            Fila = c.Fila;
            Columna = c.Columna;

        }
        public override string ToString() => "(" + Fila + "," + Columna + ")";
        public override int GetHashCode() => Fila.GetHashCode() ^ Columna.GetHashCode();
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /*{
            if (obj == null || !(obj is Coordenada))
                return false;
            else if ((this.Fila == ((Coordenada)obj).Fila) && (this.Columna == ((Coordenada)obj).Columna))
                return true;
            else
                return false;         
        }*/
        public bool Equals(Coordenada c)
        {
            return true;
        }


    }
}
