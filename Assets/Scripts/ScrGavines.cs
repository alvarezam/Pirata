using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGavines : MonoBehaviour
{
    float cadencia;
    [SerializeField] GameObject gavina;
 
    void Start()
    {
        cadencia = Random.Range(500, 2000);        
    }
   
    void Update()
    {
        cadencia -= 1;
        print(cadencia);

        if (cadencia <= 0)
        {
            Instantiate(gavina, transform.position, transform.rotation);
            cadencia = Random.Range(1000, 7500);
        }
    }
}
