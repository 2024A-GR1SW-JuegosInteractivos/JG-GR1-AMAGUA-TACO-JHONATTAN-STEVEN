using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    // Start is called before the first frame update
     void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entrando en trigger");
        if (collision.tag == "Paquete")
        {
            Debug.Log("Recogo paquete");

        }
        if (collision.tag == "Cliente")
        {
            Debug.Log("Entrego paquete");

        }
        
    }
}
