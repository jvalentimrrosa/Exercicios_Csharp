using System;
using Interface_INPUT;
using Interface_OUTPUT;

namespace UI_UNITY
{
    class MyDialog : Interface_OUT
    {
        Interface_IN _businessRules;

        public MyDialog(Interface_IN businessRules2)
        {
            this._businessRules = businessRules2;
        }

        public void OnOKUseButtonPressed()
        {
            this._businessRules.ExecuteBusinessRules("MYSTRING");
        }

        public void ShowNewData(string newData)
        {
            Console.WriteLine(newData+"UNITY");
        }
    }
}
