using UnityEngine;
using System.Collections;

public class AnimDoor : MonoBehaviour
{

    public Animator anim;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            anim.SetBool("isOpen", true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            anim.SetBool("isOpen", false);
        }
    }

}
