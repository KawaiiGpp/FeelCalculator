using FeelCalculator.Calculation;

namespace FeelCalculator.Forms
{
    public partial class MainForm : Form
    {
        private double? temperature;
        private double? humidity;
        private double? windSpeed;

        public MainForm()
        {
            InitializeComponent();
            ReadFromTextBoxes();
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
            => HandleInput(txtTemp.Text, ref temperature, null);

        private void txtHumidity_TextChanged(object sender, EventArgs e)
            => HandleInput(txtHumidity.Text, ref humidity, v => v >= 0 && v <= 100);

        private void txtWindSpeed_TextChanged(object sender, EventArgs e)
            => HandleInput(txtWindSpeed.Text, ref windSpeed, v => v >= 0);

        private void HandleInput(string input, ref double? value, Predicate<double>? predicate)
        {
            if (double.TryParse(input, out double parsed)
                && (predicate == null || predicate(parsed)))
            {
                value = parsed;

                Calculator? calculator = GetCalculator();
                if (calculator == null) return;

                lblResult.Text = $"{calculator.Calculate(out string mode):0.##}¡ãC [{mode}]";
            }
            else
            {
                value = null;
                lblResult.Text = "--";
            }
        }

        private void HandleKey(object sender, KeyEventArgs e)
            => HandleKey((TextBox)sender, e.KeyCode);

        private void HandleKey(Control control, Keys code)
        {
            if (!double.TryParse(control.Text, out double parsed)) return;

            switch (code)
            {
                case Keys.Up:
                    parsed += 1;
                    break;

                case Keys.Down:
                    parsed -= 1;
                    break;

                default:
                    return;
            }

            control.Text = parsed.ToString();
        }

        private void ReadFromTextBoxes()
        {
            if (txtTemp.Text.Length > 0)
                temperature = double.Parse(txtTemp.Text);
            if (txtHumidity.Text.Length > 0)
                humidity = double.Parse(txtHumidity.Text);
            if (txtWindSpeed.Text.Length > 0)
                windSpeed = double.Parse(txtWindSpeed.Text);
        }

        private Calculator? GetCalculator()
        {
            if (temperature != null && humidity != null && windSpeed != null)
                return new(temperature.Value, humidity.Value, windSpeed.Value);
            else return null;
        }
    }
}
