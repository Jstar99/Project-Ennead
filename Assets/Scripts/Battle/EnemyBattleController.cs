using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattleController : MonoBehaviour
{
   [SerializeField] private int moveX;
    [SerializeField]private int moveY;
    public float timeToMove;
    public int num;
    public float accelerationTime = 2f;
    private float enemyXpos;
    private float enemyYpos;

    public GameObject player;
    private float playerXpos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyXpos = transform.position.x;
        enemyYpos = transform.position.y;
        playerXpos = player.transform.position.x;

        num = Random.Range(1, 5);
        EnemyMovement();
        StopMovement();
        DirectionOfPlayer();
        //1 - up, 2 - down, 3 - left, 4 - right
    }

  void DirectionOfPlayer()
  {
    if(enemyXpos < playerXpos)
    {
      GetComponent<SpriteRenderer>().flipX = true;
    }
    else if(enemyXpos > playerXpos)
    {
      GetComponent<SpriteRenderer>().flipX = false;
    }
  }




    void StopMovement()
    {
        if(enemyYpos < -0.2)
      {
        enemyYpos = -0.2f;
        transform.position = new Vector3(transform.position.x, transform.position.y + moveY, transform.position.z);
       // transform.position = new Vector3(transform.position.x, enemyYpos, transform.position.z );
      }
      else if(enemyYpos > 5)
      {
        enemyYpos = 5f;
        transform.position = new Vector3(transform.position.x, transform.position.y - moveY, transform.position.z);
        //transform.position = new Vector3(transform.position.x, enemyYpos, transform.position.z );
      }
      if(enemyXpos < -10.32)
      {
        enemyXpos = -10.32f;
        transform.position = new Vector3(transform.position.x + moveX, transform.position.y, transform.position.z);
        //transform.position = new Vector3(enemyXpos, transform.position.y, transform.position.z);
      }
      else if(enemyXpos > 6.66)
      {
        enemyXpos = 6.66f;
        transform.position = new Vector3(transform.position.x - moveX, transform.position.y, transform.position.z);
        //transform.position = new Vector3(enemyXpos, transform.position.y, transform.position.z);
      }
    }


    void EnemyMovement()
    {
        timeToMove -= Time.deltaTime;
        if (timeToMove <= 0)
        {
            switch(num)
            {
                case 1:
                    transform.position = new Vector3(transform.position.x, transform.position.y + moveY, transform.position.z);
                    timeToMove += accelerationTime;
                break;
                
                case 2:
                    transform.position = new Vector3(transform.position.x, transform.position.y - moveY, transform.position.z);
                     timeToMove += accelerationTime;
                break;
                
                case 3:
                    transform.position = new Vector3(transform.position.x - moveX, transform.position.y, transform.position.z);
                     timeToMove += accelerationTime;
                break;
                
                case 4:
                    transform.position = new Vector3(transform.position.x + moveX, transform.position.y, transform.position.z);
                     timeToMove += accelerationTime;
                break;
            }
        }
    }
}
