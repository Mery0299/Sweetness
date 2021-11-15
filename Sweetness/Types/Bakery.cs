using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness.Types
{

    public class Bakery : Sweets
    {
        private string _type;
        private float _energyValue;

        public Bakery()
        {
            CreateSweets();
        }

        protected override void CreateSweets()
        {
            var random = new Random();

            _weight = (byte)(random.Next() % 200 + 50);
            _energyValue = random.Next() % 200 + 200;

            switch (random.Next() % 3)
            {
                case 0:
                    _type = "булочка";
                    break;
                case 1:
                    _type = "пирожок";
                    break;
                case 2:
                    _type = "ватрушка";
                    break;
            }
        }

        public override string GetInformation()
        {
            return $"Выпечка\nВес: {_weight}\nВид выпечки: {_type}\nЭнергетическая ценность: {_energyValue}";
        }
    }
}