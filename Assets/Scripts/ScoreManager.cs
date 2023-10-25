using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{


    // variable player
    public GameObject Player;
    public int ScoreTir;
    public int ScoreDrop;

    public TextMeshProUGUI texteScoreTir;
    public TextMeshProUGUI texteScoreDrop;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        texteScoreTir.text = "Score : " + ScoreTir;
        texteScoreDrop.text = "Drop : " + ScoreDrop;
    }

    // quand le drop rentre en trigger avec le player
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.CompareTag("Drop"))
        {
            ScoreDrop++;
            Debug.Log("score drop prend 1:" + ScoreDrop);
        }
        
    }

}
