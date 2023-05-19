using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boot : MonoBehaviour
{
    //Componente de texto
    public TextMeshPro texto;
    //Componente que actualiza los puntos
    public PointCounter contador;
     // Esta función se llama antes del primer fotograma
    void Start()
    {
        
    }

    // Esta función se llama cada fotograma
    void Update()
    {
        
    }
    //Esta función se llamará cada que la bota interactúe con otro objeto
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("F2D5A7_Alien"))
        {
            //Activación de componente de audio
            gameObject.GetComponent<AudioSource>().Play();
            //Activación de componente de texto
            texto.text = "¡Alien destruído!";
            contador.ActualizarPunto(1);
            //Destruir alien
            Destroy(other.gameObject);
        }
    }
}
