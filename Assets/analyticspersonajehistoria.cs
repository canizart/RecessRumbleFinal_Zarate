using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;
using UnityEngine.EventSystems;

public class analyticspersonajehistoria : MonoBehaviour
{
    public GameObject personaje2;
    public string nombrepersonaje;
    public void enviar()
    {
        if (personaje2 != null) return;
        print  ("analytics enviados " + nombrepersonaje);
        CustomEvent datos = new CustomEvent("Historia_protagonista")
        {
            {"protagonista", nombrepersonaje } };

        AnalyticsService.Instance.RecordEvent(datos);
    }
    // Start is called before the first frame update
    

    public void enviaranalytics(string personaje) { if (personaje2 != null) return;


        if (EventSystem.current.currentSelectedGameObject == null) { }
        else 
        nombrepersonaje = personaje;
        print("modohistoria " + personaje);
    
    }
}
