using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class retratos : MonoBehaviour
{
    public Button miBoton;
    public Button botonchroma;

    public Sprite fondo;

    public Image marcoselector;
    public Image marcoselectorp2;

    public GameObject imagenfondo;
    public GameObject animacionpersonaje;
    public GameObject fondodefault;
    public GameObject retrato2;

    public GameObject botondefault;

    // Start is called before the first frame update
    void Start()
    {
        marcoselector.enabled = false;
        marcoselectorp2.enabled = false;
        imagenfondo = GameObject.FindGameObjectWithTag("imagenfondo");
       
       


    }

    // Update is called once per frame
    void Update()
    {  

        if (EventSystem.current.currentSelectedGameObject == miBoton.gameObject
            || EventSystem.current.currentSelectedGameObject == botonchroma.gameObject)


        { marcoselector.enabled = true;
            marcoselectorp2.enabled = true;
            //Debug.Log("El botón está seleccionado");
            fondodefault.SetActive(false);
            imagenfondo.GetComponent<Image>().sprite = fondo;
            if (retrato2 != null) return;
            if (animacionpersonaje != null)
                animacionpersonaje.SetActive(true);


        }
        else if (!fondodefault.activeInHierarchy && EventSystem.current.currentSelectedGameObject == null) { }
        
        else
        {
            if (animacionpersonaje != null)
                animacionpersonaje.SetActive(false);

        }
    }
}
