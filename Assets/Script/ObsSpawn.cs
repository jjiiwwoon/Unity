using System.Collections;
using UnityEngine;

public class ObsSpawn : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 1f;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            SpawnObstacle();
        }
    }

    private void SpawnObstacle()
    {
        float randomY = Random.Range(-4.2f, 8f);
        Vector3 spawnPosition = new Vector3(5.2f, randomY, 0f);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}

