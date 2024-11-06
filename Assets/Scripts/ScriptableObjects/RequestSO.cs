using UnityEngine;

[CreateAssetMenu(fileName = "Request", menuName = "Request", order = 1)]
public class RequestSO : ScriptableObject
{
    public string Header;
    public string Body;

    public ContractSO AttachedContract;
}
