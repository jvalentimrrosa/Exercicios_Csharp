using System;
using BusinessRules;

namespace UI
{
    class MyDialog
    {
        TransformDataIntoNewData businessRule;

        public MyDialog(TransformDataIntoNewData businessRule)
        {
            this.businessRule = businessRule;
        }

        public void OnOKUseButtonPressed()
        {
            this.businessRule.ExecuteBusinessRule("mystring");
        }

        public void ShowNewData(string newData)
        {
            Console.WriteLine(newData);
        }
    }
}
