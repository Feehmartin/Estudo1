using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex10 : MonoBehaviour
{
    // Calcular e exibir o consumo m�dio de combust�vel de um ve�culo recebendo a dist�ncia percorrida e a quantidade de combust�vel gasto. 
    //Consumo m�dio = dist�ncia percorrida (km) / combust�vel gasto (l).
    public float distanciaKm, combustivel;

    void Start()
    {
        Debug.Log(distanciaKm / combustivel);
    }

    
    void Update()
    {
        
    }
}
