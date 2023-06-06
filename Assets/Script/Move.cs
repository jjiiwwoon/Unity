using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    private SpriteRenderer renderer;
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput= Input.GetAxis("Vertical");

        if (xInput < 0)
        {
            renderer.flipX = true;
        }
        else
        {
            renderer.flipX = false;
        }

        Vector3 cameraPosition = mainCamera.transform.position;
        float cameraHalfWidth = mainCamera.orthographicSize * mainCamera.aspect;
        float cameraHalfHeight = mainCamera.orthographicSize;

        float newX = Mathf.Clamp(transform.position.x + xInput * moveSpeed * Time.deltaTime,
                                 cameraPosition.x - cameraHalfWidth,
                                 cameraPosition.x + cameraHalfWidth);
        float newY = Mathf.Clamp(transform.position.y + yInput * moveSpeed * Time.deltaTime,
                                 cameraPosition.y - cameraHalfHeight,
                                 cameraPosition.y + cameraHalfHeight);

        transform.position = new Vector3(newX, newY, transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((int)GameManager.surviveTime > GameManager.best)
        {
            GameManager.best = (int)GameManager.surviveTime;
        }
        
        SceneManager.LoadScene("Gameover");
    }
}

