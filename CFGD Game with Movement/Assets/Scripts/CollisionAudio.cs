using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{

    //Variables

    [SerializeField] AudioClip impactSound;
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
    //Find the AudioSource
     audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Impact();
    }

    void Impact()
	{
		audioSource.Stop();
		audioSource.PlayOneShot(impactSound);
    }

}
