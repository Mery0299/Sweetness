using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sweetness.Types;

namespace Sweetness
{
    public partial class MainForm : Form
    {
        private List<Sweets> _listSweets;
        private List<string> _listTypes;

        private byte _countChocolade;
        private byte _countBakery;
        private byte _countFruit;

        private string _count;
        private string _information;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateList()
        {
            _countChocolade = 0;
            _countBakery = 0;
            _countFruit = 0;
            _listSweets.Clear();
            _listTypes.Clear();

            var random = new Random();

            int length = random.Next() % 30;
            for (int i = 0; i < length; i++)
            {
                switch(random.Next() % 3)
                {
                    case 0:
                        _listSweets.Add(new Chocolate());
                        _listTypes.Add("Шоколадка");
                        _countChocolade++;
                        break;
                    case 1:
                        _listSweets.Add(new Bakery());
                        _listTypes.Add("Выпечка");
                        _countBakery++;
                        break;
                    case 2:
                        _listSweets.Add(new Fruit());
                        _listTypes.Add("Фрукт");
                        _countFruit++;
                        break;
                }
            }
        }

        private void TakeSweet()
        {
            if (_listSweets.Any())
            {
                if (_listSweets[0] is Chocolate)
                {
                    _countChocolade--;
                }
                else if (_listSweets[0] is Bakery)
                {
                    _countBakery--;
                }
                else if (_listSweets[0] is Fruit)
                {
                    _countFruit--;
                }

                _listSweets.RemoveAt(0);
                _listTypes.RemoveAt(0);
            }
            else
            {
                _information = "Автомат пуст";
            }
        }
    }
}