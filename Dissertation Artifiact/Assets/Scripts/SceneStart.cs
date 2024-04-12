using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{
    public string scene;

    
    // Update is called once per frame
    public void LoadSceneOnClick()
    {
        SceneManager.LoadScene(scene);
    }
}
