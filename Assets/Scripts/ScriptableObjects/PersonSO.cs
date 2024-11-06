using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Person", menuName = "Contract/Person", order = 4)]
public class PersonSO : ScriptableObject
{
    public string Name;
    public string Description;
}
