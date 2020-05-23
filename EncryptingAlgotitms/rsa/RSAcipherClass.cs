using System;
using System.Windows.Forms;

namespace EncryptingAlgotitms.rsa
{
    class RSAcipherClass:BaseClassEncrypting
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
        static readonly Random random = new Random();

//===========================================================================
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

//===========================================================================
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

//===========================================================================
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

//===========================================================================
        /// <summary>
        /// Метод для вычисления значений N и F
        /// </summary>
        public void CalcNumbers()
        {
            n = p * q;

            f = (p - 1) * (q - 1);
        }

//===========================================================================
        ///<summary>
        ///Метод нахождения нпибольшего общего делителя(алгоритм Евклида)
        ///</summary>
        public int GCD(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

//===========================================================================
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

//===========================================================================
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

//===========================================================================
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

//===========================================================================
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

//===========================================================================
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

//===========================================================================
        /// <summary>
        /// Метод Шифрования сообщения
        /// </summary>
        /// <param name="textE">Число E</param>
        /// <param name="textN">Число N</param>
        /// <param name="grdRsa">Сетка для вывода символов</param>
        public override void Encrypt(string textE, string textN, DataGridView grdRsa )
        {
            int e = int.Parse(textE);
            int n = int.Parse(textN);

            // перебираем все строки и конвертируем символы в них
            for (int row = 0; row < grdRsa.Rows.Count; row++)
            {
                // распарсим из столбца colASCII строки row 
                int openMessage = int.Parse(grdRsa["colASCII", row].Value.ToString());
                // Шифруем каждый символ
                int charEncrypting = ShifrMEssage(openMessage, e, n);
                // В столбец colEncrypt добавляем полученное значение
                grdRsa["colEncrypt", row].Value = charEncrypting;
            }
        }

//===========================================================================
        /// <summary>
        ///  Метод дешифрования сообщения
        /// </summary>
        /// <param name="textD">Число D</param>
        /// <param name="textN">Число N</param>
        /// <param name="grdRsa">Сетка для вывода символов</param>
        /// <returns></returns>
        public override string Decrypt(string textD, string textN, DataGridView grdRsa)
        {
            int d = int.Parse(textD);
            int n = int.Parse(textN);
            string decryptMessage = "";
            for (int row = 0; row < grdRsa.Rows.Count; row++)
            {
                int charEncrypting = int.Parse(grdRsa["colEncrypt", row].Value.ToString());
                // Дешифруем сообщение
                int charDecrypting = DeShifrMEssage(charEncrypting, d, n);
                // добавляем полученные символы в столбец colReLetter
                grdRsa["colDecrypt", row].Value = charDecrypting;
                grdRsa["colReLetter", row].Value = (char)charDecrypting;
                decryptMessage += (char)charDecrypting;
            }
              return decryptMessage;
        }
    }
}
