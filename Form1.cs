using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, float> _rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("http://api.nbp.pl/api/exchangerates/tables/a/");
            var rates = api.Descendants("Rate");
            foreach (var rate in rates)
            {
                if (rate.Element("Code") != null && rate.Element("Mid") != null)
                {
                    string code = rate.Element("Code").Value;
                    float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);
                    _rates.Add(code, mid);
                }
            }
            USD.Text = _rates["USD"].ToString();
            EUR.Text = _rates["EUR"].ToString();
            CHF.Text = _rates["CHF"].ToString();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
}