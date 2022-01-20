using UnityEngine;
using System.Collections;
public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource audio;
    public float speed = 20f;
    bool start = true;
    private void Start()
    {
        StartCoroutine(StartMove());
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "p")
        {
            rb.velocity = new Vector2(rb.velocity.y/2 + collision.collider.attachedRigidbody.velocity.y/3,rb.velocity.y);
            audio.pitch = Random.Range(0.8f, 1.2f);
            audio.Play();
        }

    }
    void Force(bool left)
    {
        if (left)
        {
            rb.velocity = new Vector2(10f,10f);
        }
        else if (!left)
        {
            rb.velocity = new Vector2(-10f,-10f);
        }
    }
    IEnumerator StartMove()
    {
        yield return new WaitForSeconds(1f);
        float random = Random.value;
        if (random <= 0.5)
        {
            Force(true);
        }
        else if (random > 0.5)
        {
            Force(false);
        }
    }
    public void ResetTransform()
    {
        transform.position = new Vector3(0f, 0f, 0f);
        rb.velocity = new Vector2(0f, 0f);
        StartCoroutine(StartMove());

    }
    private void Update()
    {
        if (rb.velocity.x == 0)
        {
            if (!start)
            {
                StartCoroutine(StartMove());
            }
        }
        if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, 10f , 10f),rb.velocity.y);
        }else if (rb.velocity.y < 0)
        {
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -10f , -10f),rb.velocity.y);
        }
    }
    public IEnumerator ChangeStartBool()
    {
        yield return new WaitForSeconds(0.8f);
        start = false;
    }
}