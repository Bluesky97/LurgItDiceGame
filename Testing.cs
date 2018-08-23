using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LurgItDiceGameAndrianThet
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = new int[] { 2, 4, 1, 3 };
            Array.Sort(array);
            for (int n = 0; n<array.Length; n++)
            {
                textBox1.Text = n.ToString();
            }
        }
    }
}
