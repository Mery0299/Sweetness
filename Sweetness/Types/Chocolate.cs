using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness.Types
{

    public class Chocolate : Sweets
    {
        private string _filling;
        private byte _countTiles;
        private string _typeChocolate;

        public Chocolate()
        {
            CreateSweets();
        }

        protected override void CreateSweets()
        {
            var random = new Random();

            _weight = (byte)(random.Next() % 150 + 50);
            _countTiles = (byte)(random.Next() % 18 + 2);

            switch (random.Next() % 5)
            {
                case 0:
                    _filling = "мармеладная";
                    break;
                case 1:
                    _filling = "нуга";
                    break;
                case 2:
                    _filling = "вафля";
                    break;
                case 3:
                    _filling = "ягодная";
                    break;
                case 4:
                    _filling = "отсутвует";
                    break;
            }

            switch (random.Next() % 2)
            {
                case 0:
                    _typeChocolate = "тёмный";
                    break;
                case 1:
                    _typeChocolate = "молочный";
                    break;
            }
        }

        public override string GetInformation()
        {
            return $"Шоколадка\nВес: {_weight}\nНачинка: {_filling}\nКоличество плиток: {_countTiles}\nТип шоколада: {_typeChocolate}";
        }
    }
}