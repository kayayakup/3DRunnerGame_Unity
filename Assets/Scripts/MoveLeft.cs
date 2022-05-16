using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private float faster = 90;
    private PlayerController playerControllerScript;
    private float leftBound = 15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.left * Time.deltaTime * faster);
        }

        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < -leftBound && CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
