using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControlObjectwKeys : MonoBehaviour
{
    public bool translation;
    public bool rotation = false;
    public float moveSpeed = 1.00f;


    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {   
        // Translation : Arrow keys + AWDS
        if (translation)
        {transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime); }
       
      
       
       
        
        // Mouse Control
        if (rotation)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            
        }
    }
}
