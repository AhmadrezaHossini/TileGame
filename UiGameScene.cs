using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class UiGameScene : MonoBehaviour
{
    private LevelManager _levelManager;
    private GameManager _gamemanager;

    public Text txtScore;
    [SerializeField] private Text txtWin;


    private void Awake()
    {
        _levelManager = FindObjectOfType<LevelManager>();
        _gamemanager = FindObjectOfType<GameManager>();
    }

    public IEnumerator IenumBackToMainMenu() 
    {
        txtWin.gameObject.SetActive(true);
        _levelManager.ClearData();
        _gamemanager.ClearData();
      

        yield return new WaitForSeconds(.5f);
        ScoreManager.Instance.clearData();

        txtWin.gameObject.SetActive(false);
        SceneController.Instance.BackMainMenu();
    
    
    
    }
}
