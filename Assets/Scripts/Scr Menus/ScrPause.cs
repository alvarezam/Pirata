using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Utilitzo SceneManagement per poder canviar de Escena durant la partida

public class ScrPause : MonoBehaviour
{
    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script utilitzat per controlar les accions dels botons de pausa del joc.
    /// AUTOR:  Marc Alvarez Abril
    /// DATA:   21/03/2021
    /// VERSIÓ: 1.0
    /// ----------------------------------------------------------------------------------
    /// </summary>

    bool PausedLevel = false;

    public void Pause()
    {
        Time.timeScale = 0;
        PausedLevel = true;
    }
    public void Resume()
    {
        Time.timeScale = 1;
        PausedLevel = false;
    }
    public void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //Per canviar d'escena (de joc a menu)
    }
}
