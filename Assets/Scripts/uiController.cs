using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour
{

    public terrainEditor toggleEditor;

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
            toggleEditor.stopEditor();
            isEditorModeOn = false;
        }
        else
        {
            toggleEditor.startEditor();
            isEditorModeOn = true;
        }
    }

}
