using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptingAlgotitms.rsa
{
    class RSAcipherClass
    {
        const int minPrime = 100;
        const int maxPrime = 500;
        public int p;
        public int q;
        public int f;
        public int e;
        public int d;
        public int n;

        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        static Random random = new Random();

        //==========================================
        ///<summary>
        ///Метод для определения простого числа
        /// </summary>
        public bool IsPrimeNumber(int n)
        {

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            int max = Convert.ToInt32(Math.Sqrt(n));

            for (int j = 3; j < max; j += 2)
            {
                if (n % j == 0)
                    return false;
            }
            return true;
        }

        //==========================================
        ///<summary>
        ///Метод генерирующий случайное простое число
        ///</summary>
        public int GenerateRandomPrimeNumber()
        {
            int primeNumber;
            int loop = 1000;

            while (--loop > 0)
            {
                primeNumber = random.Next(minPrime, maxPrime);

                if (IsPrimeNumber(primeNumber) == true)

                    return primeNumber;
            }
            throw new Exception("Простое число не найдено");
        }

        //==========================================
        /// <summary>
        /// Методы для инициализации полей P и Q простыми случайнвми числами
        /// </summary>
        public void GenerateP()
        {
            p = GenerateRandomPrimeNumber();
            CalcNumbers();
        }
        public void GenerateQ()
        {
            q = GenerateRandomPrimeNumber();
            CalcNumbers();
        }

        //==========================================
        /// <summary>
        /// Метод для вычисления значений N и F
        /// </summary>
        public void CalcNumbers()
        {
            n = p * q;

            f = (p - 1) * (q - 1);
        }

        //==========================================
        ///<summary>
        ///Метод нахождения нпибольшего общего делителя(алгоритм Евклида)
        ///</summary>
        public int GCD(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        //==========================================
        /// <summary>
        /// Метод для генерации числа E
        /// </summary>
        public void GenerateE()
        {
            int number;
            int loop = 1000;
            while (--loop > 0)
            {
                number = random.Next(minPrime, maxPrime);
                if (GCD(number, f) == 1)
                {
                    e = number;
                    return;
                }
            }
            throw new Exception("Can' t found E Value!");
        }

        //==========================================
        /// <summary>
        /// Метод для генерации числа D
        /// </summary>
        /// <returns></returns>
        public void GenerateD()
        {
            int startPos = 0;
            for (int i = 1; i < maxPrime * maxPrime; i++)
            {
                startPos = (startPos + e) % f;
                if (startPos == 1)
                {
                    d = i;
                    return;
                }
            }
            throw new Exception("Can' t found D Value");
        }

        //==========================================
        /// <summary>
        /// Метод, вычисляющий значение выражения a^b по модулю mod
        /// </summary>
        /// <param name="num1">число</param>
        /// <param name="num2">степень</param>
        /// <param name="mod">модуль числа</param>
        /// <returns></returns>
        public int Power(int num1, int num2, int mod)
        {
            long res = 1;
            for (int i = 1; i <= num2; i++)
                res = (res * num1) % mod;
            return (int)res;
        }

        //==========================================
        /// <summary>
        /// Метод шифрования сообщения
        /// </summary>
        /// <param name="textMessageRSA">сообщения для шифрования</param>
        /// <param name="e">публичный ключ e</param>
        /// <param name="n">публичный ключ n</param>
        public int ShifrMEssage(int textMessageRSA, int e, int n)
        {
            return Power(textMessageRSA, e, n);
        }

        /// <summary>
        /// Метод дешифровки сообщения
        /// </summary>
        /// <param name="textShifrRSA">Зашифрованное сообщение</param>
        /// <param name="d">приватный ключ d</param>
        /// <param name="n">приватный ключ n</param>
        /// <returns></returns>
        public int DeShifrMEssage(int textShifrRSA, int d, int n)
        {
            return Power(textShifrRSA, d, n);
        }
    }
}
