using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public static float value;
    private bool isRunning = false;

    private void Start()
    {
        value = 0f;
}

    void Update()
    {
        
            value += Time.deltaTime; 
            timerText.text = value.ToString("F2"); 
        
    }

}