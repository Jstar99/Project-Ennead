using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleController : MonoBehaviour
{
    public float moveX;
    public float moveY;
    private Animator anim;
    public GameObject baddie;

    private float bossXpos;
    private float playerXpos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator> ();
        baddie = GameObject.FindGameObjectWithTag("Boss");
    }

    // Update is called once per frame
    void Update()
    {
        bossXpos = baddie.transform.position.x;
        playerXpos = transform.position.x;  


        anim.SetBool("Atk", false);
        anim.SetBool("Fwd", false);
        anim.SetBool("Bk", false);
        
        PlayerBattleMovement(); 
        PlayerAttack();
        EnemyDirection();
    }

    void EnemyDirection()
    {
        if (playerXpos > bossXpos )
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    void PlayerBattleMovement()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + moveY, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - moveY, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - moveX, transform.position.y, transform.position.z);
          //     GetComponent<SpriteRenderer>().flipX = true;
            //anim.SetBool("Fwd", true);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + moveX, transform.position.y, transform.position.z);
           // GetComponent<SpriteRenderer>().flipX = false;
           // anim.SetBool("Fwd", true);
        }
    }

    void PlayerAttack()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            anim.SetBool("Atk", true);
        }
    }

}
