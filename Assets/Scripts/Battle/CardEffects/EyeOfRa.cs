using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOfRa : MonoBehaviour
{
    public float stunTime;


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
        if(col.gameObject.name == "Enemy")
        {
            col.GetComponent<SpriteRenderer>().color = Color.yellow;
            col.GetComponent<EnemyBattleController>().accelerationTime = 1000000000;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.name == "Enemy")
        {
            col.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

}
