namespace CALCULATORproject
{

    public partial class Form1 : Form
    {
        string operation = "";
        double firstnumber;
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            store_txtbx.Clear();
            result_txtbx.Clear();
            firstnumber = 0;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            store_txtbx.Clear();
        }

        private void number1_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_txtbx_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void remainder_btn_Click(object sender, EventArgs e)
        {

        }

        private void number_txtbx_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number2_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "-":
                    result_txtbx.Text = OPerations.Minus(firstnumber, double.Parse(store_txtbx.Text));
                    break;
                case "+":
                    result_txtbx.Text = OPerations.Sum(firstnumber, double.Parse(store_txtbx.Text));
                    break;
                case "X":
                    result_txtbx.Text = OPerations.Multi(firstnumber, double.Parse(store_txtbx.Text));
                    break;
                case "/":
                    result_txtbx.Text = OPerations.Division(firstnumber, double.Parse(store_txtbx.Text));
                    break;
                case "%":
                    result_txtbx.Text = OPerations.Mood(firstnumber, double.Parse(store_txtbx.Text));
                    break;
            }
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            firstnumber = double.Parse(store_txtbx.Text);
            isoperation = true;

        }

        private void multip_btn_Click(object sender, EventArgs e)
        {

        }

        private void minus_btn_Click(object sender, EventArgs e)
        {

        }

        private void plus_btn_Click(object sender, EventArgs e)
        {

        }

        private void point_btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (store_txtbx.Text == "0" || isoperation == true)
            {
                store_txtbx.Clear();
            }
            if (btn.Text == ".")
            {
                if (!store_txtbx.Text.Contains("."))
                {
                    store_txtbx.Text = store_txtbx.Text + btn.Text;
                }
            }
            else
            {
                store_txtbx.Text = store_txtbx.Text + btn.Text;
            }
            isoperation = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class OPerations
    {
        public static string Sum(double number1, double number2)
        {
            double result = number1 + number2;
            return result.ToString();
        }
        public static string Minus(double number1, double number2)
        {
            double result = number1 - number2;
            return result.ToString();
        }
        public static string Division(double number1, double number2)
        {
            double result = number1 / number2;
            return result.ToString();
        }
        public static string Multi(double number1, double number2)
        {
            double result = number1 * number2;
            return result.ToString();
        }
        public static string Mood(double number1, double number2)
        {
            double result = number1 % number2;
            return result.ToString();
        }

    }
}