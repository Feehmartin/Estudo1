using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex8 : MonoBehaviour
{
    // Calcular e exibir o perímetro de uma circunferência recebendo seu raio. A fórmula para o cálculo é C = 2 * * r (utilizar = 3.14)
    public float Cir; 
    void Start()
    {
        Cir = 2 * 3.14f;
        Debug.Log(Cir);
    }

   
    void Update()
    {
        
    }
}
