namespace MyType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTextBoxValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int plusIndex = comboBoxOperation.Items.IndexOf("+");
            comboBoxOperation.SelectedIndex = plusIndex;
        }
        private void LoadTextBoxValues()
        {
            textBoxNum1.Text = Properties.Settings.Default.textBoxNum1;
            textBoxDen1.Text = Properties.Settings.Default.textBoxDen1;
            textBoxNum2.Text = Properties.Settings.Default.textBoxNum2;
            textBoxDen2.Text = Properties.Settings.Default.textBoxDen2;
        }

        private void SaveTextBoxValues()
        {
            Properties.Settings.Default.textBoxNum1 = textBoxNum1.Text;
            Properties.Settings.Default.textBoxDen1 = textBoxDen1.Text;
            Properties.Settings.Default.textBoxNum2 = textBoxNum2.Text;
            Properties.Settings.Default.textBoxDen2 = textBoxDen2.Text;
            Properties.Settings.Default.Save();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) ||
    string.IsNullOrWhiteSpace(textBoxDen1.Text) ||
    string.IsNullOrWhiteSpace(textBoxNum2.Text) ||
    string.IsNullOrWhiteSpace(textBoxDen2.Text))
            {
                MessageBox.Show("Значения не могут быть пустыми.");
                return;
            }

            int num1 = int.Parse(textBoxNum1.Text);
            int den1 = int.Parse(textBoxDen1.Text);
            int num2 = int.Parse(textBoxNum2.Text);
            int den2 = int.Parse(textBoxDen2.Text);
            if ((num1 >= den1) || (num2 >= den2))
            {
                MessageBox.Show("Числитель дроби должен быть меньше знаменателя.");
                return;
            }


            try
            {

                Fraction fraction1 = new Fraction(num1, den1);
                Fraction fraction2 = new Fraction(num2, den2);

                Fraction result;
                string operation = comboBoxOperation.SelectedItem.ToString();

                switch (operation)
                {
                    case "+":
                        result = fraction1 + fraction2;
                        break;
                    case "-":
                        result = fraction1 - fraction2;
                        break;
                    case "*":
                        result = fraction1 * fraction2;
                        break;
                    case "/":
                        result = fraction1 / fraction2;
                        break;
                    default:
                        throw new ArgumentException("Неправильная операция");
                }


                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) ||
    string.IsNullOrWhiteSpace(textBoxDen1.Text) ||
    string.IsNullOrWhiteSpace(textBoxNum2.Text) ||
    string.IsNullOrWhiteSpace(textBoxDen2.Text))
            {
                MessageBox.Show("Значения не могут быть пустыми.");
                return;
            }

            int num1 = int.Parse(textBoxNum1.Text);
            int den1 = int.Parse(textBoxDen1.Text);
            int num2 = int.Parse(textBoxNum2.Text);
            int den2 = int.Parse(textBoxDen2.Text);
            if ((num1 >= den1) || (num2 >= den2))
            {
                MessageBox.Show("Числитель дроби должен быть меньше знаменателя.");
                return;
            }
            try
            {

                Fraction fraction1 = new Fraction(num1, den1);
                Fraction fraction2 = new Fraction(num2, den2);

                int comparisonResult = fraction1.CompareTo(fraction2);

                if (comparisonResult < 0)
                    lblResult.Text = "Первая дробь меньше второй";
                else if (comparisonResult > 0)
                    lblResult.Text = "Первая дробь больше второй";
                else
                    lblResult.Text = "Дроби равны";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonSimplify_Click(object sender, EventArgs e)
        {
            try
            {
                string[] fractionParts = lblResult.Text.Split('/');

                if (fractionParts.Length == 2)
                {
                    int num = int.Parse(fractionParts[0]);
                    int den = int.Parse(fractionParts[1]);

                    Fraction fraction = new Fraction(num, den);

                    fraction.Simplify();

                    lblResult.Text = fraction.ToString();
                }
                else
                {
                    MessageBox.Show("В ответе находилась не дробь!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonSimplifyFractures_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) ||
    string.IsNullOrWhiteSpace(textBoxDen1.Text) ||
    string.IsNullOrWhiteSpace(textBoxNum2.Text) ||
    string.IsNullOrWhiteSpace(textBoxDen2.Text))
            {
                MessageBox.Show("Значения не могут быть пустыми.");
                return;
            }

            int num1 = int.Parse(textBoxNum1.Text);
            int den1 = int.Parse(textBoxDen1.Text);
            int num2 = int.Parse(textBoxNum2.Text);
            int den2 = int.Parse(textBoxDen2.Text);
            if ((num1 >= den1) || (num2 >= den2))
            {
                MessageBox.Show("Числитель дроби должен быть меньше знаменателя.");
                return;
            }
            try
            {

                Fraction fraction1 = new Fraction(num1, den1);
                fraction1.Simplify();
                Fraction fraction2 = new Fraction(num2, den2);
                fraction2.Simplify();

                textBoxNum1.Text = fraction1.Numerator.ToString();
                textBoxDen1.Text = fraction1.Denominator.ToString();
                textBoxNum2.Text = fraction2.Numerator.ToString();
                textBoxDen2.Text = fraction2.Denominator.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTextBoxValues();   
        }
    }
}

