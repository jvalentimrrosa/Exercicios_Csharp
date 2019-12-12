using UI_QT;
using UI_UNITY;
using BusinessRules;
using BusinessRules2;
using Interface_INPUT;
using Interface_OUTPUT;

namespace Exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
           var businessRules = new BusinessRules2.TransformDataIntoNewData();
        //  var businessRules = new BusinessRules.TransformDataIntoNewData();
           var ui = new UI_QT.MyDialog(businessRules);
        //  var ui = new UI_UNITY.MyDialog(businessRules);
            businessRules.Dialog = ui;

            ui.OnOKUseButtonPressed(); // simulate user pressing button

            System.Console.ReadKey(); // prevent console from closing
        }
    }
}
