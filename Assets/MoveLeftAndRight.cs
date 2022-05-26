using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour
{
    float speed = 2f;
    float width = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;

        //speed increases frequency of sin(), width scales amplitude 
        float newX = Mathf.Sin(Time.time * speed) * width;
        transform.position = new Vector2(newX, currentPos.y) ;
    }
}
