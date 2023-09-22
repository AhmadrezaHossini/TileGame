using UnityEngine.UI;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] private byte CountLevel;
    [SerializeField] private byte Numberlevel;

    [SerializeField] Button btnNext;
    [SerializeField] Button btnBack;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("LevelNumber")) 
        {
            CountLevel =(byte)PlayerPrefs.GetInt("LevelNumber");
            Numberlevel= (byte)PlayerPrefs.GetInt("LevelNumber");


        }
    }


    public void butonNext() 
    {
        if(Numberlevel != CountLevel) 
        {
            Numberlevel += 1;
        
        
        }
    
    }

    public void buttonBack() 
    {
    
    
    }

}
