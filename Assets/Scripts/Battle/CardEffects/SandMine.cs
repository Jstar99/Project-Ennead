using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandMine : MonoBehaviour
{
    public GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player" || col.gameObject.name == "Enemy")
        {
            col.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

     void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player"|| col.gameObject.name == "Enemy")
        {
            col.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
