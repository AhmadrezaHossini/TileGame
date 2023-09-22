using UnityEngine.UI;
using UnityEngine;

public class ShowLevelText : MonoBehaviour
{
    [SerializeField] private Text _textLevel;


    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("LevelNumber"))
        {
            _textLevel.text = "Level:" + PlayerPrefs.GetInt("LevelNumber");
        }
        else
        {
            _textLevel.text = "Level:1";


        }
    }




}
