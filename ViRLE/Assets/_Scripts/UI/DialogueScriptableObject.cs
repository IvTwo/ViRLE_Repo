using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueObject")]
public class DialogueScriptableObject : ScriptableObject
{
    public List<DialogueData> data;
}
