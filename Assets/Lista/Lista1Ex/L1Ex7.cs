using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex7 : MonoBehaviour
{
    // Receber uma temperatura em Fahrenheit/ e convert�-la para Celsius/ atrav�s da seguinte f�rmula: Celsius = (Fahrenheit - 32) / 1.8./ Exibir o valor em Celsius
    public float Fah;
    public float Celsi;
    void Start()
    {
        Celsi = ((Fah - 32) / 1.8f);
        Debug.Log(Celsi);
    }

    
    void Update()
    {
        
    }
}
