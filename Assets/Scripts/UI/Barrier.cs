using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        HitPlayerHealth(25);
        Destroy(otherCollider.gameObject);
    }

    public void HitPlayerHealth(int amount)
    {
        FindObjectOfType<DisplayLife>().DecreaseLife(amount);
    }
}
