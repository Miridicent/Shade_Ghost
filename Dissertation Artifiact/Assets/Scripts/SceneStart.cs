using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{
    public string scene;

    
    //Loads the secene specified in the inspector upon clicking the button
    public void LoadSceneOnClick()
    {
        SceneManager.LoadScene(scene);
    }
}
