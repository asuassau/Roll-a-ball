using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

    public void LoadFirstLevel()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
