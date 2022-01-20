using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool RightPlayer = false;
    public float speed = 10;
    public Rigidbody2D rb;
    public Vector3 xo;
    public GameSetup gs;
    void FixedUpdate()
    {
        if (!RightPlayer)
        {
            if (Input.GetKey("w"))
            {
                gs.x += speed;
            }
            else if (Input.GetKey("s"))
            {
                gs.x -= speed;
            }

        }
        else
        {
            if (Input.GetKey("up"))
            {
                gs.o += speed;
            }
            else if (Input.GetKey("down"))
            {
                gs.o -= speed;
            }
        }
    }
}