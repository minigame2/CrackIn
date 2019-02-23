using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    enum Scenes { StartScene, MainScene, GameOverScene };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene((int)Scenes.StartScene);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene((int)Scenes.MainScene);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene((int)Scenes.GameOverScene);
    }

}