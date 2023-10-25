using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public GameObject drop;
    public float speed;

    public ScoreManager score;

    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;

        score = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Speciel_enemy"))
        {
            Instantiate(drop, collision.gameObject.transform.position, Quaternion.identity);
        }
       
        
        //AjoutScore(Score);

        score.ScoreTir++;
        Debug.Log("score tir prend 1 :" + score.ScoreTir);
       
        
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
