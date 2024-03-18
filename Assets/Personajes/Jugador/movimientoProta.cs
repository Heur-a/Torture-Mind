using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script para el movimiento del personaje principal
public class movimientoProta : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 5.0f;                     // Velocidad de movimiento
    private CharacterController controller;             // Controlador de personaje
    [SerializeField]
    private bool isdead = false;                        // Variable para saber si el personaje ha muerto

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();  // Obtenemos el controlador de personaje
    }//Start()

    // Update is called once per frame
    void Update()
    {
        //el giro es instantáneo, por lo que se aplica directamente
        //si pulsamos la tecla W o S, el personaje se mueve hacia delante o hacia atrás
        //si pulsamos la tecla A o D, el personaje rota a la izquierda o a la derecha

        Vector3 movimiento = Vector3.zero;
        if(isdead == false)
        {                                                                   // Si el personaje no ha muerto
            if (Input.GetKey(KeyCode.W))                
            {
                movimiento += Vector3.forward;
            }//if()
            if (Input.GetKey(KeyCode.S))
            {
                movimiento += -Vector3.forward;
            }//if()
            if (Input.GetKey(KeyCode.A))
            {
                movimiento += Vector3.left;
            }//if()
            if (Input.GetKey(KeyCode.D))
            {
                movimiento += Vector3.right;
            }//if()
        }//if()
        else
        {                                                                   // Si el personaje ha muerto
            movimiento = Vector3.zero;
        }//else()
        movimiento = movimiento.normalized * velocidad * Time.deltaTime;    // Normalizamos el vector de movimiento y lo multiplicamos por la velocidad y el tiempo
        controller.Move(movimiento);                                        // Movemos el personaje
    }//()   
}// fin movimientoProta()
