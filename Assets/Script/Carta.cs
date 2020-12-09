 using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
public enum ColorDeFamilia{
    Actinidos, Calcogeno, Carbonoideos, Gasesnobles, Halogeno, Lantanidos, Metalalcalino, Metalesalcalinoterreos, Metalestransicion,
    Nitrogenoideos, Terreos
}*/

[CreateAssetMenu(menuName = "MenuElementos/Carta")]

public class Carta : ScriptableObject
{

   // public ColorDeFamilia currentColorDeFamilia = ColorDeFamilia.Actinidos;

    public Sprite marco;

    public Sprite fondoCarta;
    public Sprite fondoTema;
    public Sprite simboloElemental;
    public Sprite paraLogo;
    public Sprite region;
    public Sprite tipoElemento;
    public Sprite esfera;
    public Sprite notacionEspectral;

    public Sprite icono;

    public Color colorFamilia;

    //public Color colorSimbolo;

    public int numeroAtomico;
    public string nombreElemento;
    //public string notacionEspectral;
    public string simboloAtomico;
    public float pesoAtomico;

    private void Awake()
    {
        
    }

    /*
    public void SetColorFamilia(ColorDeFamilia newColorFamilia)
    {
        if (newColorFamilia == ColorDeFamilia.Actinidos)
        {
            colorFamilia = Color.red;
        }
        else if (newColorFamilia == ColorDeFamilia.Calcogeno)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Carbonoideos)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Gasesnobles)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Halogeno)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Lantanidos)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Metalalcalino)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Metalesalcalinoterreos)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Metalestransicion)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Nitrogenoideos)
        {

        }
        else if (newColorFamilia == ColorDeFamilia.Terreos)
        {

        }
        this.currentColorDeFamilia = newColorFamilia;
    }

   */

}
