using Interfaces;
namespace BusinessRules
{
    class TransformNameIntoNewName : TransformNameIntoNewNameINPUT
    {

        //public MyDialog Dialog { get; set; }
        public TransformNameIntoNewNameOUTPUT Window { get; set; } //Foi trocada a dependência ao invês de herdar de MyDialog agora herda da Interface de saida

        public void ExecuteName(string data)
        {
            var newData = data + "###";
            Window.ShowNewData(newData);
        }
    }
}
