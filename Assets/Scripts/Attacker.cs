using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var projectileComponent = collision.GetComponent<FireProjectile>();
        if (!projectileComponent) return;
        HitProcess(projectileComponent);
    }

    private void HitProcess(FireProjectile projectile)
    {
        projectile.Hit();
        FindObjectOfType<Health>().DealDamage(projectile.GetDamage());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }
}
