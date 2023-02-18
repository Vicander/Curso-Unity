using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
        void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            Debug.Log("Space Key Pressed");
        }
    }
}