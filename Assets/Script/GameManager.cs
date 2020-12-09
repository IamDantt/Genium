using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/*
public enum EstadosDeJuego
{
    EnJuego, EnPausa, EnMenu
}
*/

public class GameManager : MonoBehaviour
{
    public float timeLeft = 30.0f;

    public GameObject mano;

    public GameObject CardContainer;

    public GameObject BotonJugar;

    [Header("Sistema de puntos")]

    //public int tiempoTurno;
    //public int tiempoTurnoMax;
    public bool EstuTuTurno;
    public int TuTurno;
    public int TurnoDeOponente;
    public TextMeshProUGUI TurnoText;
    public TextMeshProUGUI TiempoText;

    //public EstadosDeJuego currentEstadosDeJuego = EstadosDeJuego.EnPausa;

    // Start is called before the first frame update
    void Start()
    {
        PausaJuego();

        BotonJugar.SetActive(true);

        //sistema de turnos
        //Jugar();
        TuTurno = 1;
        TurnoDeOponente = 0;
    }

    // Update is called once per frame
    void Update()
    {
       

        timeLeft -= Time.deltaTime;

        TiempoText.text = "Tiempo:" + " " + ((int)timeLeft).ToString();
        if (timeLeft < 0)
        {
            Debug.Log("TiempoAcabado");
        }
            //TiempoText.text = "Tiempo:" + " " + tiempoTurno.ToString();
        

        //sistema de turnos
        if (EstuTuTurno == true)
        {
            TurnoText.text = "Jugador 1".ToString();
        }
        else TurnoText.text = "Jugador 2".ToString();
    }

    IEnumerator IniciarMazo()
    {

        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardContainer, transform.position, transform.rotation);
        }

    }

    public void DarCarta()
    {

        int TamañoMano = mano.transform.childCount;

        if (TamañoMano < 5)
        {
            Instantiate(CardContainer, transform.position, transform.rotation);
        }


    }
    //<<------ sistema de turnos ----->>
    public void FinTuTurno()
    {
        EstuTuTurno = false;
        TurnoDeOponente += 1;
    }

    public void FinTurnoOponente()
    {
        EstuTuTurno = true;
        TuTurno += 1;


    }

    public void Jugar()
    {

        Time.timeScale = 1;

        BotonJugar.SetActive(false);
        StartCoroutine(IniciarMazo());
        //StartCoroutine(ContadorTurnos());

    }

    public void PausaJuego()
    {
        Time.timeScale = 0;
    }


    /*

    IEnumerator ContadorTurnos()
    {
        EstuTuTurno = true;
       yield return new WaitForSeconds(tiempoTurno);

        if (tiempoTurno == tiempoTurnoMax)
        {
            EstuTuTurno = false;
            tiempoTurno = 0;
        }

    }/*
    /*public void SetEstadoDelJuego(EstadosDeJuego newEstadoDeJuego)
    {
        if (newEstadoDeJuego == EstadosDeJuego.EnMenu)
        {
            Debug.Log("En menu");
        }
        if (newEstadoDeJuego == EstadosDeJuego.EnPausa)
        {
            Debug.Log("En pausa");
        }
        if (newEstadoDeJuego == EstadosDeJuego.EnJuego)
        {
            Debug.Log("En juego");
        }
    } */

}
