using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiskIdentityMenu : MonoBehaviour
{
    [SerializeField] private List<Button> buttonList;
    
    // TODO: works for small things, but if this exapnds should also expand scalability
    public void CreateMenu(List<string> options, int correctAnsIndex) {
        for (int i = 0; i < buttonList.Count; ++i) {
            buttonList[i].text = options[i];

            if (i == correctAnsIndex) { buttonList[i].clicked += CorrectAnswer;  }
            else { buttonList[i].clicked += WrongAnswer; }
        }
    }

    private void WrongAnswer() {
        Debug.Log("Wrong");
    }

    private void CorrectAnswer() {
        Debug.Log("coorect");
    }

    // after the buttons are clicked probably -= the event for next time
}
