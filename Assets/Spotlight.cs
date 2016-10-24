using UnityEngine;
using System.Collections;

public class Spotlight : MonoBehaviour
{

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (GetComponent<Light>().enabled == false)
            {
                GetComponent<Light>().enabled = true;
                 
            }
            else
            {
                GetComponent<Light>().enabled = false;
            }
        }
    }
}
