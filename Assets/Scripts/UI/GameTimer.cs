using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in seconds")]
    [SerializeField] float levelTime = 10;

    // Local variables
    bool stopUpdate;
    bool timerFinished;

    void Update()
    {
        if (stopUpdate) return; // If the level finished, not more update

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        TimerFinished();
    }

    private void TimerFinished()
    {
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().FinishLevel();
            stopUpdate = true;
        }
    }
}
