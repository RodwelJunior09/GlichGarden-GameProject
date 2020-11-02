using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DisplayPoints : MonoBehaviour
{
    // Debugger variables
    [SerializeField] int points = 100;

    // Local variables
    Text textComponent;

    void Start()
    {
        textComponent = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        textComponent.text = points.ToString();
    }

    public void AddPoints(int amount)
    {
        points += amount;
        UpdateDisplay();
    }

    public bool HasEnoughPoints(int amount)
    {
        return points >= amount;
    }

    public void RemovePoints(int amount)
    {
        if (points >= amount)
        {
            points -= amount;
            UpdateDisplay();
        }
    }
}
