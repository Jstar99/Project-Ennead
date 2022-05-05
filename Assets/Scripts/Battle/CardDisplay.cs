using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    //public List<Card> card = new List<Card>();  
    public Card card; 
    public BattleManager bm;
    public PlayerAttack pAtk;
    public int randNum;
    public int whatId;

    public Transform eyePos;
    public Transform scarabPos;
    public Transform bombPos;
    public Transform fieldCardPos;

    public GameObject eyeOfRa;
    public GameObject scarabShield;
    public GameObject sunBomb;
    public GameObject rSand;
    
    
    void Start()
    {   
        randNum = Random.Range(0, 12);
        card = bm.listOfCards[randNum];
        GetComponent<SpriteRenderer>().sprite = card.artwork;
        whatId = card.id;

    }



    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
        
       switch (bm.curCard.GetComponent<CardDisplay>().whatId)
       {
           case 0:
                Debug.Log("EYE OF RA");
                EyeOfRa();
           break;
           
           case 1:
                Debug.Log("SCARAB SHIELD");
                ScarabShield();
           break;

           case 2:
                Debug.Log("SPIRIT BOMB");
                SpiritBomb();
           break;

           case 3:
                Debug.Log("SUN MARK");
                SunMark();
           break;
           
           case 5:
                Debug.Log("RED SAND");
                SetSand();
           break;
       }
     }
    }

    void EyeOfRa()
    {
        Instantiate(eyeOfRa, eyePos.transform.position, Quaternion.identity); 
       // GetComponent<HealthAndMana>().curMana -= 20;
    }

    void ScarabShield()
    {
        Instantiate(scarabShield, scarabPos.transform.position, Quaternion.identity);
        //GetComponent<HealthAndMana>().curMana -= 10;
        
    }

    void SpiritBomb()
    {
        Instantiate(sunBomb, eyePos.transform.position, Quaternion.identity);
       // GetComponent<HealthAndMana>().curMana -= 10;
    }


    void SunMark()
    {
       
       //   pAtk.enemyBeingAttacked.GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    void SetSand()
    {
        Instantiate(rSand, fieldCardPos.transform.position, Quaternion.identity);
    }
}
