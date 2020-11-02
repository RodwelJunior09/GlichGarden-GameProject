using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defenders _defender;

    private void OnMouseDown()
    {
        DefenderPlacingValidation(GetClickPosition());
    }

    public void SetSelectedDefender(Defenders defenderSelected)
    {
        _defender = defenderSelected;
    }

    private Vector2 GetClickPosition()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 wordPos = Camera.main.ScreenToWorldPoint(mousePos);
        return SnapToGrid(wordPos);
    }

    private void DefenderPlacingValidation(Vector2 vectorGrid)
    {
        var pointsDisplay = FindObjectOfType<DisplayPoints>();
        int defenderCost = _defender.GetPointsCost();
        if (pointsDisplay.HasEnoughPoints(defenderCost))
        {
            SpawnDefender(vectorGrid);
            pointsDisplay.RemovePoints(defenderCost);
        }
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 coordenates)
    {
        Defenders newDefender = Instantiate(_defender, coordenates, Quaternion.identity) as Defenders;
    }
}
