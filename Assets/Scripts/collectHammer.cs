using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collectHammer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Singleton.Instance.hasHammer)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        Singleton.Instance.hasHammer = true;
        Debug.Log("You have the hammer.");
    }
}
