using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxPuzzle : MonoBehaviour
{
    public GameObject boxOpen;
    public GameObject key;

    // Update is called once per frame
    private void Update()
    {

        if (Singleton.Instance.hasKey)
        {
            boxOpen.SetActive(true);
            key.SetActive(false);
        }
    }


}
