using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject _projectile;
    public void Fire()
    {
        Instantiate(_projectile, transform.position, transform.rotation);
    }
}
