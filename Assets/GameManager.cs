using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreText1;
    public movement Movement;
    public Text ScoreText2;
    int leftPlayerScore = 0;
    int RightPlayerScore = 0;
   public void Score(string wall)
    {
        if (wall == "LeftWall")
        {
            RightPlayerScore++;
        }
        else if (wall=="RightWall")
        {
            leftPlayerScore++;
        }
    }
    private void Update()
    {
        ScoreText1.text = "" + leftPlayerScore;
        ScoreText2.text = "" + RightPlayerScore;
        ScoreText1.transform.position = new Vector3(gameObject.GetComponent<GameSetup>().MainCam.ScreenToWorldPoint(new Vector3(Screen.width/2,0f,0f)).x-1, gameObject.GetComponent<GameSetup>().MainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y-1, 0f);
    }
    public void ResetButton()
    {
        RightPlayerScore = 0;
        leftPlayerScore = 0;
        Movement.ResetTransform();
    }
}