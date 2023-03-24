using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeScenes()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
       
        if (currentScene == 0)
        {
            SceneManager.LoadScene(1);
        } else
        {
            SceneManager.LoadScene(0);
        }
        Debug.Log("Scene Changed");
    }
}