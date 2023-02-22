using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 tamanio;

    void Start()
    {
        tamanio = new Vector3 (0.01f, 0.01f, 0.01f);
    }

    void Update()
    {
        transform.localScale += tamanio;

        if (transform.localScale.y < 0.1f || transform.localScale.y > 1f)
        {
            tamanio = -tamanio;
        
        }
    }
}