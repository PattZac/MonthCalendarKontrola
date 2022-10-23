using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan datum = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;
            if (datum.Days < 1) {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.","Oprez");
            } 
            else {
                MessageBox.Show("Rezervirali ste usluge u trajanju od "+ datum.Days.ToString() + " dana.", "Rezervacija");
                MessageBox.Show("Vasa rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " a završava se " + monthCalendar1.SelectionEnd.ToShortDateString() + ".", "Rezervacija");
            }
        }
    }
}
