using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance{ get{ return instance; } private set{ } }

    private static ScoreManager instance;

   private UiGameScene _uiGameScene;


    [SerializeField] private int ScoreGame;


    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        
        }
        DontDestroyOnLoad(instance);

    }


    private void Start()
    {
        _uiGameScene = FindObjectOfType<UiGameScene>();
    }

    public void AddScore(byte Score) 
    {
        ScoreGame += Score;

        _uiGameScene.txtScore.text = "Score:" + ScoreGame;


        PlayerPrefs.SetInt("Score", ScoreGame);



        //show in Ui
        //save in playerprefabs
        
    
    
    }



    public void clearData() 
    {
        ScoreGame = 0;

        _uiGameScene.txtScore.text = "Score: 0";


    }


}
