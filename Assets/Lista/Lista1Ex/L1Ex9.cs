using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex9 : MonoBehaviour
{
    // Receber um n�mero / e calcular o valor de sua raiz quadrada  e sua oitava pot�ncia. Utilize as fun��es pow(base,expoente) e sqrt(num) da biblioteca <math.h>. Mostrar os valores obtidos 
    public float Num;
    public float Base, expo;    
    
    void Start()
    {
        Mathf.Sqrt(Num);    
       

        Mathf.Pow(Base, expo);
        Debug.Log(Num);
        Debug.Log(Base);

    }

    
    void Update()
    {
        
    }
}
