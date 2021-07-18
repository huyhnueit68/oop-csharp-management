using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_store.Entitis
{
    class Fruit
    {
        #region DECLATE
        public int _fruitID { get; set; }

        public string _fruitName { get; set; }

        public float _fruitPrice { get; set; }

        public int _fruitQty { get; set; }

        public string _source { get; set; }
        #endregion

        #region Method
        public void InsetFruit()
        {
            Console.Write("Ma trai cay: ");
            this._fruitID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ten trai cay: ");
            this._fruitName = Console.ReadLine();

            Console.Write("Gia ca: ");
            this._fruitPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("So luong: ");
            this._fruitQty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nguon goc: ");
            this._source = Console.ReadLine();
        }

        public void DisplayFruit()
        {
            Console.Write(this._fruitName + "\t\t");
            Console.Write(this._fruitQty + "\t");
            Console.Write(this._fruitPrice + "\t\t");
            Console.Write(this._fruitQty * this._fruitPrice + "\t" + "$");
        }

        public void DisplayFruitBuy()
        {
            Console.Write(this._fruitName + "\t\t");
            Console.Write(this._fruitPrice + "\t\t");
            Console.Write(this._fruitPrice + "$");
        }


        #endregion
    }
}
