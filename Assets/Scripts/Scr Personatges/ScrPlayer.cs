using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/// <summary>
/// ----------------------------------------------------------------------------------
/// DESCRIPCIÓ
///         Script utilitzat per controlar el player 
/// AUTOR:  Elisabet Arnal i Eric Clot
/// DATA:   17/03/2021
/// VERSIÓ: 4.0
/// CONTROL DE VERSIONS
///         1.0: Moviment player i dispar(Aquest ultim no funciona)
///         2.0: Programació tripleshot. El dispar basic i el triple funcionen. 
///         3.0: Modificació del Tripleshot per a fer doble funcionalitat i millorar el gameplay.
///         4.0: Les bales es gasten. Si no hi ha munició, no es pot disparar.
/// ----------------------------------------------------------------------------------
/// </summary>


public class ScrPlayer : MonoBehaviour
  
{

    [SerializeField] float velocitat;
    
    

    Vector2 movi = new Vector2(); //Calcul moviment
    Rigidbody2D rb;               //Per accedir al riggidbody
    [SerializeField] AudioSource BasicShot;

    //**************Dispar*************
    [SerializeField] GameObject missil;
    [SerializeField] Transform[] canons;
    public GameObject control;

    //*************Dispars Seguits**************

    [SerializeField] float cadencia = 0.5f; //Dispararà cada 5 dècimes de segón
    float crono = 0f;
    float cronoPowerUp = 0;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BasicShot = GetComponent<AudioSource>();

        canons[0].gameObject.SetActive(false);
        canons[2].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        movi.x = ETCInput.GetAxis("Horizontal") * velocitat;
        movi.y = ETCInput.GetAxis("Vertical") * velocitat;
        if (ETCInput.GetButton("Shoot") && crono > cadencia) Dispar();
        if (ETCInput.GetButton("ShootTriple") && crono > cadencia) DisparTriple(true);

        crono += Time.deltaTime;

        if (ETCInput.GetButtonUp("Shoot")) crono = cadencia; //parmet disparar ràpid amb diversos clics
        if (ETCInput.GetButtonUp("ShootTriple")) crono = cadencia; //parmet disparar ràpid amb diversos clics

        if (Input.GetKeyDown(KeyCode.T))  // Prototipus triple shoot
        {
            DisparTriple(true);
            cronoPowerUp = 5;
        }
        //if (cronoPowerUp > 0) cronoPowerUp -= Time.deltaTime; else DisparTriple(false);

    }

    void FixedUpdate()
    {
        rb.velocity = movi;
    }

    void Dispar()
    {
        foreach (Transform cano in canons)
            if ((cano.gameObject.activeSelf)&&(control.GetComponent<ScrControlGame>().municio > 0))
            {
                Instantiate(missil, cano.position, cano.rotation);
                control.GetComponent<ScrControlGame>().municio -= 1;
            } 
        crono = 0;

        BasicShot.Play();
        
    }


    void DisparTriple(bool estat)
    {
        canons[0].gameObject.SetActive(estat);
        canons[2].gameObject.SetActive(estat);
        foreach (Transform cano in canons)
            if ((cano.gameObject.activeSelf) && (control.GetComponent<ScrControlGame>().municio > 0))
            {
                Instantiate(missil, cano.position, cano.rotation);
                control.GetComponent<ScrControlGame>().municio -= 1;
            }
        crono = 0;

        BasicShot.Play();

        canons[0].gameObject.SetActive(false);
        canons[2].gameObject.SetActive(false);


    }

    void Detruccio() 
    {
        Destroy(gameObject);
    }
}
