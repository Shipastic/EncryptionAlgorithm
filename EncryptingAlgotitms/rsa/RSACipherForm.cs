using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptingAlgotitms.rsa
{
    public partial class RSACipherForm : Form
    {

        RSAcipherClass rSAcipherClass = new RSAcipherClass();
        public RSACipherForm()
        {
            InitializeComponent();
        }


        //=====================================
        private void ButGenP_Click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateP();

            ShowNumber();
        }

        //=====================================
        private void ButGenQ_Click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateQ();

            ShowNumber();
        }

        //=====================================
        /// <summary>
        /// Конвертация и отображение значений в текстбоксах
        /// </summary>
        private void ShowNumber()
        {
            textP.Text = Show(rSAcipherClass.p);
            textQ.Text = Show(rSAcipherClass.q);
            textN.Text = Show(rSAcipherClass.n);
            textF.Text = Show(rSAcipherClass.f);
            textE.Clear();
            textD.Clear();
            textGetN_1.Text = textN.Text;
            textGetN_2.Text = textN.Text;
        }

        //=====================================
        /// <summary>
        /// Показ значений чисел E и D
        /// </summary>
        private void ShowKeys()
        {
            textE.Text = Show(rSAcipherClass.e);
            textD.Text = Show(rSAcipherClass.d);
            textGetE.Text = textE.Text;
            textGetD.Text = textD.Text;
        }

        //=====================================
        /// <summary>
        /// Метод, скрывающий ноль в textbox-e
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private string Show(int n)
        {
            if (n > 0)
                return n.ToString();
            else
                return "";
        }

        //=====================================
        private void ButGenE_Click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateE();

            ShowNumber();

            ShowKeys();
        }

        //=====================================
        private void Butfindd_click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateD();

            ShowNumber();

            ShowKeys();
        }


        //=====================================
        private void ButEncrypt_Click(object sender, EventArgs e)
        {
            FillGridRSA();//инициализация DataGrid
            ShifrRSA();// Шифрование
        }

        //=====================================
        /// <summary>
        /// Метод, добавляющий символы из сообщения в столбцы colLetter и colASCII
        /// </summary>
        void FillGridRSA()
        {
            //удаляем все строчки
            gridRSA.Rows.Clear();

            // для каждой буквы сообщения создаем строку в DataGrid
            for (int row = 0; row < textPublicMessage.TextLength; row++)
            {
                gridRSA.Rows.Add();
                //в столюец colLetter добавляем букву из сообщения
                gridRSA["colLetter", row].Value = textPublicMessage.Text[row];
                // в столбец colASCII добавляем код этой буквы
                gridRSA["colASCII", row].Value = Convert.ToInt32(textPublicMessage.Text[row]);
            }
        }

        //=====================================
        /// <summary>
        /// Метод Шифрования сообщения
        /// </summary>
        void ShifrRSA()
        {
            int e = int.Parse(textGetE.Text);
            int n = int.Parse(textGetN_1.Text);

            // перебираем все строки и конвертируем символы в них
            for (int row = 0; row < gridRSA.Rows.Count; row++)
            {
                // распарсим из столбца colASCII строки row 
                int openMessage = int.Parse(gridRSA["colASCII", row].Value.ToString());
                // Шифруем каждый символ
                int charEncrypting = rSAcipherClass.ShifrMEssage(openMessage, e, n);
                // В столбец colEncrypt добавляем полученное значение
                gridRSA["colEncrypt", row].Value = charEncrypting;
            }
        }

        //=====================================
        private void ButDecrypt_Click(object sender, EventArgs e)
        {
            // вызываем метод дешифрования
            DeShifrRSA();
        }

        //=====================================
        /// <summary>
        /// Метод дешифрования сообщения
        /// </summary>
        void DeShifrRSA()
        {
            int d = int.Parse(textGetD.Text);
            int n = int.Parse(textGetN_2.Text);
            string decryptMessage = "";
            for (int row = 0; row < gridRSA.Rows.Count; row++)
            {
                int charEncrypting = int.Parse(gridRSA["colEncrypt", row].Value.ToString());
                // Дешифруем сообщение
                int charDecrypting = rSAcipherClass.DeShifrMEssage(charEncrypting, d, n);
                // добавляем полученные символы в столбец colReLetter
                gridRSA["colDecrypt", row].Value = charDecrypting;
                gridRSA["colReLetter", row].Value = (char)charDecrypting;
                decryptMessage += (char)charDecrypting;
            }
            textPrivateMessage.Text = decryptMessage;
        }
    }
}
