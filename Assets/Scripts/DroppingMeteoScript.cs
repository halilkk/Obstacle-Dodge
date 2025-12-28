using TMPro;
using Unity.IntegerTime;
using UnityEngine;
using UnityEngine.UI;

public class DroppingMeteoScript : MonoBehaviour
{

    [SerializeField] float time;
    float realtime = TimeScript.value;
       


    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    
    void Update()
    {
        realtime = TimeScript.value;


        if (realtime >= time)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
