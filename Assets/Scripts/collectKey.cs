using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Singleton.Instance.hasKey)
        {
            gameObject.SetActive(false);
        }
    }


    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        Singleton.Instance.hasKey = true;
        Debug.Log("You got the key!");
    }
}
