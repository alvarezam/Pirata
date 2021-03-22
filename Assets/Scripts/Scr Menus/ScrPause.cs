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

    public bool PausedLevel = false; //Es la variable que utilitzo per pausar el joc

    //https://answers.unity.com/questions/850220/how-can-i-get-a-ui-canvas-to-hideappear-on-esc-but.html

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0; //Pausa
        PausedLevel = true;
    }
    public void Resume()
    {
        Time.timeScale = 1; //Treure Pausa
        PausedLevel = false;
    }
    public void Exit()
    {
        Time.timeScale = 1; //Torno a treure la pausa del joc cuant tornes al main menu perque cuant tornes a començar la patida es bugueja
        PausedLevel = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //Per canviar d'escena (de joc a menu)
    }
}
