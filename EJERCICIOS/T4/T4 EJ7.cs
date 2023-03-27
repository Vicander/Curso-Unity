using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bicicleta: MonoBehaviour
    {
        public string nombre;
        public int marchas;
        public double precio;

        /*CONSTRUCTOR*/
        public  Bicicleta(int n, double prec, string name){
            this.set_marchas(n);    //Establecemos el numero de marchas
            this.set_nombre(name);  //Establecemos el nombre de la Bici
            this.set_precio(prec);  //Establecemos el precio de la Bici
        }

        /*GETTERS*/
        public string get_nombre(){
            // devuelve el nombre de la bici
            return this.nombre;
        }

        public int get_marchas(){
            // devuelve el número de marchas de la bici
            return this.marchas;
        }

        public double get_precio(){
            // devuelve el precio de la bici
            return this.precio;
        }

        /*SETTERS*/
        public void set_nombre(string name){
            // Establece el nombre de la bici
            this.nombre = name;
            return;
        }

        public void set_marchas(int n){
            // establece el número de marchas de la bici
            this.marchas = n;
        }

        public void set_precio(double price){
            // establece el precio de la bici
            this.precio = price;
        }
    }

public class NewBehaviourScript : MonoBehaviour{
    void Start()
    {
        /*Creamos una bici dentro de la variable mi_chiclo y haciendo uso del 
        constructor, establecemos de la misma el NOMBRE, las MARCHAS y el PRECIO*/
        Bicicleta mi_chiclo = new Bicicleta(8, 1400.00, "Mi Chiclo amarillo");
        Debug.Log(mi_chiclo.get_nombre());
        Debug.Log(mi_chiclo.get_marchas());
        Debug.Log(mi_chiclo.get_precio());   
    }
}