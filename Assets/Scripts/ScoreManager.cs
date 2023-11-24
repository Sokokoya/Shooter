using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public GameObject player;
    public int scoreTir;
    public int scoreDrop;

    public TextMeshProUGUI texteScoreTir;
    public TextMeshProUGUI texteScoreDrop;


    // Update is called once per frame
    void Update()
    {
        texteScoreTir.text = "Score : " + scoreTir;
        texteScoreDrop.text = "Drop : " + scoreDrop;
    }


    // When the dropped item collides with the player, its score increases
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.CompareTag("Drop"))
        {
            scoreDrop++;
        }       
    }

}
