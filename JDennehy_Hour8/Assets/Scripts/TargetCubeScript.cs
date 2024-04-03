using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCubeScript : MonoBehaviour
{
    // This is the game object you want to access
    private GameObject target;

    void B()
    {
        target = GameObject.Find("Cube");
    }

    void U()
    {
        target.transform.Translate(0.05f, 0f, 0f);
        target.transform.Rotate(0f, 0f, 1f);
        target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }

// Update is called once per frame
void Update()
    {
        
    }
}
