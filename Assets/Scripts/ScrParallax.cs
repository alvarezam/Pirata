using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrParallax : MonoBehaviour
{
    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script utilitzat pel moviment dels elements del fons amb efecte parallax
    /// AUTOR:  Lidia i Eli
    /// DATA:   01/03/2021
    /// VERSIÓ: 1.0
    /// ----------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] float velocitat = 0f;

    void Update()
    {
        transform.Translate(velocitat * Time.deltaTime, 0, 0);
    }
}
