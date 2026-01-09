using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{

    // se cran dos variables publicas para asignar los paneles de UI en el inspector

    public GameObject completeLevelUI;
    public GameObject failLevelUI;


    private void Start()
    {
        // Al iniciar el juego, se aseguran de que ambos paneles de UI esten desactivados
        completeLevelUI.SetActive(false);
        failLevelUI.SetActive(false);
    }
    public void StartGame()
    {
        // solo es para debuggear
        Debug.Log("Game Started!");
    }

    //al completar el nivel, se activa el panel de UI correspondiente
    public void CompleteLevel()
    {
       completeLevelUI.SetActive(true);
    }

    //al fallar el nivel, se activa el panel de UI correspondiente
    public void FailLevel()
    {

        failLevelUI.SetActive(true);

        //Debug.Log("Restarting Level! " + SceneManager.GetActiveScene().name);
    }

    // este metodo recarga la escena actual para reiniciar el nivel 
    public void Restart()
    {
       // Debug.Log("Restarting Level! " + SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //este metodo cierra la aplicacion (util solo habiendo creado un build)
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    // este metodo carga el siguiente nivel en la secuencia de escenas
    public void LoadNextLevel()
    {
        Debug.Log("Loading Next Level!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

