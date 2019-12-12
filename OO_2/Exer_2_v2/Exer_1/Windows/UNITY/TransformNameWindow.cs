using System;
using Interfaces;

namespace UI_UNITY
{
    class TransformNameWindow : TransformNameIntoNewNameOUTPUT
    {
        TransformNameIntoNewNameINPUT _businessRules;

        public TransformNameWindow(TransformNameIntoNewNameINPUT businessRules2)
        {
            this._businessRules = businessRules2;
        }

        public void OnOKUseButtonPressed()
        {
            this._businessRules.ExecuteName("MYSTRING");
        }

        public void ShowNewData(string newData)
        {
            Console.WriteLine(newData+" UNITY");
        }
    }
}
