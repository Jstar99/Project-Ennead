using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarabShield : MonoBehaviour
{
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pos.transform.position.x, pos.transform.position.y, pos.transform.position.z);
    }
}
