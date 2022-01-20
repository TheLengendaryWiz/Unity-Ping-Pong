using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public Camera MainCam;
    public BoxCollider2D topWall,bottomWall,rightWall,leftWall;
    public Transform playerLeft,playerRight;
    public Vector3 players;
    public float x =0;
    public float o=0;
    void Update()
    {
        Vector3 left = MainCam.ScreenToWorldPoint(new Vector3(75f, players.y, 0f));
        Vector3 right = MainCam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, players.y, 0f));
        left.y = x;
        right.y = o;
        left.z = 0f;
        right.z = 0f;
        topWall.size = new Vector2((MainCam.ScreenToWorldPoint(new Vector3(Screen.width,0f,0f)).x)*2,1f);
        topWall.offset = new Vector2(0f, MainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
        bottomWall.size = new Vector2((MainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x) * 2, 1f);
        bottomWall.offset = new Vector2(0f, MainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
        rightWall.size = new Vector2(1f,(MainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y)*2f);
        rightWall.offset = new Vector2(MainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + .5f,0f);
        leftWall.size = new Vector2(1f,(MainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y)*2f);
        leftWall.offset = new Vector2(MainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - .5f,0f);
        playerLeft.position = left;
        playerRight.position = right;
    }
}