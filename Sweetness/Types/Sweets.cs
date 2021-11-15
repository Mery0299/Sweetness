using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness.Types
{
    public abstract class Sweets
    {
        protected byte _weight;

        //метод случайного создания сладости
        protected abstract void CreateSweets();

        //метод выдачи информации
        public abstract string GetInformation();
    }
}