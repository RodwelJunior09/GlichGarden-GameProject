using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    [SerializeField] int damageScore = 100;
    [SerializeField, Range(0f, 5f)] float projectileSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

    public int GetDamage()
    {
        return damageScore;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }

}
