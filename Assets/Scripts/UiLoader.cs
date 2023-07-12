using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiLoader : MonoBehaviour
{
      
    
    

    private void Awake()
    {
        MainMenuController mainMenuController = Resources.Load<MainMenuController>("Ui Prefabs/MainMenu");
        GameObject.Instantiate<MainMenuController>(mainMenuController);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
