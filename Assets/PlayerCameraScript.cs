using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{

    public GameObject mainCamera;
    public GameObject player;
    Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("MainCamera");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //update playerPos each frame
        playerPos = player.transform.position;
        //set CameraPos x and y coordinates to new playerPos x and y 
        mainCamera.transform.position = new Vector3(playerPos.x, playerPos.y, -10f);
    }
}
