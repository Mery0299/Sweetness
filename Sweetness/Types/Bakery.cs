using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness.Types
{
    public enum TypeBarkey
    {
        Bun,
        Pie,
        CheeseCake
    }

    public class Bakery : Sweets
    {
        private TypeBarkey _type;
        private float _energyValue;

        public Bakery()
        {
            CreateSweets();
        }

        protected override void CreateSweets()
        {
            var random = new Random();

            _weight = (byte)(random.Next() % 150 + 50);
            _energyValue = random.Next() % 200 + 200;

            switch (random.Next() % 3)
            {
                case 0:
                    _type = TypeBarkey.Bun;
                    break;
                case 1:
                    _type = TypeBarkey.Pie;
                    break;
                case 2:
                    _type = TypeBarkey.CheeseCake;
                    break;
            }
        }
    }
}