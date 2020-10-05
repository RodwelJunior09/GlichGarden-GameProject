using UnityEngine;

public class Defender : MonoBehaviour
{
    float currentSpeed = 1.5f;
    bool moveCharacter = true;

    public void StopRunning()
    {
        moveCharacter = false;
    }

    public void FireProjectile()
    {
        Debug.Log("Fire Projectile");
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCharacter && gameObject.tag.Contains("Human"))
        {
            transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);
        }
    }
}
