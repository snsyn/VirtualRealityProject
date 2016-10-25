using UnityEngine;
using System.Collections;

public class AnimWall : MonoBehaviour
{

    public Animator anim;
    public Animator anim2;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            anim.SetBool("isStarted", true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            anim.SetBool("isStarted", false);
            anim2.SetBool("isOpen", true);
        }
    }

}
