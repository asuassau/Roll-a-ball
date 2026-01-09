using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Este metodo carga la escena inicial del juego
    public void RestartGame()
    {
        Debug.Log("Restart Game");
        SceneManager.LoadScene(0);
    }
    //Este metodo cierra la aplicacion (util solo habiendo creado un build)
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
