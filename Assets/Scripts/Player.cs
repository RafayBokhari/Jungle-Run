using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpspeed;
    public LayerMask Ground;
    private Collider2D playercollider;
    public Animator animator;
    public AudioSource audioSource;
    public Player player;
    public float coincollect = 15f;
    public float distance;
    private float distancecount;
    public float speedmultiply;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playercollider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
        // AudioManager.audioManager.BackgroundSound();

        distancecount = distance;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > distancecount)
        {
            distancecount += distance;
            speed = speed * speedmultiply;
            distance += distance * speedmultiply;
        }




        rb.velocity = new Vector2(speed, rb.velocity.y);

        bool grounded = Physics2D.IsTouchingLayers(playercollider, Ground);
        if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {

                AudioManager.audioManager.Jump();
                rb.velocity = new Vector2(rb.velocity.x, jumpspeed);

            }
        }
        animator.SetBool("Grounded", grounded);

        if (transform.position.y < -6f)
        {
            // SceneManager.LoadScene("Game");
            UIManager.uI.Gameover();
            AudioManager.audioManager.Death();
            Time.timeScale = 0f;

            // 

        }

        if (rb.velocity.y < 0)
        {
            Debug.Log("Incread");

            rb.gravityScale = 8.0f;  // Increase gravity when falling
        }
        else
        {
            Debug.Log(" not Incread");
            rb.gravityScale = 1.0f;  // Normal gravity when jumping
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            AudioManager.audioManager.Coinplay();
            //Score.newScore.AddScore(1);
            Score.newScore.score += coincollect;
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemies")
        {
            UIManager.uI.Gameover();
            AudioManager.audioManager.Death();
            Time.timeScale = 0f;
        }

    }

}