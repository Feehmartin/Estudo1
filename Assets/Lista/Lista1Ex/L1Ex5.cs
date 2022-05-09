using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex5 : MonoBehaviour
{
    // Criar um programa em Linguagem C que receba dois números inteiros e retorne: o valor da divisão e o resto da divisão
    public int valor1;
    public int valor2;  
    void Start()
    {
        Debug.Log(valor1 / valor2);
        Debug.Log(valor1 % valor2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
