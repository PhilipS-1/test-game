using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rigidbody2d;
    private SpriteRenderer spriteRenderer;
    private bool doubleJumpAvailable;
    private float movementSpeed = 5f;
    float jumpVelocity = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rigidbody2d.velocity.y == 0){
            doubleJumpAvailable = true;
            spriteRenderer.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            if(rigidbody2d.velocity.y == 0){
                Jump();
            }
            else if(rigidbody2d.velocity.y != 0 && doubleJumpAvailable){
                doubleJumpAvailable = false;
                spriteRenderer.color = Color.red;
                Jump();
            }
        }
        if(Input.GetKey(KeyCode.A)){
            rigidbody2d.velocity = new Vector2(-1 * movementSpeed, rigidbody2d.velocity.y);
        }
        if(Input.GetKey(KeyCode.D)){
            rigidbody2d.velocity = new Vector2(1 * movementSpeed, rigidbody2d.velocity.y);
        }
    }

    void Jump(){
        //when we press down space we update rigidBody -> manipulate rigidBody velocity
        //rigidbody2d.velocity = new Vector2(0,1) * jumpVelocity;
        rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, 1 * jumpVelocity);
    }
}
