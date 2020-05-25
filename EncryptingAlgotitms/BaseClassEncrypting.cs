using System.Windows.Forms;

namespace EncryptingAlgotitms
{
    public class BaseClassEncrypting
    {
        public string originalMessage; //Исходный текст

        public string key;             //Ключ для шифрования/дешифрования

        string abcSymbol = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; //Алфавит для шифрования


        //Создаем свойства для полей класса
        public string AbcSymbol { get; set; }

        public string OriginalMessage { get => originalMessage; set => originalMessage = value; }

        public string Key { get => key; set => key = value; }

        // Перегруженные методы
        public virtual void Encrypt(string str1, string str2, DataGridView gridView) { }//Метод для зашифровки сообщения
  
        public virtual string Encrypt(int num1, int num2, DataGridView gridView) //Метод для зашифровки сообщения
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
        public virtual string CheckDataError() //Метод для проверки входных данных
        {
            return "Виртуальный метод Дешифрования базового класса";
        }

    }
}
