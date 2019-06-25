using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;
using BusinessLogic;


namespace AutomatosPolitis
{
   
    public class FrontEnd
    {
        public static double money;
        static void Main(string[] args)
        {
            bool valid = true;
            
           
           
            InputMoney(valid, out money);
            
            
          

            //Edw gemizw to psygeio me ton arithmo proiontwn ana eidos pou thelw 
            //BusinessLogic.BusinessLogic.AddCocaColaProducts(5);
            BusinessLogic.BusinessLogic.AddFantaProducts(2);
            BusinessLogic.BusinessLogic.AddWaterProducts(3);
            BusinessLogic.BusinessLogic.AddCocaColaProducts(4);

            //Edw mou emfanizei ola ta proionta pou yparxoun sto psygeio
            BusinessLogic.BusinessLogic.ShowAllProducts();
            BusinessLogic.BusinessLogic.ShowProductsQuantity();




            //BusinessLogic.BusinessLogic.SelectProduct(money);

            //BusinessLogic.BusinessLogic.RepeatSelectProduct(money);
            //BusinessLogic.BusinessLogic.ShowProductsQuantity();
            //BusinessLogic.BusinessLogic.ShowAllProducts();

            bool valid2 = true;
            do
            {

                BusinessLogic.BusinessLogic.SelectProduct(money);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Do you want to Drink another product?  Press 'NO' or 'no' to exit.");

                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid2);






        }


        public static void InputMoney(bool valid, out double money)
        {

            money = 0;
            do
            {
                try
                {
                    Console.WriteLine("How much money do you have (Input a correct value)? :");
                    money = Convert.ToDouble(Console.ReadLine());
                    valid = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong value!");
                }

            } while (valid);
           





        }


      


    }
}
