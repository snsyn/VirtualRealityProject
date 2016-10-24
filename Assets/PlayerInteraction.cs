/** UnityEngine;
using System.Collections;

public class PlayerInteraction : MonoBehaviour {


    public bool playAnim;
    private Animator ani;
      
    void OnTriggerEnter(Collider col)
    {
        switch (col.tag) {
            case "cylinderButton":
                
                break;

            
        }
                      
    } 
    void Update() {

    }
    void onCollisionEnter(Collision col) {


        switch (col.gameObject.tag)
        {
            case "cylinderButton":
                
                break;


        }
    }
} */
