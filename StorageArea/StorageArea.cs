using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace StorageArea
{
    public class StorageArea
    {
        public static int Id { get; set; } = 1;
       
        public static double FantaPrice { get; set; } = 1.3;
        public static double CocaColaPrice { get; set; } = 1.5;
        public static double WaterPrice { get; set; } = 0.5;



        public static Dictionary<int, IProion> Proionta = new Dictionary<int, IProion>();
        public static Dictionary<int, IProion> CocaColaList = new Dictionary<int, IProion>();
        public static Dictionary<int, IProion> FantaList = new Dictionary<int, IProion>();
        public static Dictionary<int, IProion> WaterList = new Dictionary<int, IProion>();

        public static void AddProionCocaCola()
        {
            IProion cocacola = new CocaCola(Id);          
            Proionta.Add(Id, cocacola);
            CocaColaList.Add(Id, cocacola);
            Id++;
        }

        public static void AddProionFanta()
        {
            IProion fanta = new Fanta(Id);
            Proionta.Add(Id, fanta);
            FantaList.Add(Id, fanta);
            Id++;
        }

        public static void AddProionWater()
        {
            IProion water = new Water(Id);
            Proionta.Add(Id, water);
            WaterList.Add(Id, water);
            Id++;
        }




     



    }


  


}
