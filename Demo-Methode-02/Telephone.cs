using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methode_02
{
    public struct Telephone
    {
        public short idxPays;
        public short idxReg;
        public int numero;

        public string FullPhone() {
            return $"+{idxPays}-(0){idxReg}/{numero}";
        }
    }
}
