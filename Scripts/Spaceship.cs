using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    //Referencia al alien que se generará
    public GameObject AlienPrefab;
    
    //Lugar donde los aliens se generarán
    public Transform ubicacionInicial;

    //Lugar al que atacarán los aliens
    public Transform objetivo;

    //Temporizador para la creación de Aliens
    public float frecuenciaDeAliens = 10.0f;
    float temporizador;

    // Esta función se llama antes del primer fotograma
    void Start()
    {
        temporizador = frecuenciaDeAliens;
        CrearAlien();
    }

    //Crear alien en una ubicación con un objetivo
    void CrearAlien(){
        //Instanciar alien en una ubicación inicial, sin ninguna rotaicón 
        GameObject alien = Instantiate(AlienPrefab, ubicacionInicial.position, Quaternion.identity);
        //Componentes del alien modificables para cada instancia

        //Añadir tomate a script de alien
        Alien alienScript = alien.GetComponent<Alien>();
        alienScript.tomate = objetivo;

        //Añadir nueva fuente para la restricción de mirar del alien
        LookAtConstraint restriccionAlien = alien.GetComponent<LookAtConstraint>();
        //Crear una fuente para la restricción
        ConstraintSource fuenteRestriccion = new ConstraintSource();
        fuenteRestriccion.sourceTransform = objetivo;
        fuenteRestriccion.weight = 1;
        restriccionAlien.AddSource(fuenteRestriccion);
    }

    // Esta función se llama cada fotograma
    void Update()
    {
        descontarTiempo();
    }

    //Descontar tiempo del temporizador, crear un alien y reiniciarlo cuando este llegue a cero.
    void descontarTiempo(){
        if (temporizador> 0){
            temporizador -= Time.deltaTime;
        }
        else{
            temporizador = frecuenciaDeAliens;
            CrearAlien();
        }
    }
}
