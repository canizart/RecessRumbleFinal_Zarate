using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Pines : MonoBehaviour
{
    public Button[] botones;
    // Desde el inspector, traer cada uno de los botones

    // Posicionar cada una de las imagenes/Pines/flechas. Si pasas el Mouse por el boton 1, la imagen 1 se activa. La 2 con la 2, 3 con 3, etc etc etc
    public GameObject[] imagenes;

    // Start is called before the first frame update

    private PointerEventData pointerData;
    private EventSystem eventSystem;

    void Start()
    {
        // Inicializar el sistema de eventos
        eventSystem = EventSystem.current;
        pointerData = new PointerEventData(eventSystem);
    }

    void Update()
    {
        // Obtener la posición actual del mouse
        pointerData.position = Input.mousePosition;

        // Crear una lista para almacenar los resultados del raycast
        List<RaycastResult> results = new List<RaycastResult>();

        // Realizar el raycast desde la posición del mouse y almacenar los resultados
        eventSystem.RaycastAll(pointerData, results);

        // Recorrer los botones para verificar si el mouse está sobre alguno de ellos
        for (int i = 0; i < botones.Length; i++)
        {
            bool isMouseOver = false;

            foreach (RaycastResult result in results)
            {
                // Si el objeto en el resultado es uno de los botones, activar la imagen correspondiente
                if (result.gameObject == botones[i].gameObject)
                {
                    imagenes[i].SetActive(true);
                    isMouseOver = true;
                    break;
                }
            }

            // Desactivar la imagen si el mouse no está sobre el botón
            if (!isMouseOver)
            {
                imagenes[i].SetActive(false);
            }
        }
    }
}

