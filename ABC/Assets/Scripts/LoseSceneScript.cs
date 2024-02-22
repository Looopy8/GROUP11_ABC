using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseSceneScript : MonoBehaviour
{

    public void OnClickRestartBtn()
    {
        SceneManager.LoadScene("FirstStage");
    }

    public void OnClickMainMenuBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnQuitBtnClick()
    {
        Application.Quit();
    }

















    
}




