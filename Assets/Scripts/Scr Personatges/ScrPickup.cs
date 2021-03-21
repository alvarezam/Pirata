using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPickup : MonoBehaviour
{
    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script utilitzat per moure els pickups
    /// AUTOR:  Eric Clot Martín
    /// DATA:   21/03/2021
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: ...es mouen.
    ///         2.0: 
    /// ----------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] Rigidbody2D rb;
    [SerializeField] Collider2D col;
    Vector2 moviment = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        moviment.x = -2;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moviment;
    }
}
