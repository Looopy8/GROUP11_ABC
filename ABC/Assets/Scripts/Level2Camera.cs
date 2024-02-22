using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;
    public GameObject Pause;
    public bool isPaused = false;

    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movePosition = target.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            if (isPaused == true)
            {
                Pause.SetActive(true);
            }
            else
            {
                Pause.SetActive(false);
            }

        }
    }
}
