using System;
using Interfaces;

namespace UI_QT
{
    class TransformDataWindow : TransformDataIntoNewDataOUTPUT
    {
        TransformDataIntoNewDataINPUT _businessRules;

        public TransformDataWindow(TransformDataIntoNewDataINPUT businessRules2)
        {
            this._businessRules = businessRules2;
        }

        public void OnOKUseButtonPressed()
        {
            this._businessRules.ExecuteBusinessRules("MY STR1NG");
        }

        public void ShowNewData(string newData)
        {
            Console.WriteLine(newData+" QT");
        }
    }
}
