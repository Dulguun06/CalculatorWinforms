using System;
using System.Windows.Forms;
using CalculatorWinForms.Models;
using CalculatorWinForms.Views;
using CalculatorWinForms.Controllers;
using CalculatorLibrary.Models;

namespace CalculatorWinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create Model, View, Controller
            CalculatorModel model = new();
            CalculatorForm view = new();
            Memory memory = new();
            CalculatorController controller = new(model, view, memory);

            Application.Run(view);
        }
    }
}
