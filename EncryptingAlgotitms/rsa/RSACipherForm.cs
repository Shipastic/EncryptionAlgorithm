using System;
using System.Windows.Forms;

namespace EncryptingAlgotitms.rsa
{
    public partial class RSACipherForm : Form
    {
        //Создание экземпляра класса для доступа к его методам
        RSAcipherClass rSAcipherClass = new RSAcipherClass();
        public RSACipherForm()
        {
            InitializeComponent();
        }


//===========================================================================
        /// <summary>
        /// Обработчик кнопки Generate P
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenP_Click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateP();

            ShowNumber();
        }

//===========================================================================
        /// <summary>
        /// Обработчик кнопки Generate Q
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenQ_Click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateQ();

            ShowNumber();
        }

//===========================================================================
        /// <summary>
        ///Метод для вывода значений в текстбоксах
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

//===========================================================================
        /// <summary>
        /// Метод для  вывода значений чисел E и D
        /// </summary>
        private void ShowKeys()
        {
            textE.Text = Show(rSAcipherClass.e);
            textD.Text = Show(rSAcipherClass.d);
            textGetE.Text = textE.Text;
            textGetD.Text = textD.Text;
        }

//===========================================================================
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

//===========================================================================
        /// <summary>
        /// Обработчик кнопки Generate E
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenE_Click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateE();

            ShowNumber();

            ShowKeys();
        }

//===========================================================================
        /// <summary>
        /// Обработчик кнопки Calculate D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Butfindd_click(object sender, EventArgs e)
        {
            rSAcipherClass.GenerateD();

            ShowNumber();

            ShowKeys();
        }


//===========================================================================
        /// <summary>
        /// Обработчик кнопки Шифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButEncrypt_Click(object sender, EventArgs e)
        {
            FillGridRSA();//инициализация DataGrid
            rSAcipherClass.Encrypt(textGetE.Text, textGetN_1.Text, gridRSA);// Шифрование
        }

//===========================================================================
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

//===========================================================================
        /// <summary>
        /// Обработчик кнопки Дешифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButDecrypt_Click(object sender, EventArgs e)
        {
            // вызываем метод дешифрования
            textPrivateMessage.Text = rSAcipherClass.Decrypt(textGetD.Text, textGetN_2.Text, gridRSA);
          
        }
    }
}
