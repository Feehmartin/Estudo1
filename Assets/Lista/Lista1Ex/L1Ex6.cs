using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex6 : MonoBehaviour
{
    // Receber base e altura de um triângulo / calcular sua área / e exibir o valor calculado
    //entrada 
    public int Base;
    public int Altura; 
    void Start()
    {
        int area = Base * Altura / 2;
        Debug.Log(area);
    }

    
    void Update()
    {
        
    }
}
