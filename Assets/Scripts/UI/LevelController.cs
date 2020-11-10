using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int GetNumberAttackersOnScreen()
    {
        return FindObjectsOfType<Attacker>().Length;
    }

    public bool TimerFinished()
    {
        return FindObjectOfType<GameTimer>().TimerFinished();
    }

    public void StopSpawning()
    {
        FindObjectOfType<Spawner>().StopSpawn();
    }

    public void PlayerWin()
    {
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
