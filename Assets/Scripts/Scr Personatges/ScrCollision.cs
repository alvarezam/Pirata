using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrCollision : MonoBehaviour
{

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script utilitzat per detectar colisions. "Mira" el que fan, resten vida,
    ///         els destrueix si aquesta arriba a 0, reprodueixen audio...
    /// AUTOR:  Lídia Garía Romero
    /// DATA:   15/03/2021
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: No es pot comprovar el seu funcionament perquè el Player no està programat.
    ///         2.0: S'ha afegit els audios de tocat i enfonsat del player. El player no es destueix.
    /// ----------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] float vida = 0f;

    [SerializeField] AudioClip tocat, enfonsat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool impacte = false;

        ScrDamage Damage = collision.GetComponent<ScrDamage>(); //intentem llegir el scrDamage per comprovar si collisiona amb algo que treu vida i no un pickup, per exemple.

        if (Damage) // si l'objecte tenia l'script scrDamage associat:
        {
            if (tag == "Player" && Damage.damagePlayer > 0)
            {
                vida -= Damage.damagePlayer;
                impacte = true;
            }

            else if (tag != "Player" && Damage.damageNPC > 0)
            {
                vida -= Damage.damageNPC;
                impacte = true;
            }
        }

        if (impacte)
        {
            if (vida <= 0 && enfonsat)
                AudioSource.PlayClipAtPoint(enfonsat, Camera.main.transform.position);
            if (vida <= 0 && tocat)
                AudioSource.PlayClipAtPoint(tocat, Camera.main.transform.position);
        }
    }
}
