using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deckbuilding : MonoBehaviour
{
    private int num;
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;

    // Start is called before the first frame update
    void Start()
    {
        num = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(num >= 3)
        {   
            num = 3;
        }

        if(num <= 1)
        {
            num = 1;
        }
        DisplayMenu();
    }

    void DisplayMenu()
    {
        switch (num)
        {
            case 1:
                menu1.SetActive(true);
                menu2.SetActive(false);
                menu3.SetActive(false);
            break;
            case 2:
                menu1.SetActive(false);
                menu2.SetActive(true);
                menu3.SetActive(false);
            break;
            case 3:
                menu1.SetActive(false);
                menu2.SetActive(false);
                menu3.SetActive(true);
            break;
        }
    }


    public void NextBtn()
    {
        num += 1;
    }

    public void BackBtn()
    {
        num -= 1;
    }
}
