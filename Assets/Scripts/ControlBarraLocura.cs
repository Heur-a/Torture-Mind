using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlBarraLocura : MonoBehaviour
{
    [SerializeField] private Image barraLocura; // variable para mostrar la barra de locura
    [SerializeField] private Text valorTexto; // variable para mostra el porcentaje de locura
    [SerializeField] private float maxLocura = 1f; // variable para el valor máximo de locura
    [SerializeField] private float recuperacionLocura = 0.015f; // variable para la recuperación de locura
    [SerializeField] private float hitLocura = 0.025f; // variable para el aumento de locura

    private float value = 0; // variable para el valor de locura

    void Start()
    {
        barraLocura.fillAmount = value; // Inicialización de la barra de locura
    }

    void Update()
    {
        // Si la barra de locura llega a 1, el jugador muere
        value -= recuperacionLocura * Time.deltaTime;

        // Simulación de aumento de locura al pulsar la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            value += hitLocura;
        }
        // Ajuste de los valores para que no se pase de los límites
        value = Mathf.Clamp(value, 0, maxLocura);

        // Actualización de la barra de locura
        barraLocura.fillAmount = value;

        // Actualización del texto para mostrar el valor de la locura en porcentaje
        valorTexto.text = "Locura: " + Mathf.Round(value * 100) + "%";
    }
}
