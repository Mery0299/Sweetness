using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness.Types
{
    public class Fruit : Sweets
    {
        private byte _ripeness;
        private string _type;

        public Fruit()
        {
            CreateSweets();
        }

        protected override void CreateSweets()
        {
            var random = new Random();

            _weight = (byte)(random.Next() % 950 + 50);
            _ripeness = (byte)(random.Next() % 101);

            switch (random.Next() % 4)
            {
                case 0:
                    _type = "яблоко";
                    break;
                case 1:
                    _type = "банан";
                    break;
                case 2:
                    _type = "дыня";
                    break;
                case 3:
                    _type = "апельсин";
                    break;
            }
        }

        public override string GetInformation()
        {
            return $"Фрукт\nВес: {_weight} г.\nВид фрукта: {_type}\nСпелость: {_ripeness}%";
        }
    }
}