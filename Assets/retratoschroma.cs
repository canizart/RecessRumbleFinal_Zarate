using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class retratoschroma : MonoBehaviour
{
    public GameObject retrato2;
    public Button miBoton;

    public GameObject animacionpersonaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (retrato2 == null)
        {
            miBoton.interactable = false;
        }
        
    }
}
