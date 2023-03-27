using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool toxicBool;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        while (collider2D.gameObject.CompareTag("ToxicZone"))
        {
            anim.SetBool("toxic", toxicBool);
        }

    }

}