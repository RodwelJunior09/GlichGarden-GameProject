using UnityEngine;

public class Defender : MonoBehaviour
{
    bool currenlyRunning = true;
    float currentSpeed = 1f;

    public void RunningState(bool isRunning)
    {
        currenlyRunning = isRunning;
    }

    // Update is called once per frame
    void Update()
    {
        while (currenlyRunning)
        {
            transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);
        }
    }
}
