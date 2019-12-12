using Interfaces;
namespace BusinessRules
{
    class TransformDataIntoNewData : TransformDataIntoNewDataINPUT
    {
        //public MyDialog Dialog { get; set; }
        public TransformDataIntoNewDataOUTPUT Window { get; set; } //Foi trocada a dependência ao invês de herdar de MyDialog agora herda da Interface de saida

        public void ExecuteBusinessRules(string data)
        {
            var newData = data + "!!!";
            Window.ShowNewData(newData);
        }
    }
}
