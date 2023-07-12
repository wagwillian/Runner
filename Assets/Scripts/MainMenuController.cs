using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{


    [SerializeField] private Button _easyButton;
    [SerializeField]
    private Button _mediumButton;
    private void Awake()
    {
        _easyButton.onClick.AddListener(OnEasyClicked);
        _mediumButton.onClick.AddListener(OnMediumClicked);
    }
    private void OnEasyClicked()
    {
        // Set Difficult to easy  GameSettings.Instance.SetDifficult(Difficuties.Easy);
        SceneLoader.Instance.LoadGame();
    }
    private void OnMediumClicked()
    {
        //GameSettings.Instance.SetDifficult(Difficuties.Medium);
        SceneLoader.Instance.LoadGame();
    }

        
}
