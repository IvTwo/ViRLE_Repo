using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomUI/Activity Data")]
public class ActivityData : ScriptableObject
{
    public GameObject uiPrefab;
    public List<ContentContainer> contentContainers;
}
