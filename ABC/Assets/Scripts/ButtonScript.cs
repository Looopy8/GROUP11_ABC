using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public void OnClickStart()
    {
        SceneManager.LoadScene("FirstStage");
    }

    public void OnClickCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void OnQuitButtonClick()
    {
        
        Application.Quit();
    }
    
    public void OnClickBack()
    {
        SceneManager.LoadScene("MainScene");
    }
}


