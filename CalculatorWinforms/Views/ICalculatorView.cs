namespace CalculatorWinForms.Views
{
    public interface ICalculatorView
    {
        void SetController(Controllers.CalculatorController controller);
        void UpdateResult(double result);
    }
}
