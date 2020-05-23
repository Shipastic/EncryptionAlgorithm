using System;
using System.Windows.Forms;

namespace EncryptingAlgotitms.permutation_cipher
{
    public partial class PermutationCipher : Form
    {
        PermutationCipherClass permutationCipherClass = new PermutationCipherClass();

        public PermutationCipher()
        {
            InitializeComponent();
        }
        //================================================================================================================================
        /// <summary>
        /// Обработчик кнопки Шифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShifr_Click(object sender, EventArgs e)
        {
            permutationCipherClass.OriginalMessage = textMessage.Text;

            permutationCipherClass.Key = textKey.Text;

            string err = permutationCipherClass.CheckDataError(permutationCipherClass.OriginalMessage, permutationCipherClass.Key);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }

            FillGrid1();

            //Помещаем отсортированный по алфавиту ключ в текстовое поле
            textKeyABC.Text = permutationCipherClass.GetABC(permutationCipherClass.Key);

            FillGrid2();

            // В текстовое поле помещаем сформированную шифрованную строку
            textShifr.Text = permutationCipherClass.Encrypt(grid2.ColumnCount, grid2.RowCount, grid2);

            textGetShifr.Text = textShifr.Text;

        }

//================================================================================================================================
        /// <summary>
        /// Обработчик кнопки расшифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeShifr_Click(object sender, EventArgs e)
        {
            if (textGetKey.Text == string.Empty || textGetShifr.Text == string.Empty)
            {
                MessageBox.Show("Введите данные для расшифровки");
                return;
            }
            //Помещаем отсортированный по алфавиту ключ в текстовое поле
            textGetKeyABC.Text = permutationCipherClass.GetABC(textGetKey.Text);

            FillGrid3();

            FillGrid4();

            //записываем расшифрованное сообщение в тестовое поле и удаляем лишние символы вконце
            textGetMessage.Text = permutationCipherClass.Decrypt(grid4.RowCount, textGetKeyABC.TextLength, grid4).TrimEnd('.');

            MessageBox.Show("Расшифрованное сообщение: " + textGetMessage.Text);
        }

//================================================================================================================================
        /// <summary>
        /// Метод для заполнения первого грида
        /// </summary>
        private void FillGrid1()
        {

            //Очищаем грид
            grid1.Columns.Clear();

            grid1.Rows.Clear();

            if (textKey.Text == string.Empty)
            {
                MessageBox.Show("Введите ключ!!");
            }

            AddColumns(grid1, permutationCipherClass.Key);

            int cols = textKey.TextLength;

            //Вычисляем количество строк
            int rows = textMessage.TextLength / cols;

            if (textMessage.TextLength % cols > 0)
            {
                rows++;
            }

            grid1.Rows.Add(rows);

            int row = 0; //нулевая строка

            int col = 0; //нулевой столбец

            for (int j = 0; j < textMessage.TextLength; j++)
            {
                col = j % cols; // вычисляем номер столбца

                row = j / cols; //вычисляем номер строки

                grid1[col, row].Value = textMessage.Text[j];
            }

            //Добавляем точки в конец, если длина сообщения не кратна длине ключа
            for (col++; col < textKey.TextLength; col++)
            {
                grid1[col, row].Value = '.';
            }

        }

//================================================================================================================================
        /// <summary>
        /// Метод для формирования второго грида
        /// </summary>
        private void FillGrid2()
        {

            AddColumns(grid2, textKeyABC.Text);

            try
            {
                grid2.Rows.Clear();

                grid2.Rows.Add(grid1.RowCount); //Добавляем такое же количество строк. как в первом гриде
            }
            catch (Exception)
            {
                MessageBox.Show("Введите текст!");
            }
            //установка алфавитного ключа в грид
            //Заполнение грида по  столбцу
            for (int columnIndex = 0; columnIndex < textKeyABC.TextLength; columnIndex++)
                // Заполнение грида по-строчно
                for (int rowIndex = 0; rowIndex < grid1.RowCount; rowIndex++)
                {
                    // В  ячейку грида записываем соответствующее значение для данного символа из первого грида
                    int colABC = permutationCipherClass.Key.IndexOf(textKeyABC.Text[columnIndex]);
                    grid2[columnIndex, rowIndex].Value = grid1[colABC, rowIndex].Value;
                }
        }

//================================================================================================================================
        /// <summary>
        /// Метод для формирования третьего грида
        /// </summary>
        private void FillGrid3()
        {
            AddColumns(grid3, textGetKeyABC.Text);

            grid3.Rows.Clear();

            int position = 0;

            int rows;

            // Высчитываем количество строк
            if (textGetKey.TextLength != 0 && textGetShifr.TextLength != 0)
            {
                rows = textGetShifr.TextLength / textGetKey.TextLength;
            }
            else return;

            //Добавляем полученное количество строк в грид
            grid3.Rows.Add(rows);


            //Для каждого символа ключа в гриде добавляем новый столбец
            for (int col = 0; col < textGetKey.TextLength; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    // Шифрованное сообщение посимвольно добавляем в грид
                    grid3[col, row].Value = textGetShifr.Text.Substring(position++, 1);
                }
            }
        }

//================================================================================================================================
        /// <summary>
        /// Метод для формирования четвертого грида
        /// </summary>
        private void FillGrid4()
        {
            AddColumns(grid4, textGetKey.Text);

            grid4.Rows.Clear();

            //добавляем количество строк равное числу строк в третьем гриде
            grid4.Rows.Add(grid3.Rows.Count);


            for (int col = 0; col < textGetKeyABC.TextLength; col++)
            {
                for (int row = 0; row < grid4.Rows.Count; row++)
                {
                    int colABC = textGetKeyABC.Text.IndexOf(textGetKey.Text[col]);// запоминаем номер столбца в переменную colABC
                    grid4[col, row].Value = grid3[colABC, row].Value;
                }
            }

        }

 //================================================================================================================================
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
                grid.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable; //запретить сортировку в гриде по столбцам
            }
        }
    }
}
