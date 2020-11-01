using UnityEngine;
using UnityEngine.UI;

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

    public void RemovePoints(int amount)
    {
        if (points >= amount)
        {
            points -= amount;
            UpdateDisplay();
        }
    }
}
