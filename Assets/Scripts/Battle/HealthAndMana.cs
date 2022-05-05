using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndMana : MonoBehaviour
{
    public Image ManaBar;
    private int  maxMana = 100;
    public int curMana; 

    // Start is called before the first frame update
    void Start()
    {
        curMana = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Charging();
    }

    void ManaCost()
    {
        //curMana -= 
    }

    void Charging()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            maxMana += 1;
        }
    }
}
