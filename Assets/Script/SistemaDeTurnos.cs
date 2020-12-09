using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SistemaDeTurnos : MonoBehaviour
{
    public bool EstuTuTurno;
    public int TuTurno;
    public int TurnoDeOponente;
    public TextMeshProUGUI TurnoText;


    // Start is called before the first frame update
    void Start()
    {
        Jugar();
        TuTurno = 1;
        TurnoDeOponente = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (EstuTuTurno == true)
        {
            TurnoText.text = "Jugador 1".ToString();
        } else TurnoText.text = "Jugador 2".ToString();
    }

    public void FinTuTurno()
    {
        EstuTuTurno = false;
        TurnoDeOponente += 1;
    }

    public void FinTurnoOponente()
    {
        EstuTuTurno = false;
        TuTurno += 1;


    }

    public void Jugar()
    {
        EstuTuTurno = true;
    }
}
