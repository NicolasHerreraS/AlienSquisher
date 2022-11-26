using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public float velocidad = 1.0f;

    //Componente del tomate que se utilizará para el seguimiento
    public Transform tomate;
    
     // Esta función se llama antes del primer fotograma
    void Start()
    {
        
    }

    // Esta función se llama cada fotograma
    void Update()
    {
        Seguir();
    }

    // Esta función contendrá la lógica del seguimiento del alien
    void Seguir(){
        //Multiplicar velocidad por el tiempo entre fotogramas
        float desplazamiento = velocidad *  Time.deltaTime;
        //Añadir el desplazamiento al vector actual de posición
        transform.position = Vector3.MoveTowards(transform.position, tomate.position, desplazamiento);
    }
}
