using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            EnemyManager.instance.activeEnemies.Add(enemy);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}