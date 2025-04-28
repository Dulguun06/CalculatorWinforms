using CalculatorWinForms.Models;
using CalculatorWinForms.Views;
using CalculatorLibrary.Models;

namespace CalculatorWinForms.Controllers
{
    public class CalculatorController
    {
        private readonly CalculatorModel _model;
        private readonly Memory _memory;
        private readonly ICalculatorView _view;

        public CalculatorController(CalculatorModel model, ICalculatorView view, Memory memory)
        {
            _model = model;
            _view = view;
            _memory = memory;
            _view.SetController(this);
        }
        public void DrawView()
        {
            _view.UpdateResult(_model.Result);
        }

        public void AddNumbers(double a, double b)
        {
            _model.Add(a, b);
        }

        public void SubtractNumbers(double a, double b)
        {
            _model.Subtract(a, b);
        }
        public double Calculate(double firstOperand, double secondOperand, string _operator)
        {
            if (_operator == "+")
                AddNumbers(firstOperand, secondOperand);
            if (_operator == "-")
                SubtractNumbers(firstOperand, secondOperand);
            return (double)_model.Result;
        }
        public void SaveToMemory(string value)
        {
            MemoryItem item = new MemoryItem(double.Parse(value));
                _memory.Save(item);
        }

        public double IncrementMemory(int index, double fo, double so)
        {
            double result = Calculate(fo, so, "+");
            _memory.SetMemoryItem(index, new MemoryItem(result));
            return result;
        }

        public double DecrementMemory(int index, double fo, double so)
        {
            double result = Calculate(fo, so, "-");
            _memory.SetMemoryItem(index, new MemoryItem(result));
            return result;
        }

        public void RemoveFromMemory(int index)
        {
            _memory.RemoveMemoryItem(index);
        }

        public List<MemoryItem> RecallFromMemory()
        {
            return _memory.GetMemory();
        }

        public void ClearMemory()
        {
            _memory.Clear();
        }
    }
}
