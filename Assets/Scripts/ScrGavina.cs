using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGavina : MonoBehaviour
{
    float velocitatX, velocitatY;

    void Start()
    {
        velocitatX = Random.Range(-3, -1);

        if(transform.position.y < 0)
        {
            velocitatY = Random.Range(5, 1);
        }
        else
        {
            velocitatY = Random.Range(-5, -1);
        }
    }

    void Update()
    {
        transform.Translate(velocitatX * Time.deltaTime, velocitatY * Time.deltaTime, 0);
    }
}
