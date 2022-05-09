using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex13 : MonoBehaviour
{
    //R$35,00 por dia 
    public float diasT;
    private float valorFinal, desconto;
    void Start()
    {
        valorFinal = diasT * 35f;
        desconto = valorFinal * 8 / 100;
        Debug.Log(valorFinal - desconto);
    }

    void Update()
    {
        
    }
}
