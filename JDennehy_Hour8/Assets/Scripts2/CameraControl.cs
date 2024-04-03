using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float sensitivity = 2f;

    void UD()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Translate(Vector3.right * mouseX);
        transform.Translate(Vector3.up * mouseY);
    }


// Update is called once per frame
void Update()
    {
        
    }
}
