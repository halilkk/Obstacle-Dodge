using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void loadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void closeProgram()
    {
        Application.Quit();
    }
}
