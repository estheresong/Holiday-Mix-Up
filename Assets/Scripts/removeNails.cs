using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeNails : MonoBehaviour
{
    public GameObject key, boxOpen;

    private void OnMouseDown()
    {
        if (Singleton.Instance.hasHammer)
        {
            gameObject.SetActive(false);
            key.SetActive(true);
            boxOpen.SetActive(true);
            Debug.Log("You opened the box! Get the key and you're on your way!");
        }

    }
}
