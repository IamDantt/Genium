using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CartaEnlazador : MonoBehaviour
{
    public Image FondoCarta;
    public Image FondoTema;
    public Image SimboloElemental;
    public Image ParaLogo;
    public Image Region;
    public Image TipoElemento;
    public Image Esfera;
    public Image NotacionEspectral;

    public Image Icono;

    public Image ColorFamilia;
    //public TextMeshProUGUI ColorSimbolo;

    public TextMeshProUGUI NumeroAtomico;
    public TextMeshProUGUI NombreElemento;
    
    public TextMeshProUGUI SimboloAtomico;
    public TextMeshProUGUI PesoAtomico;


    public Image Marco;

   public Carta c;

    public GameObject Mano;

    public GameObject Mazo;

    public int ProximaCarta;

    void Start()
    {
        
    }
    
    public void CargarCarta()
    {
        Marco.sprite = c.marco;

        FondoCarta.sprite = c.fondoCarta;
        FondoTema.sprite = c.fondoTema;
        SimboloElemental.sprite = c.simboloElemental;
        ParaLogo.sprite = c.paraLogo;
        Region.sprite = c.paraLogo;
        Region.sprite = c.region;
        TipoElemento.sprite = c.tipoElemento;
        Esfera.sprite = c.esfera;
        NotacionEspectral.sprite = c.notacionEspectral;

        Icono.sprite = c.icono;

       

       // ColorSimbolo.color = c.colorSimbolo;

	    NumeroAtomico.text = "" + c.numeroAtomico;
	    NombreElemento.text = c.nombreElemento;
	    
	    SimboloAtomico.text = c.simboloAtomico;
	    PesoAtomico.text = "" + c.pesoAtomico;


        ElegirColorFamilia();


    }

    public void ElegirColorFamilia()
    {
        ColorFamilia.color = c.colorFamilia;
    }

    public void Update()
    {
        if(this.tag == "FrenteMazo")
        {
            Mazo = GameObject.Find("Mazo");
            ProximaCarta = Mazo.GetComponent<MazoJugador>().tamañoMazo - 1;
            c = Mazo.GetComponent<MazoJugador>().mazo[ProximaCarta];
            Mazo.GetComponent<MazoJugador>().tamañoMazo -= 1;

            Mano = GameObject.Find("Hand");
            transform.SetParent(Mano.transform);
            transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            transform.position = new Vector3(0, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);

            CargarCarta();

            tag = "EnMano";
        }
        
    }

}
