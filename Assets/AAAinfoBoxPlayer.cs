using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FPLibrary;
using UFE3D;
using UnityEngine.Analytics;

public class AAAinfoBoxPlayer : MonoBehaviour
{
    public GameObject infoPlayerUI2;

    public Image infoBox;

    public Text namePlayer;

    public Sprite boxJUN;
    public Sprite boxTARO;
    public Sprite boxMIKU;
    public Sprite boxMARIE;

    public Image[] characters;


    // Start is called before the first frame update
    void Start()
    {
        this.infoBox.sprite = boxJUN;

        for (int i = 0; i < this.characters.Length && i < this.characters.Length; ++i)
        {
            Image character = this.characters[i];

            if (character != null)
            {
                Button button = character.GetComponent<Button>();
                if (button == null)
                {
                    button = character.gameObject.AddComponent<Button>();
                }

                if (i == 0)
                {
                    button.onClick.AddListener(() =>
                    {
                        this.infoBox.sprite = boxJUN;
                    });
                }

                if (i == 1)
                {
                    button.onClick.AddListener(() =>
                    {
                        this.infoBox.sprite = boxTARO;
                    });
                }

                if (i == 2)
                {
                    button.onClick.AddListener(() =>
                    {
                        this.infoBox.sprite = boxMIKU;
                    });
                }

                if (i == 3)
                {
                    button.onClick.AddListener(() =>
                    {
                        this.infoBox.sprite = boxMARIE;
                    });
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (UFE.gameMode == GameMode.StoryMode)
        {
            GameObject.Destroy(this.infoPlayerUI2);

        }

        else
        {
            GameObject.Destroy(this.infoBox);
        }



    }

}
