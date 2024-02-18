using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private bool right = true;
    private bool left = false;
    public Animator animator;
    private bool Ground = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");


        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && Ground == true)
        {
            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
            Ground = false;
        }

        if (Input.GetKeyDown(KeyCode.A) && right == true)
        {
            transform.Rotate(Vector3.up * 180);
            left = true;
            right = false;
            
        }
        if(Input.GetKeyDown(KeyCode.D) && left == true)
        {
            transform.Rotate(Vector3.up * 180);
            left = false;
            right = true;
            
        }
        if(horizontalInput == 0)
        {
            
                animator.SetBool("Run", false);
            
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Ground = true;
        }
    }


}
