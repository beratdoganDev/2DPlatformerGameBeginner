using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            Invoke("ComplateLevel", 2f);

        
        
        }
    }


    private void ComplateLevel() 
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    
    
    
    }


}
