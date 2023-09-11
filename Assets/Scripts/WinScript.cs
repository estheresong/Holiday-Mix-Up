using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public Button orb;

    public GameObject winPanel;

    public void getOrb()
    {
        if (orb)
        {
            winPanel.SetActive(true);
        } 
    }

}
