using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class Manager : MonoBehaviour
{
    private bool bShowParticles=false;
    public GameObject particleObj;

    
    void Start()
    {
        // Activate multi displays
        for (int i = 0; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate(); // Optionally you can add (Width, Height, Frame_rate);
        }


    }




   
    void Update()
    {

        //Particle System ON/OFF 
        if (Input.GetKeyDown("p"))

        {   
            bShowParticles = !bShowParticles;

            if (bShowParticles) 
                particleObj.SetActive(true);
               
            else particleObj.SetActive(false);

        }

        //Exit on "Escape" button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }




}

