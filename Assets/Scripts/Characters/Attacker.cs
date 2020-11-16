using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;
    GameObject currentTarget;

    private void Awake()
    {
        FindObjectOfType<LevelController>().AttackerSpawn();
    }

    private void OnDestroy()
    {
        LevelController levelController = FindObjectOfType<LevelController>();
        if (levelController != null) levelController.AttackerKilled();
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget(float damagePoints)
    {
        if (!currentTarget) return;
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damagePoints);
        }
    }

    public void UpdateAnimationState()
    {
        if (!currentTarget) GetComponent<Animator>().SetBool("IsAttacking", false);
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
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
        UpdateAnimationState();
    }
}
