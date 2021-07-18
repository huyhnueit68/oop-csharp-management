using fruit_store.Controller;
using fruit_store.Entitis;
using System;
using System.Collections;
using System.Collections.Generic;

namespace fruit_store
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DECLARE
            CFruit _cFruit = new CFruit();
            List<Fruit> _fruits = new List<Fruit>();
            Hashtable _customer = new Hashtable();
            #endregion

            int choose = -1;
            try
            {
                while (true)
                {
                    Console.WriteLine("========= HE THONG CUA HANG TRAI CAY =========");
                    Console.WriteLine("1. Tao trai cay");
                    Console.WriteLine("2. Xem don dat hang");
                    Console.WriteLine("3. Mua sam (cho nguoi mua)");
                    Console.WriteLine("4. Thoat");
                    Console.Write("Chon: ");
                    choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            _cFruit.CInsert(_fruits);
                            break;
                        case 2:
                            _cFruit.CListBuy(_customer);
                            break;
                        case 3:
                            _cFruit.CBuy(_customer, _fruits);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Vui long chi chon nhung muc co trong menu !!!");
                            break;

                    }
                }
            } catch(Exception ce)
            {
                Console.WriteLine(ce);
            }
        }
    }
}
