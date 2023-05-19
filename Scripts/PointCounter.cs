using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    private int puntos = 0;
    private int perdidas = 0;

    //Naves a desactivar al ganar el juego
    public Spaceship[] naves;

    //Indicativo para actualizar el texto de victoria
    public TextMeshPro texto;

    public AudioClip ganancia;
    public AudioClip perdida;

    public void ActualizarPunto(int cantidad){
        puntos += cantidad;

        if(puntos >= 20){
            texto.text = "¡Ganaste!";
            //Activación de componente de audio
            gameObject.GetComponent<AudioSource>().clip = ganancia;
            gameObject.GetComponent<AudioSource>().Play();
            for(int i = 0; i< naves.Length; i++){
                naves[i].continua = false;
            }
        }
    }

    public void ActualizarPerdidas(int cantidad){
        perdidas += cantidad;
        if(perdidas >= 5){
            texto.text = "¡Perdiste!";
            //Activación de componente de audio
            gameObject.GetComponent<AudioSource>().clip = perdida;
            gameObject.GetComponent<AudioSource>().Play();
            for(int i = 0; i< naves.Length; i++){
                naves[i].continua = false;
            }
        }
    }
}
