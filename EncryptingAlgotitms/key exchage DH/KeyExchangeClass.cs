using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptingAlgotitms.key_exchage_DH
{
    class KeyExchangeClass : BaseClassEncrypting
    {
        static Random rand = new Random();
        long p;
        long g;

//===========================================================================
        /// <summary>
        /// Метод для считывания значений P и G из текстовых полей
        /// </summary>
        /// <param name="textfieldP">Текстовое поле P</param>
        /// <param name="textfieldG">Текстовое поле G</param>
        public void GetPG(string textfieldP, string textfieldG)
        {
            p = Convert.ToInt32(textfieldP);

            g = Convert.ToInt32(textfieldG);
        }

//===========================================================================
        /// <summary>
        /// Метод для возведения в степень
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="exp">Степень</param>
        /// <returns></returns>
        public long Powermod(long a, long exp)
        {
            long result = 1;

            for (long i = 0; i < exp; i++)
            {
                result = MultMod(result, a);
            }
            return result;
        }

//===========================================================================
        /// <summary>
        /// Метод для нахождения числа по модулю p
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="b">Степень</param>
        /// <returns></returns>
        long MultMod(long a, long b)
        {
            return (a * b) % p;
        }

        //========================================
        /// <summary>
        /// Метод, проверяющий простое число или нет
        /// </summary>
        /// <param name="num">заданное число</param>
        /// <returns></returns>
        public bool IsPrime(long num)
        {
            if (num < 2) return false;
            if (num == 2 || num == 3) return true;
            if (num % 2 == 0) return false;
            long max = Convert.ToInt64(Math.Sqrt(num));
            for (int i = 3; i <= max; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
