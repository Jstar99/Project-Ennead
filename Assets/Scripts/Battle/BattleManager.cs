using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BattleManager : MonoBehaviour
{
  public List<Card> listOfCards = new List<Card>();
    public GameObject indicator;
    public GameObject[] hand;
    public int num = 0;
    public GameObject curCard;
    public float yPos = -3;
    public float up = 2f;

    public float playerXPos;
    public float playerYPos;
    public GameObject player;

    public HealthAndMana mana;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      playerXPos = player.transform.position.x;
      playerYPos = player.transform.position.y;
        curCard = hand[num];
        EndOfField(); 
        SelectCard();
        ErrorHandling();

        if (Input.GetKeyDown(KeyCode.R))
        {
          SceneManager.LoadScene(0);
        }
    }


    void EndOfField()
    {
      if(playerYPos < -0.2)
      {
        playerYPos = -0.2f;
        player.transform.position = new Vector3(player.transform.position.x, playerYPos, player.transform.position.z );
      }
      else if(playerYPos > 5)
      {
        playerYPos = 5f;
        player.transform.position = new Vector3(player.transform.position.x, playerYPos, player.transform.position.z );
      }
      if(playerXPos < -10.32)
      {
        playerXPos = -10.32f;
        player.transform.position = new Vector3(playerXPos, player.transform.position.y, player.transform.position.z);
      }
      else if(playerXPos > 6.66)
      {
        playerXPos = 6.66f;
        player.transform.position = new Vector3(playerXPos, player.transform.position.y, player.transform.position.z);
      }
    }




    void SelectCard()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
          hand[num].SetActive(false);
        }


        if(Input.GetKeyDown(KeyCode.Q))
        {
            num -= 1;   
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            num += 1;
        }

        //Very bad implimentation but it works, refactor using switches
          if(curCard == hand[0])
        {
          hand[0].transform.position = new Vector3(hand[0].transform.position.x, yPos, hand[0].transform.position.z);
           
        }
        else if(curCard == hand[1])
        {
          hand[1].transform.position = new Vector3(hand[1].transform.position.x, yPos, hand[1].transform.position.z);
        }
         else if(curCard == hand[2])
        {
          hand[2].transform.position = new Vector3(hand[2].transform.position.x, yPos, hand[2].transform.position.z);
           
        }
        else if(curCard == hand[3])
        {
          hand[3].transform.position = new Vector3(hand[3].transform.position.x, yPos, hand[3].transform.position.z);
        }


         if(curCard!=hand[0])
        {
            hand[0].transform.position = new Vector3(hand[0].transform.position.x, up, hand[0].transform.position.z);
        }
          if(curCard!=hand[1])
        {
            hand[1].transform.position = new Vector3(hand[1].transform.position.x, up, hand[1].transform.position.z);
        }
          if(curCard!=hand[2])
        {
            hand[2].transform.position = new Vector3(hand[2].transform.position.x, up, hand[2].transform.position.z);
        }
          if(curCard!=hand[3])
        {
            hand[3].transform.position = new Vector3(hand[3].transform.position.x, up, hand[3].transform.position.z);
        }
    }

    void ErrorHandling()
    {
      if(num >= 3)
      {
        num = 3;
      }
      if (num <= 0)
      {       
        num = 0;
      }
    }
}
