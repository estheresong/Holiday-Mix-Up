using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafePuzzle : MonoBehaviour
{
    public GameObject openSafe;
    public GameObject Combo;
    public GameObject turnOffCombobutton;

    public Button combo1, combo2, combo3, combo4, combo5;
    public Text num1, num2, num3, num4, num5;
    int count, count1, count2, count3, count4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Singleton.Instance.hasHammer)
        {
            openSafe.SetActive(false);
            Combo.SetActive(false);
            turnOffCombobutton.SetActive(false);

        }
    }

    public void changeCombo1()
    {

        if (count < 9)
        {
            count++;
            num1.text = count.ToString();
            Debug.Log ("Slot1 is: " + count);
        }
        else if (count == 9)
        {
            count = 0;
            num1.text = count.ToString();
        }

    }
    public void changeCombo2()
    {

        if (count1 < 9)
        {
            count1++;
            num2.text = count1.ToString();
            Debug.Log("Slot2 is: " + count1);
        }
        else if (count1 == 9)
        {
            count1 = 0;
            num2.text = count1.ToString();
        }

    }
    public void changeCombo3()
    {

        if (count2 < 9)
        {
            count2++;
            num3.text = count2.ToString();
            Debug.Log("Slot3 is: " + count2);
        }
        else if (count2 == 9)
        {
            count2 = 0;
            num3.text = count2.ToString();
        }

    }
    public void changeCombo4()
    {

        if (count3 < 9)
        {
            count3++;
            num4.text = count3.ToString();
            Debug.Log("Slot4 is: " + count3);
        }
        else if (count3 == 9)
        {
            count3 = 0;
            num4.text = count3.ToString();
        }

    }
    public void changeCombo5()
    {

        if (count4 < 9)
        {
            count4++;
            num5.text = count4.ToString();
            Debug.Log("Slot5 is: " + count4);
        }
        else if (count4 == 9)
        {
            count4 = 0;
            num5.text = count4.ToString();
        }

    }

    public void SafePuzzleSolved()
    {
        if (count == 3 && count1 == 8 && count2 == 1 && count3 == 5 && count4 == 9)
        {
            openSafe.SetActive(false);
            Combo.SetActive(false);
            turnOffCombobutton.SetActive(false);
            Debug.Log("Combo was successful!");
        }
        //38159
    }

}