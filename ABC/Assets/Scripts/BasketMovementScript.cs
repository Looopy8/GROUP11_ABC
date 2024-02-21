using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    public float minX;
    public float maxX;
    public Text scoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 newPosition = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        transform.position = newPosition;

        if (score >= 10)
        {
            SceneManager.LoadScene("SecondStage");
        }

    }

    //public int points = 10;  Points to be earned when the item is collected


    private void OnCollisionEnter2D(Collision2D Collider)
    {
        // Check if the colliding object has a specific tag
        if (CompareTag("Healthy"))
        {


            Destroy(gameObject);
            score++;
            scoreText.text = "Score: " + score;
        }
        if (CompareTag("Unhealthy"))
        {

            SceneManager.LoadScene("LoseScene");
            
        }
    }
}

