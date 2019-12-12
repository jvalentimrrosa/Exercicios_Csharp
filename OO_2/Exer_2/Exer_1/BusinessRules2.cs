using Interface_INPUT;
using Interface_OUTPUT;

namespace BusinessRules2
{
    class TransformDataIntoNewData : Interface_IN
    {

        //public MyDialog Dialog { get; set; }
        public Interface_OUT Dialog { get; set; } //Foi trocada a dependência ao invês de herdar de MyDialog agora herda da Interface de saida

        public void ExecuteBusinessRules(string data)
        {
            var newData = data + "###";
            Dialog.ShowNewData(newData);
        }
    }
}
