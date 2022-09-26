namespace Практическое_задание_12._Тест_дизайн_
{
    public partial class Saytu : Form
    {
        DateTime dataDenirogdeniya;
        TimeSpan res;
        public Saytu()
        {
            InitializeComponent();
        }

        public void ACT(DateTime dataDenirogdeniya, TimeSpan res) 
        {
            res = DateTime.Today - dataDenirogdeniya;
            if (res.Days / 365 >= 18)
            {
                if (dataDenirogdeniya.Year < 1900)
                {
                    System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/%D0%9F%D0%B5%D1%80%D0%B2%D0%B0%D1%8F_%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%8F_%D0%B2%D0%BE%D0%B9%D0%BD%D0%B0");
                }
                else
                {
                    System.Diagnostics.Process.Start("http://test.it-online-school.ru/");
                }
            }
            else
            {
                if (dataDenirogdeniya > DateTime.Today)
                {
                    MessageBox.Show("Вы ввели недопустимую дату.", "Неверный ввод даты рождения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    System.Diagnostics.Process.Start("https://pl.spb.ru/");
                }
            }
        }

        private void Saytu_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.Data.Clear();
            this.Data.Text = "31.12.2020";
            this.Data.ForeColor = Color.Red;
            this.BT.Focus();

            //if (this.Saytu.Text == "")
            //{
            //    this.Saytu.Text = "31.12.2020 ";
            //    this.Saytu.ForeColor = Color.LightGray;
            //}
        }

        private void BT_Click(object sender, EventArgs e)
        {
            if (this.Data.Text.Length <= 10)
            {
                if (this.Data.Text.Length > 4)
                {
                    try
                    {
                        if (this.Data.ForeColor == Color.LightGray)
                        {
                            return;
                        }
                        if (this.Data.Text.Contains(','))
                        {
                            this.Data.Text.Replace(",", ".");
                        }
                        dataDenirogdeniya = Convert.ToDateTime(this.Data.Text);
                        ACT(dataDenirogdeniya, res);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Вы ввели недопустимую дату.", "Неверный ввод даты рождения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Дата слишком короткая.", "Неверный ввод даты рождения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Дата слишком длинная.", "Неверный ввод даты рождения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void Data_Enter(object sender, EventArgs e)
        {
            if (this.Data.Text == "31.12.2020 ")
            {
                this.Data.Clear();
                this.Data.ForeColor = Color.Black;
            }
        }

        private void Data_Leave(object sender, EventArgs e)
        {
            if (this.Data.Text == "")
            {
                this.Data.Text = "31.12.2020";
                this.Data.ForeColor = Color.Black;
            }
        }
    }
}