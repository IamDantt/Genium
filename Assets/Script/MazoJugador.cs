using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazoJugador : MonoBehaviour
{
    public List<Carta> mazo;

    public CartaDB TablaPeriodicaDB;

    public int x;
    public int tamañoMazo;

    void Start()
    {
        x = 0;
        for (int i = 0; i < tamañoMazo; i++)
        {
            x = Random.Range(0, TablaPeriodicaDB.coleccion.Count);
            mazo[i] = TablaPeriodicaDB.coleccion[x];
        }
    }

    
}
