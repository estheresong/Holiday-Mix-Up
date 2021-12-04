using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour
{

    public Button openPopUp;
    public Button closePopUp;

    public GameObject popUp;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPopUp()
    {
        if (openPopUp)
        {
            popUp.SetActive(true);
            Debug.Log("You can now see the top of the box!");
        }

    }

    public void ClosePopUp()
    {
        if (closePopUp)
        {
            popUp.SetActive(false);
            Debug.Log("The pop up has been closed!");
        }
    }

   
}
