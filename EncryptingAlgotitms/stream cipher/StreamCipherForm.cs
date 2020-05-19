using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptingAlgotitms.stream_cipher
{
    public partial class StreamCipherForm : Form
    {

        StreamCipherClass cipherClass = new StreamCipherClass();
        public StreamCipherForm()
        {
            InitializeComponent();
        }

        //Алфавит для шифрования
        readonly string abcT = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";

        //=========================================================================
        /// <summary>
        /// Обработчик кнопки Шифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShifrT_Click(object sender, EventArgs e)
        {
            if (textMessageT.TextLength == 0)
            { MessageBox.Show("Введите сообщение для зашифровки"); return; }

            if (textKeyViginT.TextLength == 0)
            { MessageBox.Show("Введите ключ"); return; }

            textGetKeyT.Text = textKeyViginT.Text;

            //=============================Вынести эти проверки в отдельный метод==============================

            // проверка на символы, отличные от символов алфавита
            foreach (var item in textKeyViginT.Text)
            {
                if (!abcT.Contains(item))
                {
                    MessageBox.Show("Введены недопустимые символы\nДоступны только буквы русского алфавита");

                    return;
                }
            }

            // проверка на символы, отличные от символов алфавита
            foreach (var item in textMessageT.Text)
            {
                if (!abcT.Contains(item))
                {
                    MessageBox.Show("Введены недопустимые символы\nДоступны только буквы русского алфавита");

                    return;
                }
            }

            FillKeyTableT(textKeyViginT.Text);

            FillGridT();
        }

        //=========================================================================
        /// <summary>
        /// Метод для заполнения ключевого грида
        /// </summary>
        /// <param name="key"></param>
        void FillKeyTableT(string key)
        {
            gridKey.Columns.Clear();

            gridKey.Rows.Clear();

            //установка алфавита в шапку таблицы
            for (int i = 0; i < abcT.Length; i++)
            {
                gridKey.Columns.Add("col_" + i, abcT[i].ToString());

                gridKey.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //установка ключа в шапку таблицы
            for (int j = 0; j < abcT.Length; j++)
            {
                gridKey.Rows.Add();

                gridKey.Rows[j].HeaderCell.Value = abcT[j].ToString();

                int p = j;

                if (p < 0) continue;

                for (int x = 0; x < abcT.Length; x++)
                {
                    gridKey[x, j].Value = abcT[(x + p) % abcT.Length].ToString();
                }
            }
        }

        //=========================================================================
        /// <summary>
        /// Метод для формирования грида с шифром
        /// </summary>
        void FillGridT()
        {
            gridV1.Columns.Clear();

            gridV1.Rows.Clear();

            for (int col = 0; col < textMessageT.TextLength; col++)
            {
                gridV1.Columns.Add("col_" + col, textMessageT.Text[col].ToString());

                gridV1.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Формируем строку с ключом в гриде
            string keyMessage = textKeyViginT.Text + textMessageT.Text;

            gridV1.Rows.Add();


            gridV1.Rows[0].HeaderCell.Value = "Ключ: ";
            for (int col = 0; col < textMessageT.TextLength; col++)
            {
                gridV1[col, 0].Value = keyMessage[col % keyMessage.Length].ToString();
            }

            gridV1.Rows.Add();

            gridV1.Rows[1].HeaderCell.Value = "Шифр: ";

            cipherClass.Encrypt(textMessageT.TextLength, textMessageT.Text, keyMessage, gridKey, gridV1);

            //string shifr = null;

            //for (int col = 0; col < textMessageT.TextLength; col++)
            //{
            //    string letter;

            //    if (abcT.Contains(textMessageT.Text[col]))
            //        letter = gridKey[abcT.IndexOf(textMessageT.Text[col]),
            //                         abcT.IndexOf(keyMessage[col])].Value.ToString();
            //    else
            //        letter = textMessageT.Text[col].ToString();

            //    gridV1[col, 1].Value = letter;

            //    shifr += letter;
            //}

            textGetShifrT.Text = cipherClass.Encrypt(textMessageT.TextLength, textMessageT.Text, keyMessage, gridKey, gridV1);
        }

        //=========================================================================
        /// <summary>
        /// Метод для превода символов сообщения в верхний регистр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextKey_TextChanged(object sender, EventArgs e)
        {
            textKeyViginT.Text.ToUpper();
        }

        //=========================================================================
        /// <summary>
        ///Обработчик кнопки Дешифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeShifrT_Click(object sender, EventArgs e)
        {
            if (textGetShifrT.Text == null)
            { MessageBox.Show("Введите сообщение для дешифровки"); return; }

            if (textGetKeyT.Text == null)
            { MessageBox.Show("Введите ключ"); return; }

            FillKeyTableT(textGetKeyT.Text);

            FillGrid2T();
        }

        //=========================================================================
        /// <summary>
        /// Метод для расшифровки сообщения
        /// </summary>
        void FillGrid2T()
        {
            gridV2.Columns.Clear();

            gridV2.Rows.Clear();

            for (int col = 0; col < textGetShifrT.TextLength; col++)
            {
                gridV2.Columns.Add("col_" + col, textGetShifrT.Text[col].ToString());

                gridV2.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            try
            {
                gridV2.Rows.Add();

                gridV2.Rows.Add();

                gridV2.Rows[1].HeaderCell.Value = "Текст: ";

                cipherClass.Decrypt(textMessageT.TextLength, textKeyViginT.TextLength, textKeyViginT.Text, textGetShifrT.Text, gridKey, gridV2);

                //string deshifr = null;

                //string letter = null;

                //string key = null;

                //string quest = null;

                //for (int col = 0; col < textMessageT.TextLength; col++)
                //{
                //    //Используем сначала символы ключа для формирования строки в гриде
                //    if (col < textKeyViginT.TextLength)

                //        // И помещаем их в переменную key
                //        key = textKeyViginT.Text[col].ToString();

                //    else

                //        // В противном случае,помещаем в переменную key те символы, которые зашифровали в первом гриде, из второй строки
                //        key = gridV2[col - textKeyViginT.Text.Length, 1].Value.ToString();

                //    //Добавляем в грид в первую строку полученные символы
                //    gridV2[col, 0].Value = key;

                //    //Помещаем в переменную тот символ. который собираемся дешифровать
                //    quest = textGetShifrT.Text[col].ToString();

                //    /*
                //     * В цикле проходимся по строкам ключевого грида
                //     * из первой строки грида получаем текущий символ
                //     * в ключевой таблице по полученному символу  выбираем столбец
                //     * в этом столбце находим символ, равный символу во второй строке грида
                //     * и записываем его в переменную letter
                //     */
                //    for (int row = 0; row < abcT.Length; row++)
                //    {
                //        if (gridKey[abcT.IndexOf(key), row].Value.ToString() == quest)
                //        {
                //            letter = abcT[row].ToString();

                //            break;
                //        }
                //    }
                //    //Добавляем расшифрованные символы во вторую строку грида
                //    gridV2[col, 1].Value = letter;

                //    //Формируем строку с расшифрованным сообщением
                //    deshifr += letter;
                //}

                //Помещаем расшифрованное сообщение в текстовое поле
                textDeShifrT.Text = cipherClass.Decrypt(textMessageT.TextLength, textKeyViginT.TextLength, textKeyViginT.Text, textGetShifrT.Text, gridKey, gridV2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

    }
}
