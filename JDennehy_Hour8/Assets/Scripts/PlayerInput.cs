using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    void Start()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        if (hVal != 0)
            Debug.Log("Horizontal movement selected: " + hVal);

        if (vVal != 0)
            Debug.Log("Vertical movement selected: " + vVal);
    
    }


// Update is called once per frame
void Update()
    {
        
    }
}
