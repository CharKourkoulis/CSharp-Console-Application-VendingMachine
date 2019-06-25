using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageArea;
using Products;

namespace BusinessLogic
{
    public class BusinessLogic
    {

       


        

        public static void AddCocaColaProducts(int a)
        {
            for (int i = 0; i < a; i++)
            {
                StorageArea.StorageArea.AddProionCocaCola();
                
            }
        }


        public static void AddFantaProducts(int a)
        {
            for (int i = 0; i < a; i++)
            {
                StorageArea.StorageArea.AddProionFanta();
               
            }
        }


        public static void AddWaterProducts(int a)
        {
            for (int i = 0; i < a; i++)
            {
                StorageArea.StorageArea.AddProionWater();
               
            }
        }



      
        /// ////////////////////////////////////////////////
       
        public static void RemoveCocaColaItem(int quantity)
        {

            try
            {
                if (StorageArea.StorageArea.CocaColaList.Count > 0)
                {
                   
                    if (StorageArea.StorageArea.CocaColaList.Count >= quantity)
                    {
                        Console.WriteLine("Here is your CocaCola!");
                        int minCocaId = StorageArea.StorageArea.CocaColaList.Min(id => id.Key);

                        StorageArea.StorageArea.Proionta.Remove(minCocaId);
                        StorageArea.StorageArea.CocaColaList.Remove(minCocaId);
                       

                    }
                    else
                    {
                        Console.WriteLine($"I have only {StorageArea.StorageArea.CocaColaList.Count} CocaCola left...");

                    }
                }
                else if (StorageArea.StorageArea.CocaColaList == null || StorageArea.StorageArea.CocaColaList.Count ==0)
                {
                    Console.WriteLine($"No more CocaCola left...");
                }
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("No more Cocacola products!");
                
            }

         

        }

        public static void RemoveFantaItem(int quantity)
        {
            try
            {
                if (StorageArea.StorageArea.FantaList.Count > 0)
                {
                   
                    if (StorageArea.StorageArea.FantaList.Count >= quantity)
                    {
                        Console.WriteLine("Here is your Fanta!");
                        int minFantaId = StorageArea.StorageArea.FantaList.Min(id => id.Key);

                        StorageArea.StorageArea.Proionta.Remove(minFantaId);
                        StorageArea.StorageArea.FantaList.Remove(minFantaId);
                        

                    }
                    else
                    {
                        Console.WriteLine($"I have only {StorageArea.StorageArea.FantaList.Count} Fanta left...");

                    }
                }
                else if (StorageArea.StorageArea.FantaList == null || StorageArea.StorageArea.FantaList.Count == 0)
                {

                    Console.WriteLine($"No more Fanta left...");
                    
                }

            }
            catch (NullReferenceException)
            {
                
                Console.WriteLine("No more Fanta products!");
            }
            finally {  }
            


        }

        public static void RemoveWaterItem(int quantity)
        {
            try
            {
                if (StorageArea.StorageArea.WaterList.Count > 0)
                {
                   
                    if (StorageArea.StorageArea.WaterList.Count >= quantity)
                    {
                        Console.WriteLine("Here is your Water!");
                        int minWaterId = StorageArea.StorageArea.WaterList.Min(id => id.Key);

                        StorageArea.StorageArea.Proionta.Remove(minWaterId);
                        StorageArea.StorageArea.WaterList.Remove(minWaterId);
                       
                    }
                    else
                    {
                        Console.WriteLine($"I have only {StorageArea.StorageArea.WaterList.Count} Water left...");

                    }
                }
                else if (StorageArea.StorageArea.WaterList == null || StorageArea.StorageArea.WaterList.Count == 0)
                {
                    Console.WriteLine($"No more Water left...");
                }
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("No more Water products!");
            }
           
        }





        /// ////////////////////////////////////////////////
        public static void ShowAllProducts()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------<TA SYNOLIKA PROIONTA TOU PSYGEIOU>-----------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in StorageArea.StorageArea.Proionta)
            {
                Console.WriteLine($" Id: {item.Key.ToString(),-15 } | {item.Value.Type,-15} | price: {item.Value.Timi,-15}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }


        public static void ShowProductsQuantity()
        {
            Console.WriteLine($"There are: { StorageArea.StorageArea.CocaColaList.Count} CocaCola  |  {StorageArea.StorageArea.FantaList.Count} Fanta  |  {StorageArea.StorageArea.WaterList.Count} Water");
        }

        ///////////////////////////////////////////////


        public static void SelectProductCatch(double money)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TYPE '1' (or anything else) TO GET A COCACOLA,\nTYPE '2'TO GET A FANTA\nTYPE '3' TO GET A WATER");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            int type = Convert.ToInt32(Console.ReadLine());

            if (type == 1)
            {                            
                Console.WriteLine("You chose Cocacola!");
                Console.WriteLine();


                if (money >= StorageArea.StorageArea.CocaColaPrice)
                {
                    RemoveCocaColaItem(1);
                    money -= StorageArea.StorageArea.CocaColaPrice;
                    Console.WriteLine($"Now you have {money}  euro");
                }
                else
                {
                    Console.WriteLine("Sorry You dont have enough money!");
                }


            }
            else if (type == 2)
            {
                Console.WriteLine("You chose Fanta!");
                Console.WriteLine();

               
               

                if (money >= StorageArea.StorageArea.FantaPrice)
                {
                    RemoveFantaItem(1);
                    money -= StorageArea.StorageArea.FantaPrice;
                    Console.WriteLine($"Now you have {money}  euro");

                }
                else
                {
                    Console.WriteLine("Sorry You dont have enough money!");
                }   
                    
                    

            }
            else if (type == 3)
            {
                Console.WriteLine("You chose Water!");
                Console.WriteLine();

               
               

                if (money >= StorageArea.StorageArea.WaterPrice)
                {
                    RemoveWaterItem(1);
                    money -= StorageArea.StorageArea.WaterPrice;
                    Console.WriteLine($"Now you have {money}  euro");

                }
                else
                {
                    Console.WriteLine("Sorry You dont have enough money!");
                }


            }
            else
            {

                Console.WriteLine("You chose Cocacola!");
                Console.WriteLine();


                if (money >= StorageArea.StorageArea.CocaColaPrice)
                {
                    RemoveCocaColaItem(1);
                    money -= StorageArea.StorageArea.CocaColaPrice;
                    Console.WriteLine($"Now you have {money}  euro");
                }
                else
                {
                    Console.WriteLine("Sorry You dont have enough money!");
                }


            }

        }


        public static void RepeatSelectProduct(double money)

        {

            bool valid = true;
            do
            {

                SelectProduct(money);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Do you want to Drink another product?  Press 'NO' or 'no' to exit.");
                
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid );
        }

        public static void SelectProduct(double money)
        {

                try
                {

                    SelectProductCatch(money);
                   
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Answer!");
                }
                finally
                {

                }
           
        }

    }

   

    



}
