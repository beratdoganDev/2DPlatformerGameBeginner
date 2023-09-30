using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int charries = 0;

    [SerializeField] private Text charriesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry")) 
        { 
            Destroy(collision.gameObject);
            charries++;
            
            charriesText.text = "Charries:" + charries;
        
        }
    }
}
