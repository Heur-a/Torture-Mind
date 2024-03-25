using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlBarraLocura : MonoBehaviour
{
    [SerializeField] private Image barraLocura;
    [SerializeField] private float maxLocura = 1f;
    [SerializeField] private float recuperacionLocura = 0.015f;
    [SerializeField] private float hitLocura = 0.025f;

    private float value = 0;

    // Start is called before the first frame update
    void Start()
    {
        barraLocura.fillAmount = value;
    }

    // Update is called once per frame
    void Update()
    {
        // Si la barra de locura llega a 1, el jugador muere
        value -= recuperacionLocura * Time.deltaTime;

        // Simulación de aumento de locura al pulsar la barra espaciadora
        if(Input.GetKeyDown(KeyCode.Space))
        {
            value += hitLocura;
        }
        // Ajuste de los valores para que no se pase de los limites
        value = Mathf.Clamp(value, 0, maxLocura);

        // Actualización de la barra de locura
        barraLocura.fillAmount = value;
    }
}
