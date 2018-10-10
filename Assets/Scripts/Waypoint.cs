using UnityEngine;

public class Waypoint : MonoBehaviour
{

    Vector2Int gridPos;

    const int gridSize = 2;

    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            gridPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize,
            gridPos.y = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize
        );

    }

}