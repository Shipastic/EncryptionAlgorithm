using System.Windows.Forms;

namespace EncryptingAlgotitms
{
     public class BasePolyalphabeticClass : BaseClassEncrypting
    {
        /// <summary>
        /// Свойство для установки Исходнодного сообщения
        /// </summary>
        public new string OriginalMessage 
        { 
            get { return originalMessage; } 
            set 
            {
                if (originalMessage == string.Empty)
                {
                    MessageBox.Show("Вы не ввели сообщение для шифрования!");
                    return;
                }
                else
                    originalMessage = value;
            } 
        }

        /// <summary>
        /// Свойство для установки ключа
        /// </summary>
        public new string Key
        {
            get { return key; }
            set
            {
                if (key == string.Empty)
                {
                    MessageBox.Show("Вы не ввели Ключ");
                }
                else
                    key = value;
            }
        }

        /// <summary>
        /// Метод для шифрования
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="gridView1"></param>
        /// <param name="gridView2"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public virtual string Encrypt(int num1, int num2, DataGridView gridView1, DataGridView gridView2, string message)//Метод для зашифровки сообщения
        {
            return "Виртуальный метод Шифрования базового класса";
        }

        /// <summary>
        /// Метод для шифрования
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="message"></param>
        /// <param name="Keymessage"></param>
        /// <param name="gridView1"></param>
        /// <param name="gridView2"></param>
        /// <returns></returns>
        public virtual string Encrypt(int num1, string message, string Keymessage, DataGridView gridView1, DataGridView gridView2)//Метод для зашифровки сообщения
        {
            return "Виртуальный метод Шифрования базового класса";
        }

        /// <summary>
        /// Метод для дешифрования
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="gridView1"></param>
        /// <param name="gridView2"></param>
        /// <param name="messageShifr"></param>
        /// <returns></returns>
        public virtual string Decrypt(int num1, int num2, DataGridView gridView1, DataGridView gridView2, string messageShifr)//Метод для расшифровки сообщения
        {
            return "Виртуальный метод Дешифрования базового класса";
        }

        /// <summary>
        /// Метод для дешифрования
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="message"></param>
        /// <param name="messageShif"></param>
        /// <param name="gridView1"></param>
        /// <param name="gridView2"></param>
        /// <returns></returns>
        public virtual string Decrypt(int num1, int num2, string message, string messageShif, DataGridView gridView1, DataGridView gridView2)//Метод для расшифровки сообщения
        {
            return "Виртуальный метод Дешифрования базового класса";
        }
    }
}
