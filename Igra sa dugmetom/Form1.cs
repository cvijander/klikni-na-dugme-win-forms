namespace Igra_sa_dugmetom
{
    public partial class Form1 : Form
    {
        private int brojKlikova = 0;
        private int brojOtkucaja = 0;
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (brojKlikova == 0)
            {
                timer1.Enabled = true;
            }
            brojKlikova++;
            button1.Text = brojKlikova.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = r.Next(0, this.Width - 80);
            int y = r.Next(0, this.Height - 80);

            button1.Location = new Point(x, y);
            brojOtkucaja++;
            int vreme = (20 - brojOtkucaja) / 2;
            this.Text = "Klikni na dugme: " + vreme;
            if (brojOtkucaja == 20)
            {
                timer1.Enabled = false;
                MessageBox.Show("Vreme je isteklo");
                button1.Enabled = false;
            }
        }
    }
}