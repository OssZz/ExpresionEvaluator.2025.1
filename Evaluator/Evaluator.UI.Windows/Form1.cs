namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        private string expression = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string value = btn.Text;

            if (value == "=")
            {
                txtDisplay.Text = $"{expression}={FunctionEvaluator.Evaluate(expression)}";
                expression = "";
            }
            else if (value == "Clear")
            {
                expression = "";
                txtDisplay.Text = "";
            }
            else if (value == "Delete")
            {
                if (expression.Length > 0)
                    expression = expression.Substring(0, expression.Length - 1);
                txtDisplay.Text = expression;
            }
            else
            {
                expression += value;
                txtDisplay.Text = expression;
            }
        }
    }
}
