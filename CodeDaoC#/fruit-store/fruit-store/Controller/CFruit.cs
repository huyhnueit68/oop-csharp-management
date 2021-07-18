using fruit_store.Entitis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_store.Controller
{
    class CFruit
    {
        #region Construct
        public CFruit()
        {

        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        public void CInsert(List<Fruit> _fruits)
        {
            bool insert = true;
            string choose = "";
            while (true)
            {
                if (insert)
                {
                    Fruit fruit = new Fruit();
                    fruit.InsetFruit();
                    _fruits.Add(fruit);
                    Console.WriteLine("Ban co muon tiep tuc khong (Y/N)?");
                    choose = Console.ReadLine();
                }
                
                if(choose == "N" || choose == "n")
                {
                    break;
                }

                if(choose != "N" && choose != "n" && choose != "Y" && choose != "y")
                {
                    insert = false;
                    Console.WriteLine("Vui long chon (Y/N)");
                    Console.WriteLine("Ban co muon tiep tuc khong (Y/N)?");
                    choose = Console.ReadLine();
                }

                if(choose == "Y" || choose == "y")
                {
                    insert = true;
                }
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_customer"></param>
        public void CListBuy(Hashtable _customer)
        {
            foreach (DictionaryEntry item in _customer)
            {
                Console.WriteLine("========== Danh sach order =========");
                Console.WriteLine("Khac hang: " + item.Key);
                foreach(Fruit fruit in (List<Fruit>)item.Value)
                {
                    Console.Write("San pham   |   So luong   |   Gia   |   So tien   \n");
                    Console.Write(fruit._fruitName + "\t\t");
                    Console.Write(fruit._fruitQty + "\t\t");
                    Console.Write(fruit._fruitPrice + "\t");
                    Console.Write(fruit._fruitQty * fruit._fruitPrice + "$\n");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_customer"></param>
        /// <param name="_fruits"></param>
        public void CBuy(Hashtable _customer, List<Fruit> _fruits)
        {
            bool insert = true;
            string choose = "";
            List<Fruit> listFruitBuy = new List<Fruit>();
            while (true)
            {
                if (insert)
                {
                    // display list
                    this.CDisplayListFruit(_fruits);

                    // customer buy
                    Console.Write("Mua hoa qua so:  ");
                    int customerChoose = Convert.ToInt32(Console.ReadLine());
                    customerChoose--;

                    if (_fruits.ElementAtOrDefault(customerChoose) == null)
                    {
                        Console.WriteLine("Vui long chi chon hoa qua co trong danh muc\n\n");
                    }
                    else
                    {
                        Fruit temp = new Fruit();
                        temp = _fruits[customerChoose];

                        Console.WriteLine("Ban da chon qua: " + temp._fruitName);
                        Console.Write("Vui long nhap so luong: ");
                        int qty = Convert.ToInt32(Console.ReadLine());
                        temp._fruitQty = qty;

                        listFruitBuy.Add(temp);

                        Console.WriteLine("Ban co muon tiep tuc khong (Y/N)?");
                        choose = Console.ReadLine();

                    }
                }

                if (choose == "N" || choose == "n")
                {
                    break;
                }

                if (choose != "N" && choose != "n" && choose != "Y" && choose != "y")
                {
                    insert = false;
                    Console.WriteLine("Vui long chon (Y/N)");
                    Console.WriteLine("Ban co muon tiep tuc khong (Y/N)?");
                    choose = Console.ReadLine();
                }

                if (choose == "Y" || choose == "y")
                {
                    insert = true;
                }
            }

            // checkout order
            this.DisplayBeforeBuy(_customer, listFruitBuy);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_customer"></param>
        /// <param name="listFruitBuy"></param>
        protected void DisplayBeforeBuy(Hashtable _customer, List<Fruit> listFruitBuy)
        {
            // display buy
            Console.WriteLine("========== Danh sach san pham mua =========");
            Console.Write("San pham   |   So luong   |   Gia   |   So tien   \n");
            foreach(Fruit fruit in listFruitBuy)
            {
                Console.Write(fruit._fruitName + "\t\t");
                Console.Write(fruit._fruitQty + "\t\t");
                Console.Write(fruit._fruitPrice + "\t");
                Console.Write(fruit._fruitQty* fruit._fruitPrice + "$\n");
            }
            Console.Write("Vui long nhap ten de ket thuc dat hang: ");
            string customerName = Console.ReadLine();

            _customer.Add(customerName, listFruitBuy);

            Console.Write("Cam on quy khach da mua san pham !!!\n\n");

        }

        protected void CDisplayListFruit(List<Fruit> _fruits)
        {
            Console.WriteLine("=========== DANH MUC TRAI CAY ============");
            Console.Write("| ++MUC++ | ");
            Console.Write("++TEN TRAI CAY++ | ");
            Console.Write("++ XUAT XU ++ | ");
            Console.Write("++ GIA ++ |");
            int count = 1;
            foreach (Fruit fruit in _fruits)
            {
                Console.Write("\n\t" + count + "\t");
                count++;
                fruit.DisplayFruitBuy();
            }
            Console.WriteLine();
        }
    }
}
