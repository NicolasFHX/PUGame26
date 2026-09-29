using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadLevel(int id)
    {
        SceneManager.LoadScene(id);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
