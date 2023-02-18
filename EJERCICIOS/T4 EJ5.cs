using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velochitat = 5;

    private bool max = false;
    private bool min = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -20)
        {
            min = true;
            max = false;
            
        }
        if (transform.position.y >= 20)
        {
            min = false;
            max = true;
            
        }
        if (max)
        {
            transform.Translate(Vector3.down * velochitat * Time.deltaTime);
        }
        if (min)
        {
            transform.Translate(Vector3.up * velochitat * Time.deltaTime);
        }
    }
}
