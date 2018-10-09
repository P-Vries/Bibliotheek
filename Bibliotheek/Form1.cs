using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        //Methodes
        //

        private void Bereken()
        {
            double uit = 0;
            if (rdbRoman.Checked)
            {
                if (DateTime.Now >= dateTimePicker1.Value.AddDays(21))
                {
                    byte dagen = (byte)(DateTime.Now.DayOfYear - dateTimePicker1.Value.DayOfYear);
                    uit = (dagen - 21) * 0.25;
                }
            }
            else if (rdbStudieboeken.Checked)
            {
                int dagen = (DateTime.Now.DayOfYear - dateTimePicker1.Value.DayOfYear);
                if (dagen > 30)
                {
                    dagen = (dagen - 30);
                    int tussen = (dagen / 7);
                    tussen = (int)Decimal.Truncate(tussen);
                    if (dagen % 7 != 0)
                    {
                        tussen += 1;
                        uit = tussen;
                    }
                }
            }
            MessageBox.Show("U moet €" + uit + " betalen");
        }

        //
        //Events
        //

        private void btnBereken_Click(object sender, EventArgs e)
        {
            Bereken();
        }
    }
}
