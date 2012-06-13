using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ES1TDD
{
    public class Cupom
    {
        private string numeroCupom;
        private int potz;
        public int getPotz()
        {
            return potz;
        }
        public Cupom(string numeroCupom)
        {
            this.numeroCupom = numeroCupom.Replace("-", "");
            this.potz = Int32.Parse(numeroCupom.Substring(0,3));
        }
        public bool IsValido()
        {
            int total = 0;
            int i = 1;
            for (int j = numeroCupom.Length - 1; j > 0; j--)
            {
                total = total + (Int32.Parse(numeroCupom.Substring(j,1)) * i);
                i++;
            }
            return (total % 11) == 0;
        }
    }
}