using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            DisplayVFX();
            Destroy(gameObject);
        }
    }

    private void DisplayVFX()
    {
        if (!deathVFX) { return; }
        Instantiate(deathVFX, transform.position, transform.rotation);
    }
}
