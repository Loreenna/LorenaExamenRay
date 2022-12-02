using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text Tempo;
    public float Tiempo = 0.0f;
    public bool DebeAumentar = false;
    public bool CuentaAtras;
    private float stringTime;
    private float minutes;
    private float seconds;
    public float totalTime;

    private void Start()
    {
        stringTime = totalTime;  
    }

    void Update() 
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("ClickPumba");
            
        }
        
        if(CuentaAtras == true)
        {
            if (DebeAumentar) 
            Tiempo += Time.deltaTime; 
            // Primero se comprueba que sea falso el tener que aumentar.
        else 
        {
            if (Tiempo <= 0.0f)  // Comprueba si es menor o igual a cero.
            { DebeAumentar = false; } // Para volver true a este.
            else 
            { Tiempo -= Time.deltaTime; } // De lo contrario, sigue bajando.
        }

        Tempo.text = "Tiempo:" + " " + Tiempo.ToString ("f0");
        }
    }
}