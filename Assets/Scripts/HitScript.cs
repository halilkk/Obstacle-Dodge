using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitScript : MonoBehaviour
{
    [SerializeField] GameObject particle;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {   
            particle.transform.parent = other.transform.parent.transform;
            particle.SetActive(true);
            other.gameObject.SetActive(false);
            StartCoroutine(exitt());
        }

        IEnumerator exitt()
        {
            yield return new WaitForSeconds(2f);
            TimeScript.value = 0;
            SceneManager.LoadScene("RetryScene");
        }
    }
}
