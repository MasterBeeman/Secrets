using UnityEngine;

[CreateAssetMenu(fileName = "Contract", menuName = "Contract/Contract", order = 1)]
public class ContractSO : ScriptableObject
{
    public string Title;
    public string RequestDetails;
    public InformationSO Information; // What the correct information on the secret is
    public PersonSO Client; // Details on the client
    public PersonSO Target; // Details on the client
    public SecretsSO Secrets; // List of the different details of information you can get 
    public ResultSO SuccessReward; // What the Success Reward looks like
    public ResultSO FailReward; // What the Failure looks like
    public int DeadlineDays; // Amount of time before before you have to hand over information


}

public enum Acts
{
    Affair,
    Murder,
    Robbed,
    Blackmailed,
    Stolen,
    Drugs,
    Crime,
    Addiction,
    Cult,
    Debt,
    Fraud,
    Abuse,

}
