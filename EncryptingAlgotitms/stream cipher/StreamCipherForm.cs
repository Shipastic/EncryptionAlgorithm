using System;
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
            cipherClass.OriginalMessage = textMessageT.Text;

            cipherClass.Key = textKeyViginT.Text;

            string err = cipherClass.CheckDataError();

            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }

            textGetKeyT.Text = cipherClass.Key;

            FillKeyTableT();

            FillGridT();
        }

        //=========================================================================
        /// <summary>
        /// Метод для заполнения ключевого грида
        /// </summary>
        /// <param name="key"></param>
        void FillKeyTableT()
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

            for (int col = 0; col < cipherClass.OriginalMessage.Length; col++)
            {
                gridV1.Columns.Add("col_" + col, cipherClass.OriginalMessage[col].ToString());

                gridV1.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Формируем строку с ключом в гриде
            string keyMessage = cipherClass.Key + cipherClass.OriginalMessage;

            gridV1.Rows.Add();


            gridV1.Rows[0].HeaderCell.Value = "Ключ: ";
            for (int col = 0; col < cipherClass.OriginalMessage.Length; col++)
            {
                gridV1[col, 0].Value = keyMessage[col % keyMessage.Length].ToString();
            }

            gridV1.Rows.Add();

            gridV1.Rows[1].HeaderCell.Value = "Шифр: ";

            cipherClass.Encrypt(cipherClass.OriginalMessage.Length, cipherClass.OriginalMessage, keyMessage, gridKey, gridV1);


            textGetShifrT.Text = cipherClass.Encrypt(cipherClass.OriginalMessage.Length, cipherClass.OriginalMessage, keyMessage, gridKey, gridV1);
        }

        //=========================================================================
        /// <summary>
        /// Метод для превода символов сообщения в верхний регистр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextKey_TextChanged(object sender, EventArgs e)
        {
            cipherClass.Key.ToUpper();
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

            FillKeyTableT();

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

                cipherClass.Decrypt(cipherClass.OriginalMessage.Length, cipherClass.Key.Length, 
                                    cipherClass.Key, textGetShifrT.Text, gridKey, gridV2);
           
                //Помещаем расшифрованное сообщение в текстовое поле
                textDeShifrT.Text = cipherClass.Decrypt(cipherClass.OriginalMessage.Length, cipherClass.Key.Length, 
                                                        cipherClass.Key, textGetShifrT.Text, gridKey, gridV2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

    }
}
