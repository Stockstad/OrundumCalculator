namespace OrundumCalculator
{
    public partial class Form1 : Form
    {
        double total;
        double weekly = 71.42;
        double daily = 100;
        int targetDaysAway = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            int currentOP = (int)crntOP.Value;
            int currentOr = (int)crntOr.Value;
            int weeklyLim = (int)weeklyLimit.Value;

            total += currentOP * 180;
            total += currentOr;



            if (anniCheck.Checked)
            {
                total += Math.Ceiling(weeklyLim * ((double)targetDaysAway / 7));
            }

            TotalLabel.Text = total.ToString();

            total = 0;





        }
    }
}