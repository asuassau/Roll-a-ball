using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Este método carga el primer nivel del juego
    public void LoadFirstLevel()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Este método cierra la aplicación 
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
