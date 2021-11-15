using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness.Types
{
    public enum TypeFruit
    {
        Apple,
        Banana,
        Melon,
        Orange
    }

    public class Fruit : Sweets
    {
        private byte _ripeness;
        private TypeFruit _type;

        public Fruit()
        {
            CreateSweets();
        }

        protected override void CreateSweets()
        {
            var random = new Random();

            _weight = (byte)(random.Next() % 150 + 50);
            _ripeness = (byte)(random.Next() % 101);

            switch (random.Next() % 4)
            {
                case 0:
                    _type = TypeFruit.Apple;
                    break;
                case 1:
                    _type = TypeFruit.Banana;
                    break;
                case 2:
                    _type = TypeFruit.Melon;
                    break;
                case 3:
                    _type = TypeFruit.Orange;
                    break;
            }
        }
    }
}