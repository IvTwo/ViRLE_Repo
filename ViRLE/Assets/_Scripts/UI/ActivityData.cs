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
    public int index { get; private set; }

    public void LoadContent() {
        index = 0;
        currContent.LoadDialogueFromFile();
    }

    public string Next() {
        if (index >= currContent.dialogueText.Count) { return null;  }
        return currContent.dialogueText[index++];
    }

    public string Prev() {
        if (index - 1 < 0) { return null; }
        return currContent.dialogueText[index--];
    }
}
