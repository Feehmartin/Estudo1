using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Ex8 : MonoBehaviour
{
    // Calcular e exibir o per�metro de uma circunfer�ncia recebendo seu raio. A f�rmula para o c�lculo � C = 2 * * r (utilizar = 3.14)
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
