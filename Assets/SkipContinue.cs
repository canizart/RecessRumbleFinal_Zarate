using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;

public class SkipContinue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saltear (bool X)
    {
        if (X) {
            CustomEvent botonSaltear = new CustomEvent("skipped")
            {
                {"skip", X}

            };

            AnalyticsService.Instance.RecordEvent(botonSaltear);
        }

        else {
            CustomEvent botonSaltear = new CustomEvent("skipped")
            {
                {"skip", X}

            };

            AnalyticsService.Instance.RecordEvent(botonSaltear);
        }
    }
       

}
