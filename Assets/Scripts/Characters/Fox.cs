using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        if (otherObject.GetComponent<Defenders>() != null && otherObject.name.ToLower().Contains("gravestone"))
        {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
        else if (otherObject.GetComponent<Defenders>() != null) GetComponent<Attacker>().Attack(otherObject); // Only attack when the object is a defender
    }
}
