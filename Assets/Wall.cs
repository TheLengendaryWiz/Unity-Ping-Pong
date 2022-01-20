using UnityEngine;

public class Wall : MonoBehaviour
{
    string myName;
    public GameManager gm;
    public AudioSource audio;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ball")
        {
            audio.Play();
            myName = transform.name;
            gm.Score(myName);
            collision.GetComponent<movement>().ResetTransform();
        }
    }
}
