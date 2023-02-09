using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{

    private int numeroCili = 10;
    private GameObject[] cilindros = new GameObject[10];
    private int dist = 5; // Distancia entre cilindros
    private int index; // Índice de un cilidro dentro de cilindros


    
    void Start(){
        
        for (int i = 0; i < numeroCili; i++)
            {
                cilindros[i] =  GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
    
        foreach (GameObject cilindro in cilindros)
            {   
                index = Array.IndexOf(cilindros, cilindro); // obtenemos la posicion del cilindro dentro de la lista
                cilindro.transform.localPosition = new Vector3(dist*index, 0, 0);
            } 
    }   
}