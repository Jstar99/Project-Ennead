using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject enemyBeingAttacked;
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
            Debug.Log("HIT!");
            enemyBeingAttacked = col.gameObject;
            col.GetComponent<Animator>().SetTrigger("Hurt");
        }
    }
}
