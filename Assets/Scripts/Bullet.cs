using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bulletRigidbody;
    public GameObject drop;
    public float speed;

    public ScoreManager score;


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody.velocity = Vector3.up*speed;

        score = FindObjectOfType<ScoreManager>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        // If the bullet encounters the special enemy, a drop item is instantiated
        if (collision.gameObject.CompareTag("Speciel_enemy"))
        {
            Instantiate(drop, collision.gameObject.transform.position, Quaternion.identity);
        }
    
        // For each kill, the player's score increases
        score.scoreTir++;

       // The enemy and the bullet get destroyed       
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
