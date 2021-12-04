using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

        public Button exit;
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
            Debug.Log("The pop up has been opened!");
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
    public void Exit_Game()
    {
        if (exit)
        {
          UnityEditor.EditorApplication.isPlaying = false;
          Debug.Log("Game has ended.");
        }

    }
}
