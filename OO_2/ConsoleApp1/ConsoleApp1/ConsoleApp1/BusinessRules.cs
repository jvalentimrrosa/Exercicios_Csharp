using UI;

namespace BusinessRules
{
    class TransformDataIntoNewData
    {
        public MyDialog Dialog { get; set; }

        public void ExecuteBusinessRule(string data)
        {
            var newData = data + "!!!";
            Dialog.ShowNewData(newData);
        }
    }
}
