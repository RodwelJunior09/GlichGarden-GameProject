using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject _defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetClickPosition());
    }

    private Vector2 GetClickPosition()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 wordPos = Camera.main.ScreenToWorldPoint(mousePos);
        return wordPos;
    }

    private void SpawnDefender(Vector2 coordenates)
    {
        GameObject newDefender = Instantiate(_defender, coordenates, Quaternion.identity) as GameObject;
    }
}
