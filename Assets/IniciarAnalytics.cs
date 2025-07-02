using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class IniciarAnalytics : MonoBehaviour
{
    public static IniciarAnalytics instancia;

    /*
        private void Awake()
        {

            if(instancia!=null)
            {
                Destroy(gameObject);
            }
            else
            {
                instancia = this;
                DontDestroyOnLoad(this);
            }
        }
    */


    async void Start()
    {
        await UnityServices.InitializeAsync();

        ConsentGiven();
    }

    void AskForConsent()
    {
        // ... show the player a UI element that asks for consent.
    }

    void ConsentGiven()
    {
        AnalyticsService.Instance.StartDataCollection();
    }
}
