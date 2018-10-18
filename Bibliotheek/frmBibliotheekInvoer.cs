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
    public partial class frmBibliotheekInvoer : Form
    {
        //
        //Vars
        //
        int code;
        public frmBibliotheekInvoer()
        {
            InitializeComponent();
        }
        //
        //Methodes
        //

       private int Boektype(int Boeknummer)
        {
            string nummer = Boeknummer.ToString().Substring(0, 1);
            return int.Parse(nummer);
        }

        private void Bereken()
        {
            try { code = int.Parse(txbIn.Text); }
            catch { MessageBox.Show("Ongeldig Boeknummer!"); }
            
            double uit = 0;
            if (Boektype(code) == 9)
            {
                if (DateTime.Now >= dateTimePicker1.Value.AddDays(21))
                {
                    byte dagen = (byte)(DateTime.Now.DayOfYear - dateTimePicker1.Value.DayOfYear);
                    uit = (dagen - 21) * 0.25;
                }
            }
            else if (Boektype(code) != 9)
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
