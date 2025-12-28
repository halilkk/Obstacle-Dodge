using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour
{
    [SerializeField] float movespeed = 1f;
    float xspeed;
    float zspeed;

    void Start()
    {
    }

    void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        xspeed = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        zspeed = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;

        transform.Translate(xspeed, 0, zspeed);
    }
}
