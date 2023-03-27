using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoin : MonoBehaviour
{

    public int CoinNumber;
    void Start()
    {
        CoinNumber = 0;
    }

    private void OnTriggerEnter2D (Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("coin"))
        {
            Destroy (collider2D.gameObject);
            CoinNumber++;
        }
    }
}
