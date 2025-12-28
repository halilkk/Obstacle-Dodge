using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGame()
    {
        
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
    }

    public void CloseProgram()
    {
        Application.Quit();
    }
}
