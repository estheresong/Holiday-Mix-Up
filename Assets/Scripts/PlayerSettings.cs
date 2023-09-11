using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    Image changeColor;

    public Text charName;

    void Start()
    {
        changeColor = GameObject.Find("colorSwatch").GetComponent<Image>();
        changeColor.sprite = Singleton.Instance.changeColor[Singleton.Instance.colorIndex];

        charName = GameObject.Find("Txt_charName").GetComponent<Text>();
        charName.text = Singleton.Instance.charName;
    }

}
