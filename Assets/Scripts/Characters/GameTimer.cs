using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in seconds")]
    [SerializeField] float levelTime = 10;
    bool timerFinished;

    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        timerFinished = (Time.timeSinceLevelLoad >= levelTime);
    }

    public bool TimerFinished() => timerFinished;
}
