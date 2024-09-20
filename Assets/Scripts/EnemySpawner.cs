using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private bool spawn;
    private float spawnRate;

    void Start()
    {
        spawn = true;
        spawnRate = 3;
        StartCoroutine(SpawnEnemies());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        while (spawn)
        {
            Instantiate(enemyPrefab, gameObject.transform);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
