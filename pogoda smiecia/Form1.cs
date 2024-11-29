using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace pogoda_smiecia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> kody = new Dictionary<int, string>
        {
            { 0, "Czyste niebo" },
            { 1, "Głównie czysto" },
            { 2, "Częściowo pochmurno" },
            { 3, "Całkowicie pochmurno" },
            { 45, "Mgła i osadzająca się szadź" },
            { 48, "Mgła i osadzająca się szadź" },
            { 51, "Mżawka: Lekka intensywność" },
            { 53, "Mżawka: Umiarkowana intensywność" },
            { 55, "Mżawka: Gęsta intensywność" },
            { 56, "Mżawka lodowa: Lekka intensywność" },
            { 57, "Mżawka lodowa: Gęsta intensywność" },
            { 61, "Deszcz: Lekka intensywność" },
            { 63, "Deszcz: Umiarkowana intensywność" },
            { 65, "Deszcz: Silna intensywność" },
            { 66, "Deszcz lodowy: Lekka intensywność" },
            { 67, "Deszcz lodowy: Silna intensywność" },
            { 71, "Opady śniegu: Lekka intensywność" },
            { 73, "Opady śniegu: Umiarkowana intensywność" },
            { 75, "Opady śniegu: Silna intensywność" },
            { 77, "Kryształki śniegu" },
            { 80, "Przelotne opady deszczu: Lekkie" },
            { 81, "Przelotne opady deszczu: Umiarkowane" },
            { 82, "Przelotne opady deszczu: Gwałtowne" },
            { 85, "Przelotne opady śniegu: Lekkie" },
            { 86, "Przelotne opady śniegu: Silne" },
            { 95, "Burza: Lekka lub umiarkowana" },
            { 96, "Burza z lekkim gradem" },
            { 99, "Burza z silnym gradem" }
        };

        private string[] dir = ["N", "E", "S", "W"]; 

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m&forecast_days=1";
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            richTextBox1.Text = json;
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            TemperatureTextBox.Text = apiResponse.current.temperature_2m.ToString();
            TemperatureTextBox.Text += " ";
            TemperatureTextBox.Text += apiResponse.current_units.temperature_2m;
            WilgorTextbox.Text = apiResponse.current.relative_humidity_2m.ToString() + " " + apiResponse.current_units.relative_humidity_2m;
            PogodaTextBox.Text += kody[apiResponse.current.weather_code];
            PredkoscTextBox.Text = apiResponse.current.wind_speed_10m.ToString() + " " + apiResponse.current_units.wind_speed_10m;
            KierunekTextBox.Text = dir[(int)Math.Round((double)(apiResponse.current.wind_direction_10m / 90)) % 4]; 


        }
    }



}
