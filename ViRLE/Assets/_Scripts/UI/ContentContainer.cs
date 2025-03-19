using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "CustomUI/Content Container")]
public class ContentContainer : ScriptableObject
{
    public TextAsset dialogueText;
    public Image image;
    public VideoClip video;
}
