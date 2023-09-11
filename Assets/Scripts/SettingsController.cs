using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    //Image changeColor;
    public Image swatch;
    public List<Sprite> colorOptions = new List<Sprite>();
    private int n = 0;

    //Text charName;
    public string inputName;
    public InputField IF;

    public string lvlDiff;
    public Dropdown Dd;
    void Start()
    {
        //changeColor = GameObject.Find("colorSwatch").GetComponent<Image>();
        //changeColor.sprite = Singleton.Instance.changeColor[Singleton.Instance.colorIndex];

        //charName = GameObject.Find("Txt_charName").GetComponent<Text>();
        //charName.text = Singleton.Instance.charName;

        IF = GameObject.Find("IF_Name").GetComponent<InputField>();
        IF.text = Singleton.Instance.charName;
    }

    public void chooseRight()
    {
        n++;
        if (n == colorOptions.Count)
        {
            n = 0;
        }
        swatch.sprite = colorOptions[n];
    }

    public void chooseLeft()
    {
        n--;
        if (n < 0)
        {
            n = colorOptions.Count - 1;
        }
        swatch.sprite = colorOptions[n];
    }

    public void playerName()
    {
        inputName = IF.text;
        Debug.Log("Name has changed to: " + inputName);
    }

    public void SetDifficulty()
    {

        if (Dd.value == 0)
        {
            lvlDiff = "Easy";
        }
        if (Dd.value == 1)
        {
            lvlDiff = "Hard";
        }

        Debug.Log("Difficulty changed to " + lvlDiff);


    }
}
