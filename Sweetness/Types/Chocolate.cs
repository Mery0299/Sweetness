using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness.Types
{
    public enum TypeChocolate
    {
        Dark,
        Milky
    }

    public enum FillingChocolade
    {
        Marmelade,
        Nougat,
        Waffle,
        Berry,
        Empty
    }

    public class Chocolate : Sweets
    {
        private FillingChocolade _filling;
        private byte _countTiles;
        private TypeChocolate _typeChocolate;

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
                    _filling = FillingChocolade.Marmelade;
                    break;
                case 1:
                    _filling = FillingChocolade.Nougat;
                    break;
                case 2:
                    _filling = FillingChocolade.Waffle;
                    break;
                case 3:
                    _filling = FillingChocolade.Berry;
                    break;
                case 4:
                    _filling = FillingChocolade.Empty;
                    break;
            }

            switch (random.Next() % 2)
            {
                case 0:
                    _typeChocolate = TypeChocolate.Dark;
                    break;
                case 1:
                    _typeChocolate = TypeChocolate.Milky;
                    break;
            }
        }
    }
}