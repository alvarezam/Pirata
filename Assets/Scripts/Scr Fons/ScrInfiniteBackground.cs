using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrInfiniteBackground : MonoBehaviour
{
    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script utilitzat per fer que la imatge de fons sigui infinita amb el scroll
    /// AUTOR:  Lidia i Eli
    /// DATA:   01/03/2021
    /// VERSIÓ: 1.0
    /// ----------------------------------------------------------------------------------
    /// </summary>

    private void OnBecameInvisible()
    {
        transform.Translate(26.89f * 2f, 0f, 0f);
    }
}
