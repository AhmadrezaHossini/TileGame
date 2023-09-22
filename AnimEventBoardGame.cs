using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEventBoardGame : MonoBehaviour
{

    public bool isFirst;

    public void CreateTileAndLevel() 
    {
        if (isFirst == false)
        {
            SceneController.Instance._levelManager.LoadLevel();
            isFirst = true;
        }

    }

    public void PlayAdle() 
    {
        AnimationControler.Instance.animBoardGame.Play("Adle");

    }

}
