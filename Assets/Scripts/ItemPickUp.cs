using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        Singleton.DontDestroyOnLoad(key);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}