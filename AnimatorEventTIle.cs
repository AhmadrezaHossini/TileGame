using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEventTIle : MonoBehaviour
{
    private TileClick _tileClick;


 public void ActionHideAnimator() 
    {
        _tileClick = GetComponent<TileClick>();

        _tileClick.forwardobject();
        
    
    
    
    }







}
