using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Information", menuName = "Contract/Information", order = 3)]
public class InformationSO : ScriptableObject
{
    public string Who;
    public string What;
    public string Where;
    public string Why;
    public string When;
}