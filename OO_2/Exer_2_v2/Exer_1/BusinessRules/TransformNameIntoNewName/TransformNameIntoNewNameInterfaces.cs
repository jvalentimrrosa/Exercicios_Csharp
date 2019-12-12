namespace Interfaces
{
    interface TransformNameIntoNewNameINPUT

    {
        void ExecuteName(string data);//assinatura da interface de entrada toda regra de negocio precisará implementá-la
    }

    interface TransformNameIntoNewNameOUTPUT
    {
        void ShowNewData(string newData);//assinatura da interface de saída toda UI precisará implementá-la
    }
}
