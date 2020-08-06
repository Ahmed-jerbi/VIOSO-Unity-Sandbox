using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class Manager : MonoBehaviour
{
    private bool partbool=false;
    public GameObject Part1, Part2;

    
    void Start()
    {

        // Activate additional Displays
        for (int i = 2; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate(); // Optionally you can add (Width, Height, Frame_rate);
        }


    }





   
    void Update()
    {
        //Rotate Sky
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1.2f);

        //Particle System Control 
        if (Input.GetKeyDown("p"))

        {   partbool = !partbool;

            if (partbool)
            {   Part1.SetActive(true);
                Part2.SetActive(true);
            }
            else
            {
                Part1.SetActive(false);
                Part2.SetActive(false);
            }
        }

        //exit on escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Exit");
        }
    }




}

