using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareDamage : MonoBehaviour
{
    //gets called when this collider begins touching another collider 
    void OnCollisionEnter2D(Collision2D collision) {
        //parameter collider = body we touched (here: the player)
        //we check for player by comparing the tag of touched collider
        
        Collider2D collider = collision.collider;
        //collider = incoming collider 
        if(collider.CompareTag("Player")){
            GameObject.Destroy(collider.gameObject);
            Debug.Log("Player was killed by: " + this.gameObject.name);
        }
    }
}
