using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex10 : MonoBehaviour
{
    // Calcular e exibir o consumo médio de combustível de um veículo recebendo a distância percorrida e a quantidade de combustível gasto. 
    //Consumo médio = distância percorrida (km) / combustível gasto (l).
    public float distanciaKm, combustivel;

    void Start()
    {
        Debug.Log(distanciaKm / combustivel);
    }

    
    void Update()
    {
        
    }
}
