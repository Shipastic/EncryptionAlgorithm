using EncryptingAlgotitms.key_exchage_DH;
using EncryptingAlgotitms.permutation_cipher;
using EncryptingAlgotitms.polyalphabetic_cipher;
using EncryptingAlgotitms.rsa;
using EncryptingAlgotitms.stream_cipher;
using System;
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
            PermutationCipher Pcv = new PermutationCipher
            {
                MdiParent = this
            };
            Pcv.Show();

        }
        private void PolyalphabeticCipherVigenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolyalphabeticCipherForm PolyalphaForm = new PolyalphabeticCipherForm
            {
                MdiParent = this
            };
            PolyalphaForm.Show();
        }

        private void StreamCipherVigenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamCipherForm Scf = new StreamCipherForm
            {
                MdiParent = this
            };
            Scf.Show();
        }

        private void KeyExchangeDiffiHallmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyExchangeForm Kef = new KeyExchangeForm
            {
                MdiParent = this
            };
            Kef.Show();
        }

        private void RSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSACipherForm rsaForm = new RSACipherForm
            {
                MdiParent = this
            };
            rsaForm.Show();
        }

        private void InformationAboutAlgorithmVigenera1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Help.ShowHelp(this, "MyHelp.chm");
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm Apf = new AboutProgramForm();
            Apf.ShowDialog();
        }
    }
}
