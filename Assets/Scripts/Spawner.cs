using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] bool keepSpawning;
    [SerializeField] float minSpawnDelay = 0f;
    [SerializeField] float maxSpawnDelay = 5f;

    [SerializeField] Attacker _enemyPrefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (keepSpawning)
        {
            yield return StartCoroutine(SpawnEnemies());
        }
    }

    public IEnumerator SpawnEnemies()
    {
        var randomNumber = Random.Range(minSpawnDelay, maxSpawnDelay);
        yield return new WaitForSeconds(randomNumber);
        EnemyAppears();
    }

    private void EnemyAppears()
    {
        Attacker attacker = Instantiate(_enemyPrefab, transform.position, transform.rotation) as Attacker;
        attacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
