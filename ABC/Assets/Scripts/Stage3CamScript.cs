using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3CamScript : MonoBehaviour
{
    public GameObject Pause;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
