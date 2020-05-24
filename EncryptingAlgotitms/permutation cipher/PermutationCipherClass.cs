using System;
using System.Text;
using System.Windows.Forms;

namespace EncryptingAlgotitms.permutation_cipher
{
    public class PermutationCipherClass : BaseClassEncrypting
    {
 
        //================================================================================================================================
        /// <summary>
        /// Метод для зашифровки текста
        /// </summary>
        /// <param name="colCount">количество столбцов в гриде</param>
        /// <param name="rowCount">количество строк в гриде</param>
        /// <returns></returns>
        public override string Encrypt(int colCount, int rowCount, DataGridView gridView)
        {
            //формируем строку
            // Обход двухмерного массива с записью значений в переменную strShifr
            StringBuilder sb = new StringBuilder();

            for (int col = 0; col < colCount; col++)
                for (int row = 0; row < rowCount; row++)
                { 
                    sb.Append(gridView[col, row].Value);
                }

            return sb.ToString();

        }

//================================================================================================================================
        /// <summary>
        /// Метод для зашифровки сообщения
        /// </summary>
        /// <param name="rowCount">количество строк</param>
        /// <param name="keyLength">длина ключа</param>
        /// <returns></returns>
        public override string Decrypt(int rowCount, int keyLength, DataGridView gridView)
        {
            _ = new int[rowCount, keyLength];

            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < rowCount; row++)
                for (int col = 0; col < keyLength; col++)
                {
                    sb.Append(gridView[col, row].Value);
                }
            return sb.ToString();

        }

//================================================================================================================================
        /// <summary>
        /// Метод для проверки одинаковых символов в ключе
        /// </summary>
        /// <param name="text">Ключ</param>
        /// <returns></returns>
        public bool IsEqualsLetters(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Substring(i + 1).IndexOf(text[i]) >= 0)
                    return true;
            }
            return false;
        }

//================================================================================================================================
        /// <summary>
        /// Метод для проверки входных данных
        /// </summary>
        /// <param name="MessageText">сообщение</param>
        /// <param name="KeyMessage">ключ</param>
        /// <returns></returns>
        public override string CheckDataError()
        {
            if (OriginalMessage == string.Empty)
            {
                return "Введите сообщение для зашифровки";
            }

            if (IsEqualsLetters(Key))
            {
                return "В ключе не должны повторяться символы!!!";
            }

            return "";
        }

//================================================================================================================================
        /// <summary>
        /// Метод для сортировки ключа по алфавиту
        /// </summary>
        /// <param name="text">ключ</param>
        /// <returns></returns>
        public string GetABC(string text)
        {
            char[] ch = text.ToCharArray(); // Переводим сообщение в массив символов

            Array.Sort(ch); //Делаем сортировку массива

            return new string(ch);   //Конвертируем в строку и возвращаем
        }

    }

}
