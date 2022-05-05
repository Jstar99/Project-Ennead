using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlBattleController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.O))
        {
            anim.SetBool("play", true);
        }
        else
        {
            anim.SetBool("play",false);
        }
    }
}
