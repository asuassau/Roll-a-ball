using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    public void RestartGame()
    {
        Debug.Log("Restart Game");
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
