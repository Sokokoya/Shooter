using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    public GameObject parent;
    public MovementEtTir shoot;


    // Start is called before the first frame update
    void Start()
    {
        shoot = FindObjectOfType<MovementEtTir>();
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the dropped item collides with the player, the power up activates and the item is destroyed
        if (collision.gameObject.CompareTag("Player"))
        {
            shoot.powerUpActive = true;
            Destroy(gameObject);
        }       
    }
}
