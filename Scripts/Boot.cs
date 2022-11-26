using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot : MonoBehaviour
{
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
            Destroy(other.gameObject);
        }
    }
}
