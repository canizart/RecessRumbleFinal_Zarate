using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class Evento_VerControles : MonoBehaviour
{
    public Text namePlayer1;
    public Text namePlayer2;

    // Start is called before the first frame update
    void Start()
    {
        /*Analytics.CustomEvent("ver_controles", new Dictionary<string, object>{     
        {"protagonista",  UFE.config.player1Character.characterName}

        });*/

        AnalyticsService.Instance.CustomData("ver_controles", new Dictionary<string, object>{
        {"protagonista",  UFE.config.player1Character.characterName}

        });


        //Ejemplo

        /*CustomEvent NombreFunción = new CustomEvent("NombreQueVaEnAnalitycs")
    {
         { "NombreParamentro", "TipoDeDato"}

    };
        
        AnalyticsService.Instance.RecordEvent(NombreFunción);*/


        //Prueba

        CustomEvent Prueba = new CustomEvent("ver_controlesPrueba")
        {
         { "protagonista", UFE.config.player1Character.characterName}

        };

        AnalyticsService.Instance.RecordEvent(Prueba);

    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
