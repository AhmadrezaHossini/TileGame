using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance { get { return instance; } private set { } }

    private static SceneController instance;

   

    [Header("object for game scene")]
    public LevelManager _levelManager;

    [SerializeField] private GameManager _gameManager;
    [SerializeField] private ScoreManager _scoreManager;

  [SerializeField] private UiGameScene _uiGameScene;
    [SerializeField] private SpriteList _spriteList;
 

    [SerializeField] GameObject GameBoard;
    [SerializeField] GameObject Canvas_gameplay;
    [SerializeField] GameObject AudioManagergameplay;



    [Header("object in main menu")]
    [SerializeField] GameObject Canvas_MainMenu;
    [SerializeField] GameObject AudioManagerMainMenu;
    [SerializeField] GameObject JustObjectShowLevel;


    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        
        }
        DontDestroyOnLoad(gameObject);


        
      
    }

    public void GamePlayScene() 
    {
      
        AudioManagerMainMenu.SetActive(false);
        JustObjectShowLevel.SetActive(false);
        _gameManager.gameObject.SetActive(true);
        _uiGameScene.gameObject.SetActive(true);
        _scoreManager.gameObject.SetActive(true);
        _spriteList.gameObject.SetActive(true);
        GameBoard.SetActive(true);
        Canvas_gameplay.SetActive(true);
        Canvas_MainMenu.gameObject.SetActive(false);
    
        AudioManagergameplay.SetActive(true);
        

  
    
    
    
    }

    public void BackMainMenu() 
    {
        Canvas_MainMenu.gameObject.SetActive(true);
        JustObjectShowLevel.SetActive(true);
        AudioManagerMainMenu.SetActive(true);
        _gameManager.gameObject.SetActive(false);
        _uiGameScene.gameObject.SetActive(false);
        _scoreManager.gameObject.SetActive(false);
        _spriteList.gameObject.SetActive(false);
        GameBoard.SetActive(false);
        Canvas_gameplay.SetActive(false);
        AudioManagergameplay.SetActive(false);
        AnimationControler.Instance.animMainMenu.Play("Adle");

    }


}
