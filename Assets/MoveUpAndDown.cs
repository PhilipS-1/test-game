using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    float speed = 2f;
    float height = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;

        //speed increases frequency of sin(), height scales amplitude 
        float newY = Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector2(currentPos.x, newY) ;
    }
}
