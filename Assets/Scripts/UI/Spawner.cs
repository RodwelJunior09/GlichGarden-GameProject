using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] bool keepSpawning;
    [SerializeField] float minSpawnDelay = 0f;
    [SerializeField] float maxSpawnDelay = 5f;

    //[SerializeField] Attacker _enemyPrefab;
    [SerializeField] Attacker[] _enemiesPrefabs;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (keepSpawning)
        {
            yield return StartCoroutine(SetEnemies());
        }
    }

    public IEnumerator SetEnemies()
    {
        var randomNumber = Random.Range(minSpawnDelay, maxSpawnDelay);
        yield return new WaitForSeconds(randomNumber);
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        var randomIndex = Random.Range(0, _enemiesPrefabs.Length - 1);
        Spawn(randomIndex);
    }

    private void Spawn(int index)
    {
        Attacker attacker = Instantiate(_enemiesPrefabs[index], transform.position, transform.rotation) as Attacker;
        attacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
