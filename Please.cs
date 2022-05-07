using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Please : MonoBehaviour
{
    public void SceneSwitcher(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void Update()
    {
        
    }
}
