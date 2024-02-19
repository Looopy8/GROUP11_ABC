using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public GameObject Pause;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 6, 0, -10);
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            if(isPaused == true)
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
