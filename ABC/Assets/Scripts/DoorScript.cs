using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public Animator animator;
    private bool open = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)&& animator.GetCurrentAnimatorStateInfo(0).IsName("OpeningDoor"))
        {
            SceneManager.LoadScene("FirstStage");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && open == true)
        {
            
            animator.Play("OpeningDoor");
            
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            animator.Play("ClosingDoor");

        }
    }
    public void Key()
    {
        open = true;
    }
    
}
