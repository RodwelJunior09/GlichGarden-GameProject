using UnityEngine;

public class Defenders : MonoBehaviour
{
    [SerializeField] int pointsCost = 100;

    public void AddPoints(int amount)
    {
        FindObjectOfType<DisplayPoints>().AddPoints(amount);
    }

    public int GetPointsCost()
    {
        return pointsCost;
    }
}
