using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex12 : MonoBehaviour
{   // paga R$10,00 por hora / R$15,00 por hora extra
    public float horasN, horasE;
   
    void Start()
    {
      // nao consegui
      float valorNormal = horasN * 10;
      float valorExtra = horasE * 15;
      
      Debug.Log(valorExtra + valorNormal);
    }

    void Update()
    {
        
    }
}
