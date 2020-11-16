using System.Collections;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int amountAttacker = 0;
    bool levelFinished = false;

    [SerializeField] GameObject winLabel;

    private void Start()
    {
        winLabel.SetActive(false);
    }

    public void AttackerSpawn()
    {
        amountAttacker++;
    }

    public void AttackerKilled()
    {
        amountAttacker--;
        if (levelFinished && amountAttacker <= 0)
        {
            HandleWinCondition();
        }
    }

    private void StopSpawners()
    {
        Spawner[] spawners = FindObjectsOfType<Spawner>();
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i].StopSpawn();
        }
    }

    public void FinishLevel()
    {
        levelFinished = true;
        StopSpawners();
    }

    private IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        FindObjectOfType<AudioSource>().Play();
        yield return new WaitForSeconds(5);
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
