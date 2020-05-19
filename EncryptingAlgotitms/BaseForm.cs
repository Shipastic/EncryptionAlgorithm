using EncryptingAlgotitms.key_exchage_DH;
using EncryptingAlgotitms.permutation_cipher;
using EncryptingAlgotitms.polyalphabetic_cipher;
using EncryptingAlgotitms.rsa;
using EncryptingAlgotitms.stream_cipher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptingAlgotitms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void PermutationCipherVigenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermutationCipherVigener Pcv = new PermutationCipherVigener
            {
                MdiParent = this
            };
            Pcv.Show();

        }
        private void polyalphabeticCipherVigenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolyalphabeticCipherForm PolyalphaForm = new PolyalphabeticCipherForm
            {
                MdiParent = this
            };
            PolyalphaForm.Show();
        }

        private void streamCipherVigenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamCipherForm Scf = new StreamCipherForm
            {
                MdiParent = this
            };
            Scf.Show();
        }

        private void keyExchangeDiffiHallmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyExchangeForm Kef = new KeyExchangeForm
            {
                MdiParent = this
            };
            Kef.Show();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSACipherForm rsaForm = new RSACipherForm
            {
                MdiParent = this
            };
            rsaForm.Show();
        }
    }
}
