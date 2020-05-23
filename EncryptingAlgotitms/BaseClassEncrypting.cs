using System.Windows.Forms;

namespace EncryptingAlgotitms
{
      class BaseClassEncrypting
    {
        public string originalMessage; //Исходный текст

        public string cipherMessage;   //Зашифрованное сообщение

        public string key;             //Ключ для шифрования/дешифрования

        public string decryptedMessage;//Расшифрованный текст

        //Создаем свойства для полей класса
        public string OriginalMessage { get => originalMessage; set => originalMessage = value; }

        public string CipherMessage { get => cipherMessage;   set => cipherMessage = value; }

        public string Key { get => key; set => key = value; }

        public string DecryptedMessage { get => decryptedMessage;  set => decryptedMessage = value; }

        public virtual void Encrypt(string str1, string str2, DataGridView gridView) { }//Метод для зашифровки сообщения
  
        public virtual string Encrypt(int num1, int num2, DataGridView gridView) //Метод для зашифровки сообщения
        {
            return "Виртуальный метод Шифрования базового класса";
        }
        public virtual string Encrypt(int num1, int num2, DataGridView gridView1, DataGridView gridView2, string message)//Метод для зашифровки сообщения
        {
            return "Виртуальный метод Шифрования базового класса";
        }
    
        public virtual string Encrypt(int num1, string message, string Keymessage, DataGridView gridView1, DataGridView gridView2)//Метод для зашифровки сообщения
        {
            return "Виртуальный метод Шифрования базового класса";
        }
        public virtual string Decrypt(string str1, string str2, DataGridView gridView) //Метод для зашифровки сообщения
        {
            return "Виртуальный метод Шифрования базового класса";
        }
        public virtual string Decrypt(int num1, int num2, DataGridView gridView)//Метод для расшифровки сообщения
        {
            return "Виртуальный метод Дешифрования базового класса";
        }
        public virtual string Decrypt(int num1, int num2, DataGridView gridView1, DataGridView gridView2, string messageShifr)//Метод для расшифровки сообщения
        {
            return "Виртуальный метод Дешифрования базового класса";
        }

        public virtual string Decrypt(int num1, int num2, string message, string messageShif, DataGridView gridView1, DataGridView gridView2)//Метод для расшифровки сообщения
        {
            return "Виртуальный метод Дешифрования базового класса";
        }
        public virtual string CheckDataError(string mess, string key) //Метод для проверки входных данных
        {
            return "Виртуальный метод Дешифрования базового класса";
        }

    }
}
