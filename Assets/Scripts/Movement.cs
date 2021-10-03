using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour
{
    
    public Text _gameover;
    public float Speed = 4f;
    //private float movement = 0f;
    public GameObject blood;

    Vector2 movement;
    public Rigidbody2D rb;
    public Animator animator;

    public int MaxHealth = 100;
    public int CurrentHealth;
    public healthBar healthBar;
    public GameObject CompletePanel;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;


    // Start is called before the first frame update
    void Start()
    {
        //Speed = 4f;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        calMovement();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Instantiate(blood, transform.position, Quaternion.identity);
            TakeDamage(20);
        }
        else if(CurrentHealth < 20)
        {
            SceneManager.LoadScene(2);
            _gameover.gameObject.SetActive(true);
            StartCoroutine(GameOverFlickerRoutine());
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Complete"))
        {
            CompletePanel.SetActive(true);
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            Time.timeScale = 0;
        }
    }
   public void calMovement()
    {

        movement.x = CrossPlatformInputManager.GetAxis("Horizontal");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (movement.x > 0)
        {
            rb.velocity = new Vector2(movement.x * Speed, rb.velocity.y);
            // anim.Play("P");

        }

        else if (movement.x < 0)
        {
            rb.velocity = new Vector2(movement.x * Speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        healthBar.SetHealth(CurrentHealth); 
    }

    IEnumerator GameOverFlickerRoutine()
    {
        while (true)
        {
            _gameover.text = "GAME OVER";
            yield return new WaitForSeconds(0.5f);
            _gameover.text = "";
            yield return new WaitForSeconds(0.5f);
        }
    }
}
