using UnityEngine;

public class CrusherScript : MonoBehaviour
{
    [SerializeField] float speed;
    float time = TimeScript.value;
    float nextime;
    bool crush = false;
   

    void Start()
    {
        nextime = 0.5f;
    }


    void Update()
    {
        time = TimeScript.value;

        if (nextime <= time)
        {
            crush = !crush;
            nextime = time + 0.5f;
        }

        if (!crush)
        {
            transform.Translate(0, -2f*Time.deltaTime*speed, 0);
        }
        else
        {
            transform.Translate(0, 2f*Time.deltaTime*speed, 0);
        }

    }
 }
