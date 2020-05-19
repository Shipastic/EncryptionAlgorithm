using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptingAlgotitms.stream_cipher
{
    class StreamCipherClass : BaseClassEncrypting
    {
        //Алфавит для шифрования
        readonly string abcT = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";

//=========================================================================      
        /// <summary>
        /// Метод для шифрования
        /// </summary>
        /// <param name="messLength">длина исходного текта</param>
        /// <param name="message">исходное сообщение</param>
        /// <param name="keymessage">строка с ключом</param>
        /// <param name="gridViewKey">Ключевая таблица</param>
        /// <param name="gridView">сетка с шифром</param>
        /// <returns></returns>
        public override string Encrypt(int messLength, string message, string keymessage, DataGridView gridViewKey, DataGridView gridView)
        {
            string shifr = null;

            for (int col = 0; col < messLength; col++)
            {
                string letter;

                if (abcT.Contains(message[col]))
                    letter = gridViewKey[abcT.IndexOf(message[col]),
                                     abcT.IndexOf(keymessage[col])].Value.ToString();
                else
                    letter = message[col].ToString();

                gridView[col, 1].Value = letter;

                shifr += letter;
            }
            return shifr;
        }

//=========================================================================
        /// <summary>
        /// Метод для дешифровки сообщения
        /// </summary>
        /// <param name="message">исходное сообщение</param>
        /// <param name="keyLength">длина ключа</param>
        /// <param name="keyMessage">теключ</param>
        /// <param name="encryptMessage">зашифрованное сообщение</param>
        /// <param name="gridViewKey">Ключевой грид</param>
        /// <param name="gridView">Сетка с расшифрованным сообщением</param>
        /// <returns></returns>
        public override string Decrypt(int message, int keyLength, string keyMessage, string encryptMessage, DataGridView gridViewKey, DataGridView gridView)
        {

            string deshifr = null;

            string letter = null;

            string key = null;

            string quest = null;

            for (int col = 0; col < message; col++)
            {
                //Используем сначала символы ключа для формирования строки в гриде
                if (col < keyLength)

                    // И помещаем их в переменную key
                    key = keyMessage[col].ToString();

                else

                    // В противном случае,помещаем в переменную key те символы, которые зашифровали в первом гриде, из второй строки
                    key = gridView[col - keyLength, 1].Value.ToString();

                //Добавляем в грид в первую строку полученные символы
                gridView[col, 0].Value = key;

                //Помещаем в переменную тот символ. который собираемся дешифровать
                quest = encryptMessage[col].ToString();

                /*
                 * В цикле проходимся по строкам ключевого грида
                 * из первой строки грида получаем текущий символ
                 * в ключевой таблице по полученному символу  выбираем столбец
                 * в этом столбце находим символ, равный символу во второй строке грида
                 * и записываем его в переменную letter
                 */
                for (int row = 0; row < abcT.Length; row++)
                {
                    if (gridViewKey[abcT.IndexOf(key), row].Value.ToString() == quest)
                    {
                        letter = abcT[row].ToString();

                        break;
                    }
                }
                //Добавляем расшифрованные символы во вторую строку грида
                gridView[col, 1].Value = letter;

                //Формируем строку с расшифрованным сообщением
                deshifr += letter;
            }
            return deshifr;
        }

//=========================================================================
    }
}
