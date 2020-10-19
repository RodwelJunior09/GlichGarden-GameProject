using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject _projectile;
    [SerializeField] float minSpawnDelay = 0f;
    [SerializeField] float maxSpawnDelay = 5f;

    public void Fire()
    {
        Instantiate(_projectile, transform.position, transform.rotation);
    }
}
