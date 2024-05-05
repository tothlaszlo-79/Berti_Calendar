using enNamespace;
using Microsoft.EntityFrameworkCore;


namespace Berti_Calendar
{
    public partial class Form1 : Form
    {

        List<Foglalas> foglalasok = new List<Foglalas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kivalasztott_datum = monthCalendar1.SelectionStart;

            var foglalas = new Foglalas
            {
                Datum = kivalasztott_datum,
                Felhasznalo = "Felhasznalo",
                Musor = "Musor"
            };

            foglalasok.Add(foglalas);

            dataGridView1.DataSource = foglalasok.ToList();

        }

        class Foglalas
        {
            public DateTime Datum { get; set; }
            public string Felhasznalo { get; set; }
            public string Musor { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           cnContext context = new cnContext();
           //var ujSzoba = new Szoba { Szam = 101 };
           // context.Szobak.Add(ujSzoba);
           // context.SaveChanges();
            
            var szobak = context.Szobak.ToList();
            dataGridView1.DataSource = szobak;
        }
    }
}
