using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{
    public float speed = 5f; 

    private void Start()
    {
        float randomY = Random.Range(-2.5f, 8f);
        transform.position = new Vector3(-4.2f, randomY, 0f);
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }
}
