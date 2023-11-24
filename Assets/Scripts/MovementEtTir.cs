using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject specialBullet;
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;

    public float speed = 0.05f;
    public bool powerUpActive = false;
    private float powerUpSince = 0.0f;


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if (!powerUpActive)
            {
                Instantiate(bullet, parent.position, parent.rotation);
            }
            if (powerUpActive)
            {
                Instantiate(specialBullet, parent.position, parent.rotation);
            }
        }


        // Power up timer if it is active
        if (powerUpActive)
        {
            powerUpSince++;
        }


        // If the power up has been active for more than 2000 frames, it gets deactivated
        if (powerUpSince >= 2000f)
        {
            powerUpActive = false;
            powerUpSince = 0.0f;
        }


        if(transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }


}
