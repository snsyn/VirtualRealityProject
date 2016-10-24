using UnityEngine;
using System.Collections;

public class Moveit : MonoBehaviour {

    private Animator ani;

    // Use this for initialization
    void onTriggerEnter (Collider col) {

        if (col.CompareTag("Player")) {
            ani.SetBool("triggered", true);
        }
	
	}
	
	// Update is called once per frame
	void onTriggerExit (Collider col) {

        if (col.CompareTag("Player"))
        {
            ani.SetBool("triggered", false);
        }
    }
}
