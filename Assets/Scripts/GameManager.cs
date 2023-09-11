using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{

    public Button exit;
    public Button openPopUp;
    public Button closePopUp;
    public GameObject popUp;
    public GameObject spritePopUp;

    public GameObject inventoryKey;
    public GameObject inventoryHammer;
    private void Update()
    {
        if (Singleton.Instance.hasHammer)
        {
            inventoryHammer.SetActive(true);

        }

        if (Singleton.Instance.hasKey)
        {
            inventoryKey.SetActive(true);
            inventoryHammer.SetActive(false);
        }
    }
    public void LoadSceneByNumber(int sceneNumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneNumber);
        SceneManager.LoadScene(sceneNumber);
    }

    public void OpenPopUp()
    {
        if (openPopUp)
        {
            popUp.SetActive(true);
            spritePopUp.SetActive(true);
            Debug.Log("The pop up has been opened!");
        }

    }
    public void ClosePopUp()
    {
        if (closePopUp)
        {
            popUp.SetActive(false);
            spritePopUp.SetActive(false);
            Debug.Log("The pop up has been closed!");
        }
    }

    public void Exit_Game()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        Debug.Log("Game has ended.");
    }
}
