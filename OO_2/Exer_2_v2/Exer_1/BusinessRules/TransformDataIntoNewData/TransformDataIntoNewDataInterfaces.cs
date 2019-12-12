namespace Interfaces
{
    interface TransformDataIntoNewDataINPUT

    {
        void ExecuteBusinessRules(string data);//assinatura da interface de entrada toda regra de negocio precisará implementá-la
    }

    interface TransformDataIntoNewDataOUTPUT
    {
        void ShowNewData(string newData);//assinatura da interface de saída toda UI precisará implementá-la
    }
}
