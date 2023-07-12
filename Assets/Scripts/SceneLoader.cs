using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        Menu,
        Prototype
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.Menu.ToString());
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(Scene.Prototype.ToString());
    }
}
