using UnityEngine;
using System.Collections;

public class WallUp : MonoBehaviour
{

    public Animator anim;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            anim.SetBool("isOpen", false);
        }
    }

}