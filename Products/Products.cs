using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{



    public enum Promitheutis { Karamitros_AE, Promitheutiki, AthinaikiKava  }

    public interface IProion
    {
         int Id { get; }
         double Timi { get; }
         string Type { get; }
        Promitheutis Promitheutis { get; }

    }

    public class CocaCola :IProion
    {
        public int Id { get; set; }
        public double Timi { get;  } = 1.5;

        public  string Type { get;  }

        public Promitheutis Promitheutis { get;  }

        public CocaCola(int id)
        {
            
            Type = "CocaCola";
            Promitheutis = Promitheutis.AthinaikiKava;
            Id = id;
        }

       

    }


    public class Fanta : IProion
    {
        public int Id { get; }
        public double Timi { get; } = 1.3;

        public string Type { get; }

        public Promitheutis Promitheutis { get; }

        public Fanta(int id)
        {
           
            Type = "fanta";
            Promitheutis = Promitheutis.Promitheutiki;
            Id = id;
        }
       

    }

    public class Water : IProion
    {
        public int Id { get; }
        public double Timi { get; } = 0.5;

        public string Type { get; }

        public Promitheutis Promitheutis { get; }

        public Water(int id)
        {            
            Type = "water";
            Promitheutis = Promitheutis.Karamitros_AE;
            Id = id;
        }
       

    }

}
