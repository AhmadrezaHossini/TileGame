
using UnityEngine;

public class AnimationControler : MonoBehaviour
{
    public static AnimationControler Instance { get { return instance; } private set { } }

    private static AnimationControler instance;

    [SerializeField] private AnimEventBoardGame _animEventBoardGame;


   public Animator animMainMenu;
    public Animator animBoardGame;
    public Animator animTileGame;



    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        
        
        }
        DontDestroyOnLoad(instance);
    }


    public void PlayChangeMainMenu() 
    {
        animMainMenu.Play("ChangeSceneMain");
        _animEventBoardGame.isFirst = false;
    }


    public void AnimationClickTile(GameObject objectTile) 
    {
        animTileGame = objectTile.GetComponent<Animator>();

        animTileGame.Play("Clicked");
    
    
    
    
    }

}
