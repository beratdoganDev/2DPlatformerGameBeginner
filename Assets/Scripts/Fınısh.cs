using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fınısh : MonoBehaviour
{
    private AudioSource fınıshSound;

    private void Start()
    {
        fınıshSound = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            fınıshSound.Play();
            ComplateLevel();

        
        
        }
    }


    private void ComplateLevel() 
    {
        
    
    
    
    }


}
