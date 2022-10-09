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
    public partial class Producto_Cartesiano : Form
    {
        public Producto_Cartesiano()
        {
            InitializeComponent();
        }

        // Sets
        public List<string> A = new List<string>();
        public List<string> B = new List<string>();

        private void Producto_Cartesiano_Load(object sender, EventArgs e)
        {
            // calculate producto cartesiano

            List<string> AxA = new List<string>();
            List<string> AxB = new List<string>();
            List<string> BxA = new List<string>();
            List<string> BxB = new List<string>();


            // AxA
            foreach (var factor1 in A.ToArray())
            {
                foreach (var factor2 in A.ToArray())
                {
                    AxA.Add("(" + factor1 + ", " + factor2 + ")");
                }
            }


            // AxB
            foreach (var factor1 in A.ToArray())
            {
                foreach (var factor2 in B.ToArray())
                {
                    AxB.Add("(" + factor1 + ", " + factor2 + ")");
                }
            }

            // BxA
            foreach (var factor1 in B.ToArray())
            {
                foreach (var factor2 in A.ToArray())
                {
                    BxA.Add("(" + factor1 + ", " + factor2 + ")");
                }
            }

            // BxB
            foreach (var factor1 in B.ToArray())
            {
                foreach (var factor2 in B.ToArray())
                {
                    BxB.Add("(" + factor1 + ", " + factor2 + ")");
                }
            }

            // print result into ListBox
            LbAxA.DataSource = AxA;
            LbAxB.DataSource = AxB;
            LbBxA.DataSource = BxA;
            LbBxB.DataSource = BxB;

        }
    }
}
