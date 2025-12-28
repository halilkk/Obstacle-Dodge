
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("FinishScene");
        }
    }
}
