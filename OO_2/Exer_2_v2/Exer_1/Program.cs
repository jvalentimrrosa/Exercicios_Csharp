using BusinessRules;


namespace Exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var transformDataBR = new TransformDataIntoNewData(); //criando objeto que implementa a interface
            var transformNameBR = new TransformNameIntoNewName();

            var qtdata = new UI_QT.TransformDataWindow(transformDataBR);//recebe o objeto
            var qtname = new UI_QT.TransformNameWindow(transformNameBR);

            var unitydata = new UI_UNITY.TransformDataWindow(transformDataBR);
            var unityname = new UI_UNITY.TransformNameWindow(transformNameBR);

            transformDataBR.Window = qtdata; //unitydata/ injeta 
            transformNameBR.Window = qtname; //unityname

            qtdata.OnOKUseButtonPressed(); //unitydata  simulate user pressing button
            qtname.OnOKUseButtonPressed(); //unityname

            System.Console.ReadKey(); // prevent console from closing
        }
    }
}
