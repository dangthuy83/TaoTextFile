using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ds_in_bu
{
    public partial class FrmDS : Form
    {
        public FrmDS()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, EventArgs e) => Close();
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxbSerial.Text = "";
            TxbSLThe.Text = "";
            TxbSLTam.Text = "";
        }
        private void BtnXoaDS_Click(object sender, EventArgs e) => LsbDS.Items.Clear();
        private void BtnTaoDS_Click(object sender, EventArgs e)
        {
            long serial = Convert.ToInt64(TxbSerial.Text);
            long sothe = Convert.ToInt64(TxbSLThe.Text);
            long sltam = Convert.ToInt64(TxbSLTam.Text);
            int i;
            LsbDS.Items.Add(serial);
            for (i = 1; i < sltam; i++)
            {
                serial = serial + sothe;
                LsbDS.Items.Add(serial);
            }
        }

        private void BtnXuatFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Doccument(*.txt)|*.txt|All File(*.*)|*.*", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        using (TextWriter tw = new StreamWriter((fs), Encoding.UTF8)) 
                        {
                            foreach (var item in LsbDS.Items)
                            {
                                tw.WriteLine(item);
                            }
                            MessageBox.Show("Successfull");
                        }
                    }
                }
            }
        }
    }         
}
