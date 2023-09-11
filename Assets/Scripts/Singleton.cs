using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }

    public bool hasKey = false;
    public bool hasHammer = false;

    public string gameDiff = null;

    public List<Sprite> changeColor;
    public int colorIndex;
    public string charName = "";

    public void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void ResetGame()
    {

    }
}
