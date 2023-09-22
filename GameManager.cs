using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singletone pattern var
    private static GameManager instance;

    public static GameManager Instance { get 
        {

            if (instance == null) 
            {
                instance = FindObjectOfType<GameManager>();
            
            
            }
            DontDestroyOnLoad(instance);
            return instance;


        }

        set 
        {
        
        
        }
    
    
    }


    #endregion

    readonly byte Score = 100;


    private LevelManager _levelManager;
   [SerializeField] private AnimEventBoardGame _animEventBoardGame;
   [SerializeField] private UiGameScene _uiGameScene;

   [SerializeField] private byte countSpecifictFruit;
   public StringBuilder strbuilderFruitName=new StringBuilder();


    public List<string> FruitsName = new List<string>();
    public List<GameObject> ListobjTileInSaveList = new List<GameObject>();

   [SerializeField] private List<GameObject> ListDelete=new List<GameObject>();
   [SerializeField] private byte countObjectWeDelete;


    [Header("TextMeshObject")]
    [SerializeField] private GameObject objTextMesh;






    private void OnEnable()
    {
        _levelManager = FindObjectOfType<LevelManager>();
       
       // _uiGameScene = FindObjectOfType<UiGameScene>();
    }



    public void CheckList() 
    {
        
       
        for (int i = 0; i < FruitsName.Count; i++)
        {
            if (strbuilderFruitName.ToString() == FruitsName[i]) 
            {
                countSpecifictFruit += 1;
            
            }
        }



        if (countSpecifictFruit >= 3) 
        {
            
            for (int i = 0; i < ListobjTileInSaveList.Count; i++)
            {
                TileName objfruit = ListobjTileInSaveList[i].GetComponent<TileName>();

                if (strbuilderFruitName.ToString() == objfruit.Name) 
                {
                    ListDelete.Add(objfruit.gameObject);
               
                }

 


            }

            Delete3Objects();
            ScoreManager.Instance.AddScore(Score);
           

        }

        countSpecifictFruit = 0;






    }



    private void Delete3Objects() 
    {

        countObjectWeDelete +=(byte)ListDelete.Count;

        for (int i = 0; i < ListDelete.Count; i++)
        {
            ListDelete[i].gameObject.SetActive(false);
        }

        ListDelete.Clear();
        
        AudioManagerGamePlay.Instance.PlaySoundScore();

        if (countObjectWeDelete == _levelManager.CountTiles) 
        {
            AudioManagerGamePlay.Instance.PlaySoundWin();
            StartCoroutine(_uiGameScene.IenumBackToMainMenu());
            _levelManager.SaveNewLevel();
            
            //finish the game and show PanelMainMenu
        
        }
    
    
    }



    public void ClearData() 
    {
        ListobjTileInSaveList.Clear();
        FruitsName.Clear();
        countObjectWeDelete = 0;
    
    
    
    }


}
