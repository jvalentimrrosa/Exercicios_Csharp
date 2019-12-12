using UI;
using BusinessRules;

namespace Exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessRules = new TransformDataIntoNewData();
            var ui = new MyDialog(businessRules);
            businessRules.Dialog = ui;

            ui.OnOKUseButtonPressed(); // simulate user pressing button

            System.Console.ReadKey(); // prevent console from closing
        }
    }
}
