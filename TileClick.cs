using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileClick : MonoBehaviour
{

    [SerializeField] private Vector3 FirstPosition;
   
    public GameObject FruitPlaceInSaveList;

    private void Awake()
    {
        FirstPosition = transform.position;
    }

    private void OnEnable()
    {
        ResetPositionBlock();
    }


    private void OnMouseDown()
    {
        TileName _tilename = GetComponent<TileName>();
        AnimationControler.Instance.AnimationClickTile(this.gameObject);

        GameManager.Instance.FruitsName.Add(_tilename.Name);
        GameManager.Instance.ListobjTileInSaveList.Add(gameObject);

        GameManager.Instance.strbuilderFruitName.Clear();
        GameManager.Instance.strbuilderFruitName.Append(_tilename.Name);
     

         GameManager.Instance.CheckList();
        




     
    }



 
    private void ResetPositionBlock() 
    {
        transform.position = FirstPosition;
        
    }




    public void forwardobject() 
    {
        transform.position = FruitPlaceInSaveList.transform.position;
        FruitPlaceInSaveList.GetComponent<MoveForward>().changeXPosition();
        AnimationControler.Instance.animTileGame.Play("Adle");
    }




}
