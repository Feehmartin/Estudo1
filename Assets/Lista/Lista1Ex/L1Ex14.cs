using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex14 : MonoBehaviour
{
    //duas provas nota de 0 a 10, prova teoria tem peso 60% e a pratica 40%

    public float notaTeorica;
    public float notaPratica;
    
    void Start()
    {
        //nao consegui

        float notaFinalTeorica = notaTeorica * 60 / 100;
        float notaFinalPratica = notaPratica * 40 / 100;
        
        Debug.Log(notaFinalTeorica + notaFinalPratica);
    }

    void Update()
    {
        
    }
}
