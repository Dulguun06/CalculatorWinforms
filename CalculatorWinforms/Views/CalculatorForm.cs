using CalculatorLibrary.Models;
using CalculatorWinForms.Controllers;
using Timer = System.Windows.Forms.Timer;

namespace CalculatorWinForms.Views
{
    public partial class CalculatorForm : Form, ICalculatorView
    {
        private CalculatorController _controller;
        private double _firstOperand;
        private double _secondOperand;
        private string _operator;
        private double selectedMemoryItem;
        private int selectedItemIndex;
        public CalculatorForm()
        {
            InitializeComponent();
            InitializeButtons();
        }

        public void SetController(CalculatorController controller)
        {
            _controller = controller;
        }
        private void InitializeButtons()
        {
            btnMPlus.Visible = false;
            btnMMinus.Visible = false;
            btnMC.Visible = false;
            btnMPlus.Text = "M+";
            btnMMinus.Text = "M-";
            btnMC.Text = "MC";

            btnMPlus.Click += CalculatorButton_Click;
            btnMMinus.Click += CalculatorButton_Click;
            btnMC.Click += CalculatorButton_Click;

            memoryList.ItemMouseHover += MemoryList_ItemMouseHover;
            memoryList.MouseLeave += MemoryList_MouseLeave1;
            string[] buttonLabels =
            { "7", "8", "9", "C",
              "4", "5", "6", "-",
              "1", "2", "3", "+",
              "MS", "0", "=", "" };

            int index = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Button btn = new Button
                    {
                        Text = buttonLabels[index],
                        Dock = DockStyle.Fill,
                        Font = new System.Drawing.Font("Montserrat", 14, System.Drawing.FontStyle.Bold)
                    };
                    btn.Click += CalculatorButton_Click;
                    tableButtons.Controls.Add(btn, col, row);
                    index++;
                }
            }
        }



        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            string buttonText = clickedButton.Text;


            switch (buttonText)
            {
                case "M-":
                    _firstOperand = double.Parse(resultTextBox.Text);
                    _controller.DecrementMemory(selectedItemIndex, selectedMemoryItem, _firstOperand);
                    UpdateMemoryList(_controller.RecallFromMemory());
                    break;
                case "M+":
                    _firstOperand = double.Parse(resultTextBox.Text);
                    _controller.IncrementMemory(selectedItemIndex, selectedMemoryItem, _firstOperand);
                    UpdateMemoryList(_controller.RecallFromMemory());
                    break;
                case "+":
                    _firstOperand = double.Parse(resultTextBox.Text);
                    _operator = "+";
                    resultTextBox.Text += buttonText;
                    break;
                case "-":
                    _firstOperand = double.Parse(resultTextBox.Text);
                    _operator = "-";
                    resultTextBox.Text += buttonText;
                    break;
                case "C":
                    resultTextBox.Clear();
                    _firstOperand = 0;
                    _secondOperand = 0;
                    _operator = null;
                    break;
                case "=":
                    if (_secondOperand == 0)
                        _secondOperand = double.Parse(GetSecondOperand(resultTextBox.Text));
                    double result = _controller.Calculate(_firstOperand, _secondOperand, _operator);
                    _controller.DrawView();
                    _firstOperand = result;
                    _secondOperand = 0;
                    break;
                case "MS":
                    _controller.SaveToMemory(resultTextBox.Text);
                    UpdateMemoryList(_controller.RecallFromMemory());
                    break;
                case "MC":
                    _controller.RemoveFromMemory(selectedItemIndex);
                    btnMPlus.Visible = false;
                    btnMMinus.Visible = false;
                    btnMC.Visible = false;
                    UpdateMemoryList(_controller.RecallFromMemory());
                    break;
                default:
                    resultTextBox.Text += buttonText;
                    break;
            }
        }
        static string GetSecondOperand(string input)
        {
            char[] operators = new char[] { '+', '-' };
            foreach (var op in operators)
            {
                if (input.Contains(op))
                {
                    string[] parts = input.Split(op);
                    return parts[1];
                }
            }
            return "0";
        }

        public void UpdateResult(double result)
        {
            resultTextBox.Text = result.ToString();
        }

        public void ClearMemoryList()
        {
            memoryList.Items.Clear();

            btnMPlus.Visible = false;
            btnMMinus.Visible = false;
        }
        public void UpdateMemoryList(List<MemoryItem> memoryItems)
        {
            ClearMemoryList();
            foreach (var item in memoryItems)
            {
                memoryList.Items.Add(item.Value.ToString());
            }
        }


        private void MemoryList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            var bounds = e.Item.Bounds;

            selectedMemoryItem = double.Parse(e.Item.Text);
            selectedItemIndex = e.Item.Index;

            btnMPlus.Location = new Point(bounds.Right - 120, bounds.Top);
            btnMMinus.Location = new Point(bounds.Right - 80, bounds.Top);
            btnMC.Location = new Point(bounds.Right - 160, bounds.Top);

            btnMC.Visible = true;
            btnMPlus.Visible = true;
            btnMMinus.Visible = true;
        }
        private void MemoryList_MouseLeave1(object? sender, EventArgs e)
        {
            // Start a short timer to check if mouse is actually outside both ListView and buttons
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (s, args) =>
            {
                Point cursorPos = this.PointToClient(Cursor.Position);

                if (!memoryList.Bounds.Contains(cursorPos) &&
                    !btnMPlus.Bounds.Contains(cursorPos) &&
                    !btnMMinus.Bounds.Contains(cursorPos) &&
                    !btnMC.Bounds.Contains(cursorPos))
                {
                    btnMPlus.Visible = false;
                    btnMMinus.Visible = false;
                    btnMC.Visible = false;
                }

                timer.Stop(); // Stop after one check
                timer.Dispose();
            };
            timer.Start();
        }
    }
}