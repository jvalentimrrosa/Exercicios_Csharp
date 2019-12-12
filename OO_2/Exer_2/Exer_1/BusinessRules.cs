using Interface_INPUT;
using Interface_OUTPUT;

namespace BusinessRules
{
    class TransformDataIntoNewData : Interface_IN
    {
        public Interface_OUT Dialog { get; set; }

        public void ExecuteBusinessRules(string data)
        {
            var newData = data + "!!!";
            Dialog.ShowNewData(newData);
        }
    }
}
