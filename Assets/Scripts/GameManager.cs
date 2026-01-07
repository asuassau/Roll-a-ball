using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{


    public GameObject completeLevelUI;
    public GameObject failLevelUI;


    private void Start()
    {
        completeLevelUI.SetActive(false);
        failLevelUI.SetActive(false);
    }
    public void StartGame()
    {
        Debug.Log("Game Started!");
    }

    public void CompleteLevel()
    {
       completeLevelUI.SetActive(true);
    }

    public void FailLevel()
    {

        failLevelUI.SetActive(true);

        Debug.Log("Restarting Level! " + SceneManager.GetActiveScene().name);
    }

    public void Restart()
    {
        Debug.Log("Restarting Level! " + SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }  
    

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Debug.Log("Loading Next Level!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

