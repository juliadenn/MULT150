using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    private Light lightComponent;

    void ST()
    {
        lightComponent = GetComponent<Light>();
    }

    void UpD()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            lightComponent.enabled = !lightComponent.enabled;
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
