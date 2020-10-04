using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }
}
