using System.Collections;
using System.Collections.Generic;
using Unity.Services.Core;
using Unity.Services.Analytics;
using UnityEngine.UI;
using UnityEngine;

public class ReviewManager : MonoBehaviour
{
    private int stars;

    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        stars = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStars(int _count)
    {
        stars = _count;
    }

    public int GetStars()
    {
        return stars;
    }

    public void Send()
    {
       if(stars != -1)
        {
            /*Analytics.CustomEvent("calificacion", new Dictionary<string, object>{
              {"nota", stars}
           });*/

            CustomEvent calificacion = new CustomEvent("calificacion")
            {
                { "Nota", stars}

            };

            //AnalyticsService.Instance.RecordEvent(calificacion);

            
            Debug.Log( stars);
        }
        else
        {
            Debug.LogWarning("WARNING: You are trying to send a review without stars. This is unconcievable.");
        }
    }


	
    public void ReviewTaro()
    {
        if (stars != -1)
        {
            string TARO = "TARO";
            reviews(TARO,stars);


            }
        else
        {
            Debug.LogWarning("WARNING: You are trying to send a review without stars. This is unconcievable.");
        }
    }



    public void ReviewMiku ()
    {
        if (stars != -1)
        {
            string MIKU = "MIKU";
            reviews(MIKU,stars);

        }
        else
        {
            Debug.LogWarning("WARNING: You are trying to send a review without stars. This is unconcievable.");
        }
    }

    public void ReviewJun()
    {
        if (stars != -1)
        {
            string JUN = "JUN";
            reviews(JUN,stars);

            //Debug.Log("taro"+stars);
        }
        else
        {
            Debug.LogWarning("WARNING: You are trying to send a review without stars. This is unconcievable.");
        }
    }

    public void ReviewMarie()
    {
        if (stars != -1)
        {
            string MARIE = "MARIE";
            reviews(MARIE,stars);

            //Debug.Log("taro"+stars);
        }
        else
        {
            Debug.LogWarning("WARNING: You are trying to send a review without stars. This is unconcievable.");
        }
    }

	public void reviews(string protagonista, int cantidadStars){
        

        CustomEvent calificarhistoria = new CustomEvent("calificar_historia")
            {
                {"protagonista", protagonista},
                {"puntaje", cantidadStars}

            };

        AnalyticsService.Instance.RecordEvent(calificarhistoria);

        Debug.Log("evento calificar_historia protagonista = " + protagonista);
        Debug.Log("evento calificar_historia puntaje = " + cantidadStars);
    }
}
