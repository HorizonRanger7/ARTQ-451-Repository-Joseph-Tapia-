using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Variables
    //Make it a singleton!

    public static GameManager instance;

    public TextMeshProUGUI score;

    public TextMeshProUGUI p3score;

    public int sc_num; 

    public int p3sc_num;

    private bool canStart = true;

    //Awake is called on s[awn of this script before Start

    private void Awake()
    {
        //A singleton must only have one instance, check to make sure this is the only instance
        //If it is, make sure it's not destroyed, if its not destroy this instance

        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this; 
        } 
        
        else  //if the instance is already set to an object
        {
            Destroy(gameObject); //destroy this new object, so there is only ever one
        }
    }

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
        p3score.text = "Score: " + p3sc_num;

        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(0);
            sc_num = 0;
            p3sc_num = 0;
        }
    }

    public void StartGame()
    {
        if (canStart)
        {
            SceneManager.LoadScene("StartScene");
            canStart = false;
        }
    }

}
