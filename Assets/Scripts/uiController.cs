using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour
{
    Button myButton;
    bool isEditorModeOn = false;

    void Awake()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(() =>
        {
            toggleEditorMode();
        });
    }

    void toggleEditorMode()
    {
        if (isEditorModeOn)
        {
            isEditorModeOn = false;
        }
        else
        {
            isEditorModeOn = true;
        }
        print(isEditorModeOn);
    }

    void Start()
    {

    }
}
