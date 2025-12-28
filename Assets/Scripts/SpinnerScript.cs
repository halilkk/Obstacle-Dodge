using UnityEngine;

public class SpinnerScript : MonoBehaviour
{

    [SerializeField] float rspeed;

     
    void Update()
    {
        Spin();
    }

    void Spin()
    {
        transform.Rotate(0, 0, rspeed);
    }
}
