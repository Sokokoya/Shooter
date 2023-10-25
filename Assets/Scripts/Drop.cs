using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    public GameObject Parent;
    public MovementEtTir Tir;

    // Start is called before the first frame update
    void Start()
    {
        Tir = FindObjectOfType<MovementEtTir>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Tir.powerUpActif = true;
            Debug.Log("POWER UP ACTIF");
            Destroy(gameObject);
        }       
    }
}
