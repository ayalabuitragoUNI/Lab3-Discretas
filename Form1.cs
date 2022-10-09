using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Discretas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // SETS
        List<string> A = new List<string>();
        List<string> B = new List<string>();

        private void tbAddA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(tbAddA.Text))
                {
                    A.Add(tbAddA.Text);

                    LbA.DataSource = null;
                    LbA.DataSource = A;

                    tbAddA.Clear();
                    tbAddA.Focus();
                }
            }
        }

        private void BtnAddA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAddA.Text))
            {
                A.Add(tbAddA.Text);

                LbA.DataSource = null;
                LbA.DataSource = A;

                tbAddA.Clear();
                tbAddA.Focus();
            }
        }

        private void tbAddB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(tbAddB.Text))
                {
                    B.Add(tbAddB.Text);

                    LbB.DataSource = null;
                    LbB.DataSource = B;

                    tbAddB.Clear();
                    tbAddB.Focus();
                }
            }
        }

        private void BtnAddB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAddB.Text))
            {
                B.Add(tbAddB.Text);

                LbB.DataSource = null;
                LbB.DataSource = B;

                tbAddB.Clear();
                tbAddB.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // validaciones
            if( LbA.Items.Count == 0)
            {
                MessageBox.Show("El conjunto A debe tener al menos un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if( LbB.Items.Count == 0)
            {
                MessageBox.Show("El conjunto B debe tener al menos un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open cartesiano
            Producto_Cartesiano frm = new Producto_Cartesiano();
            frm.A = A;
            frm.B = B;

            frm.ShowDialog();
        }

        private void BtnCleanA_Click(object sender, EventArgs e)
        {
            this.A.Clear();
            LbA.DataSource = null;
        }

        private void BtnCleanB_Click(object sender, EventArgs e)
        {
            this.B.Clear();
            LbB.DataSource = null;
        }
    }
}
