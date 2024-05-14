using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void GoToSceneTwo()
    {
        SceneManager.LoadScene("cozytale");

    }

  
    public void GoToSceneThree()
    {
        SceneManager.LoadScene("fairytale");

    }

    public void GoToSceneFour()
    {
        SceneManager.LoadScene("legend");

    }

    public void GoToSceneFive()
    {
        SceneManager.LoadScene("spooky");

    }


    public void GoToSceneOne()
    {
        SceneManager.LoadScene("home");

    }



}
