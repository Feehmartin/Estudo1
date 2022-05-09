using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class L1Ex4 : MonoBehaviour
{
    //Receber o ano de nascimento de uma pessoa e mostrar aproximadamente quantos dias de vida ela tem
    public int Ano;
    public int AnoNasc;
    
    
    void Start()
    {
        
        Debug.Log((Ano - AnoNasc) * 365 );
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
