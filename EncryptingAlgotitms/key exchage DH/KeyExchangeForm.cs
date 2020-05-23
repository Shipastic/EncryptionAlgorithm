using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptingAlgotitms.key_exchage_DH
{
    public partial class KeyExchangeForm : Form
    {
        KeyExchangeClass Kec = new KeyExchangeClass();

        static Random rand = new Random();
        long maxPrime = 100;
        long minPrime = 10;
        long p;
        long g;
        long X;
        long Y;

        public KeyExchangeForm()
        {
            InitializeComponent();
        }
        //========================================
        private void Label7_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label7, "X = G^A mod P");
        }

        //========================================
        private void Label8_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label8, "Y = G^B mod P");
        }

        //========================================
        private void Label9_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label9, "keyX = Y^А mod P = G^B^A mod P");
        }

        //========================================
        private void Label10_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label10, "keyY = X^B mod P = G^A^B mod P");
        }

        //========================================
        /// <summary>
        /// Метод для генерации простого числа P
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButP_Click(object sender, EventArgs e)
        {
            p = rand.Next((int)minPrime, (int)maxPrime);
            while (!Kec.IsPrime(p))
            {
                p++;
            }
            textP.Text = p.ToString();
        }

        //========================================
        /// <summary>
        /// Метод для генерации простого числа G
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButG_Click(object sender, EventArgs e)
        {
            g = rand.Next(2, (int)p);
            textG.Text = g.ToString();
        }

        //========================================
        /// <summary>
        /// Метод для генерации секретного числа A абонента 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenerateA_Click(object sender, EventArgs e)
        {
          Kec.GetPG(textP.Text, textG.Text);
           textA.Text = rand.Next(2, (int)p).ToString();
        }

        //========================================
        /// <summary>
        /// Метод для генерации секретного числа B абонента 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenetateB_Click(object sender, EventArgs e)
        {
            Kec.GetPG(textP.Text, textG.Text);
            textB.Text = rand.Next(2, (int)p).ToString();
        }

        //========================================
        /// <summary>
        /// Метод для генераци общего секретного ключа Абонента 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButKeyA_Click(object sender, EventArgs e)
        {
            long AKey = Kec.Powermod(Y, Convert.ToInt32(textA.Text));
            textKeyA.Text = Convert.ToString(AKey);
        }

        //========================================
        /// <summary>
        /// Метод для генераци общего секретного ключа Абонента 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButKeyB_Click(object sender, EventArgs e)
        {
            long bkey = Kec.Powermod(X, Convert.ToInt32(textB.Text));
            textKeyB.Text = Convert.ToString(bkey);
        }

        //========================================
        /// <summary>
        /// Метод для расчета числа для отправки Абонента 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenX_Click(object sender, EventArgs e)
        {
            Kec.GetPG(textP.Text, textG.Text); 
            X = Kec.Powermod(g, Convert.ToInt32(textA.Text));
            textX.Text = Convert.ToString(X);
        }

        //========================================
        /// <summary>
        /// Метод для расчета числа для отправки Абонента 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenY_Click(object sender, EventArgs e)
        {
            Kec.GetPG(textP.Text, textG.Text);
            Y = Kec.Powermod(g, Convert.ToInt32(textB.Text));
            textY.Text = Convert.ToString(Y);
        }

        //========================================
        /// <summary>
        /// Установка начальных значений  P и G
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DH_KeysChange_Load(object sender, EventArgs e)
        {
            //начальные значения по умолчанию
            textP.Text = 43.ToString();
            textG.Text = 17.ToString();
        }


    }
}
