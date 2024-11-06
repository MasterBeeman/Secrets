using UnityEngine;

[CreateAssetMenu(fileName = "Result", menuName = "Contract/Result", order = 2)]
public class ResultSO : ScriptableObject
{
    public int Money;
    public int Trust;
    public string Message;
}
