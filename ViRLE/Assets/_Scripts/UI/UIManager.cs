using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button _nextButton;  // TO-DO: clean this up
    [SerializeField] private Button _backButton;
    private GameObject _currTextboxInstance;
    private Text dialogueText;

    [SerializeField] private ActivityData activityData;
    private ActivityData currActivity;

     void Start() {
        _nextButton.onClick.AddListener(NextButtonClick);
     }

    private void StartActivity() {
        if (_currTextboxInstance == null) {
            _currTextboxInstance = Instantiate(currActivity.uiPrefab, this.gameObject.transform);
            dialogueText = _currTextboxInstance.GetComponentInChildren<Text>();
        }

        _nextButton.gameObject.SetActive(true);
        _backButton.gameObject.SetActive(true);

        currActivity.LoadContent();
        NextPage();
    }

    private void NextPage() {
        if (dialogueText != null) { dialogueText.text = currActivity.Next(); }
    }

    public void StartRobotDogActivity() {
        currActivity = activityData;    // TODO: will change this later
        StartActivity();
    }

    /// <summary>
    /// Assign these to the next and back buttons in the ui prefab
    /// </summary>
    public void NextButtonClick() {
       NextPage();
    }

    //public void BackButtonClick() {
    //    if (_currDialogueIndex > 0) {
    //        _currDialogueIndex--;
    //        ShowDialogue(_currDialogueIndex);
    //    }
    //}
}
