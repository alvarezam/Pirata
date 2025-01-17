﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Utilitzo SceneManagement per poder canviar de Escena durant la partida

public class ScrMenu : MonoBehaviour
{
    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script utilitzat per controlar les accions dels botons del menu d'inici.
    /// AUTOR:  Marc Alvarez Abril
    /// DATA:   21/03/2021
    /// VERSIÓ: 1.0
    /// ----------------------------------------------------------------------------------
    /// </summary>

    public void Link()
    {
        Application.OpenURL("https://www.emav.com/");
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Per canviar d'escena (de menu a joc)
    }
    public void Exit()
    {
        Application.Quit(); //Per sortir del joc
    }
}
