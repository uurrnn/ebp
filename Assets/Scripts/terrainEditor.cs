using UnityEngine;

[ExecuteInEditMode]
public class terrainEditor : MonoBehaviour
{

    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    public void startEditor()
    {
        print("Editor Started");
    }

    public void stopEditor()
    {
        print("Editor Stopped");
    }

    private void UpdateLabel()
    {
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        int gridSize = waypoint.GetGridSize();
        int xCoord = waypoint.GetGridPos().x / gridSize;
        int yCoord = waypoint.GetGridPos().y / gridSize;
        string labelText = xCoord + "," + yCoord;
        textMesh.text = labelText;
        gameObject.name = "Cube " + labelText;
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(
            waypoint.GetGridPos().x,
            2f,
            waypoint.GetGridPos().y
        );
    }

}
