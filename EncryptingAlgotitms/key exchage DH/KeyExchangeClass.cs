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
        long maxPrime = 100;
        long minPrime = 10;
        long p;
        long g;
        long X;
        long Y;

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

        public override string Encrypt(string textfield1)
        {
            //GetPG(string textfieldP, string textfieldG);

            
           long num = Powermod(g, Convert.ToInt32(textfield1));

            string textfield2 = Convert.ToString(num);

            return textfield2;
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


        //public override string Decrypt(string textfield1, long num, long num2)
        //{
        //    num = Powermod(num2, Convert.ToInt32(textfield1));

        //    string textfield2 = Convert.ToString(num);

        //    return textfield2;
        //}

    }
}
