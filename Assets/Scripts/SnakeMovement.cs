using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public int snakeSpeed;
    [SerializeField] private Rigidbody2D rb2d;
    private Vector2 _direction = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Get inputs for player direction
        SnakeDirection();
    }

    private void FixedUpdate()
    {   
        // Continous movement of snake.
        rb2d.transform.position = new Vector2(this.transform.position.x + _direction.x * Time.deltaTime * snakeSpeed, 
                                              this.transform.position.y + _direction.y * Time.deltaTime * snakeSpeed);
    }

    private void SnakeDirection() {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            _direction = Vector2.left;
        }else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
    }
}
