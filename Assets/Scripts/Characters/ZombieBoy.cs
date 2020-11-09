using UnityEngine;

public class ZombieBoy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        if (otherObject.GetComponent<Defenders>() != null) GetComponent<Attacker>().Attack(otherObject); // Only attack when the object is a defender
    }
}
