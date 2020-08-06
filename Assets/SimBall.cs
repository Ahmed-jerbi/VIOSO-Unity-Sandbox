using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 2, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -2, ForceMode.Impulse);
        }
    }
}
