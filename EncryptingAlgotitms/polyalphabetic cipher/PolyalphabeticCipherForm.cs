using System;
using System.Windows.Forms;

namespace EncryptingAlgotitms.polyalphabetic_cipher
{
    public partial class PolyalphabeticCipherForm : Form
    {
        PolyalphabeticCipherClass polyalphabetic = new PolyalphabeticCipherClass();
        public PolyalphabeticCipherForm()
        {
            InitializeComponent();
        }

        readonly string abc = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";

//=========================================================================
        /// <summary>
        /// Обработчик кнопки Шифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShifr_Click(object sender, EventArgs e)
        {

            polyalphabetic.OriginalMessage = textMessage.Text;

            polyalphabetic.Key = textKeyVigin.Text;

            string err = polyalphabetic.CheckDataError(polyalphabetic.OriginalMessage, polyalphabetic.Key);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }

            textGetKey.Text = textKeyVigin.Text;

            FillKeyTable(textKeyVigin.Text);

            FillGrid();
        }

//=========================================================================
        /// <summary>
        /// Метод для заполнения ключевого грида
        /// </summary>
        /// <param name="key">ключ</param>
        void FillKeyTable(string key)
        {
            //Очищаем грид
            gridKey.Columns.Clear();

            gridKey.Rows.Clear();

            //установка  букв алфавита в шапку столбцов таблицы
            AddColumns(gridKey, abc);

            //установка букв ключа в отдельную строку таблицы
            for (int row = 0; row < key.Length; row++)
            {
                gridKey.Rows.Add();

                //Добавляем в заголовок строки букву ключа
                gridKey.Rows[row].HeaderCell.Value = key[row].ToString();

                //В переменную запоминаем смещение относительно алфавита
                int p = abc.IndexOf(key[row]);  

                if (p < 0) continue;

                for (int col = 0; col < abc.Length; col++)
                {
                    //Записываем в грид строку символов алфавита, начиная  со смещения P
                    gridKey[col, row].Value = abc[(col + p) % abc.Length].ToString();    
                }
            }
        }

//=========================================================================
        /// <summary>
        /// Метод для заполнения первого грида
        /// </summary>
        void FillGrid()
        {
            //Очищаем грид
            gridV1.Columns.Clear();

            gridV1.Rows.Clear();

            /*
             * Заполняем грид символами из сообщения
             * Количество столбцов равно количеству букв в сообщении
             */
            AddColumns(gridV1, textMessage.Text);

            /*
             * Заполняем строку грида символами из ключа 
             * под соответствующими символами из сообщения 
             */
            gridV1.Rows.Add();

            gridV1.Rows[0].HeaderCell.Value = "Ключ: "; //Создаем заголовочный столбец

            for (int col = 0; col < textMessage.TextLength; col++)
            {
                //Номеру строки присваиваем 0, т.е. строка не будет меняться в цикле
                gridV1[col, 0].Value = textKeyVigin.Text[col % textKeyVigin.TextLength].ToString();
            }

            // Добавляем строку, в которую будет записываться шифр
            gridV1.Rows.Add();

            gridV1.Rows[1].HeaderCell.Value = "Шифр: ";

            polyalphabetic.Encrypt(textMessage.TextLength, textKeyVigin.TextLength, gridKey, gridV1, textMessage.Text);

            // Помещаем шифр в текстовое поле
            textGetShifr.Text = polyalphabetic.Encrypt(textMessage.TextLength, 
                                                       textKeyVigin.TextLength, gridKey, gridV1, textMessage.Text);
        }

//=========================================================================
        /// <summary>
        /// Метод для конвертайии вводимых символов в ерхней регистр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextKey_TextChanged(object sender, EventArgs e)
        {
            textKeyVigin.Text.ToUpper();
        }

//=========================================================================
        /// <summary>
        /// Обработчик кнопки дешифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeShifr_Click(object sender, EventArgs e)
        {
            polyalphabetic.CipherMessage = textGetShifr.Text;

            polyalphabetic.Key = textGetKey.Text;


            string err = polyalphabetic.CheckDataError(polyalphabetic.CipherMessage, polyalphabetic.Key);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }

            if (polyalphabetic.Key == null)
            { MessageBox.Show("введите ключ"); return; }

            FillKeyTable(textGetKey.Text);

            FillGrid2();

            MessageBox.Show("Расшифрованное сообщение: " + textDeShifr.Text);
        }

//=========================================================================
        /// <summary>
        /// Метод для заполнения второго грида
        /// </summary>
        void FillGrid2()
        {

            gridV2.Columns.Clear();

            gridV2.Rows.Clear();

            AddColumns(gridV2, textGetShifr.Text);

            try
            {
                gridV2.Rows.Add();

                gridV2.Rows[0].HeaderCell.Value = "Ключ: ";

                for (int col = 0; col < textGetShifr.TextLength; col++)
                {
                    gridV2[col, 0].Value = textGetKey.Text[col % textGetKey.TextLength].ToString();
                }

                gridV2.Rows.Add();

                gridV2.Rows[1].HeaderCell.Value = "Текст: ";

                polyalphabetic.Decrypt(textMessage.TextLength, textGetKey.TextLength, gridKey, gridV2, textGetShifr.Text);     

        textDeShifr.Text = polyalphabetic.Decrypt(textMessage.TextLength, textGetKey.TextLength, gridKey, gridV2, textGetShifr.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

//=========================================================================
        /// <summary>
        /// Метод для добавления строк
        /// </summary>
        /// <param name="grid">сетка</param>
        /// <param name="letters">строка, из которой формируеются заголовки столбцов в гриде</param>
        private void AddColumns(DataGridView grid, string letters)
        {
            grid.Columns.Clear();

            for (int j = 0; j < letters.Length; j++)
            {
                grid.Columns.Add("", letters[j].ToString());

                //запретить сортировку в гриде по столбцам
                grid.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable; 
            }
        }


    }
}
