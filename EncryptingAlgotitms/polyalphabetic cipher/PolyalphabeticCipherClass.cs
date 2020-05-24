using System;
using System.Linq;
using System.Windows.Forms;

namespace EncryptingAlgotitms.polyalphabetic_cipher
{
    class PolyalphabeticCipherClass : BaseClassEncrypting
    {

        string abc = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

//================================================================================================================================
        /// <summary>
        /// Метод для шифрования сообщения
        /// </summary>
        /// <param name="messLength">длина шифруемого сообщения</param>
        /// <param name="messageKeyLength">длина ключа</param>
        /// <param name="gridViewKey">Ключевая сетка</param>
        /// <param name="gridView">Сетка для формирования шифра</param>
        /// <param name="message">Шифруемое сообщение</param>
        /// <returns></returns>
        public override string Encrypt(int messLength, int messageKeyLength, DataGridView gridViewKey, DataGridView gridView, string message)
        {
            

            string shifr = null;    //Строка для формирования шифрованного сообщения

            char letter;            //Переменная для хранения текущего символа шифра

            for (int col = 0; col < messLength; col++)
            {

                //Проверяем, содержится ли буква сообщения в нашем алфавите
                if (abc.Contains(message[col]))
                {
                    /*
                     * Нужный зашифрованный символ находится
                     * на пересечении символов ключа и сообщения
                     * в ключевом гриде
                     */
                    letter = Convert.ToChar(gridViewKey[abc.IndexOf(message[col]),       // Из нашего алфавита получаем индекс текущего символа - получаем столбец
                                            col % messageKeyLength].Value.ToString());
                }
                else
                    // Если в нашем алфавите отсутствует символ из сообщения, то добавляем его как есть
                    letter = Convert.ToChar(message[col].ToString());

                // Добавляем шифрованный символ в грид
                gridView[col, 1].Value = letter;

                // Формируем строку с шифром
                shifr += letter;

            }
            return shifr;
        }

//================================================================================================================================
        /// <summary>
        /// Метод для дешифрования сообщения
        /// </summary>
        /// <param name="messLength">длина сообщения</param>
        /// <param name="messageGetKeyLength">длина ключа</param>
        /// <param name="gridViewKey">Ключевая сетка</param>
        /// <param name="gridView">Сетка для формирования расшифрованного сообщения</param>
        /// <param name="messageShifr">Зашифрованное сообщение</param>
        /// <returns></returns>
        public override string Decrypt(int messLength, int messageGetKeyLength, DataGridView gridViewKey, DataGridView gridView, string messageShifr)
        {
            string deshifr = null;

            string letter = null;

            for (int col = 0; col < messLength; col++)
            {
                if (abc.Contains(messageShifr[col]))
                {
                    for (int k = 0; k < abc.Length; k++)
                        if (gridViewKey[k, col % messageGetKeyLength].Value.ToString() == messageShifr[col].ToString())
                        {
                            letter = abc[k].ToString();

                            break;
                        }
                }
                else
                    letter = messageShifr[col].ToString();

                gridView[col, 1].Value = letter;

                deshifr += letter;
            }
            return deshifr;
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
            foreach (var item in OriginalMessage)
            {
                if (!abc.Contains(item))
                {
                    return "Введены недопустимые символы";
                }
            }

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
    }
}
