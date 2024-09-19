using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI score;

    public TextMeshProUGUI p3score;

    public int sc_num; 

    public int p3sc_num;


    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0.
        sc_num = 0;
  
    }

    // Update is called once per frame
    void Update()
    {
        //Make the score texts say score: and a number.
        score.text = "Score: " + sc_num;
        p3score.text = "Score:" + p3sc_num;
    }
}
