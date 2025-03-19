using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //[SerializeField] private GameObject _nextButton;  // TO-DO: clean this up
    //[SerializeField] private GameObject _backButton;

    //private DialogueScriptableObject[] _dialogueArray;    //TO-DO implement list ver
    //[SerializeField] private DialogueScriptableObject _currDialogue;
    //[SerializeField] private Transform _spawnPoint;
    //private GameObject _currTextboxInstance;
    //private int _currDialogueIndex = 0;

    //void Start() {
    //    ShowDialogue(0);
    //}


    //void Update() {
        
    //}

    //private void ShowDialogue(int index) {
    //    if (_currTextboxInstance != null) {  Destroy(_currTextboxInstance); }

    //    // get the dialogue data for the curr index
    //    ContentContainer data = _currDialogue.data[index];
        
    //    // instantiate prefab and set its text
    //    _currTextboxInstance = Instantiate(data.dialoguePrefab, _spawnPoint);
    //    Text dialogueText = _currTextboxInstance.GetComponentInChildren<Text>();
    //    if (dialogueText != null ) { dialogueText.text = data.dialogueText; }
    //}

    //public void NextButtonClick() {
    //    if (_currDialogueIndex < _currDialogue.data.Count - 1) {
    //        _currDialogueIndex++;
    //        ShowDialogue(_currDialogueIndex);
    //    }
    //}

    //public void BackButtonClick() {
    //    if (_currDialogueIndex > 0) {
    //        _currDialogueIndex--;
    //        ShowDialogue(_currDialogueIndex);
    //    }
    //}
}
