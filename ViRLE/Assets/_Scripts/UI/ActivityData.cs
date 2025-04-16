using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CustomUI/Activity Data")]
public class ActivityData : ScriptableObject
{
    public GameObject uiPrefab;
    public List<ContentContainer> contentContainers;
    public ContentContainer currContent;    // TODO: lmao hard setting this rn
    private int index;

    public void LoadContent() {
        index = 0;
    }

    public string Next() {
        Debug.Log(index);
        string stringToReturn =  currContent.dialogueText[index];
        index++;
        return stringToReturn;
    }
}
