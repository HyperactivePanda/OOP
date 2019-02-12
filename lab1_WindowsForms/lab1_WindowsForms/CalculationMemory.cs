using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_WindowsForms
{
    class CalculationMemory : MemoryInterface
    {
        private Double memory = 0;

        public void Memory_Clear() //стереть содержимое регистра мамяти
        {
            memory = 0.0;
        }
        public Double MemoryShow() //показать содержимое регистра мамяти
        {
            return memory;
        }
        public void M_Sum(Double b)
        {
            memory += b;
        }
        public void M_Sub(Double b)
        {
            memory -= b;
        }
    }
}
