using System.Collections;
using UnityEngine;

public class ObsSpawn2 : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 1f;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float randomY = Random.Range(-2.5f, 8f);
            Vector3 spawnPosition = new Vector3(4.2f, randomY, 0f);
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnRate);
        }
    }
}

