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

    public float speed = 0.2f;
    public bool powerUpActif = false;
    private float powerUpSince = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            if (!powerUpActif)
            {
                Instantiate(bullet, parent.position, parent.rotation);
            }
            if (powerUpActif)
            {
                Instantiate(specialBullet, parent.position, parent.rotation);
            }
        }


        // timer du powerup s'il est actif
        if (powerUpActif)
        {
            powerUpSince++;
            Debug.Log(powerUpSince);
        }


        // si le power up est actif depuis 2000 frames, on l'enleve
        if (powerUpSince >= 2000f)
        {
            powerUpActif = false;
            powerUpSince = 0.0f;
            Debug.Log("POWER UP DESACTIVE");
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
