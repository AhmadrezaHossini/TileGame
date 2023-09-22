using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileName : MonoBehaviour
{
    public string Name;
    public GameObject objSprite;

    public void makeNameFruit(byte numberFruit)
    {
        switch (numberFruit)
        {
            case 0:

                Name = "Orange";
                objSprite.GetComponent<SpriteRenderer>().sprite = SpriteList.instance.listSpriteFruit[0].sprite;
                break;


            case 1:
                Name = "Banana";
                objSprite.GetComponent<SpriteRenderer>().sprite = SpriteList.instance.listSpriteFruit[1].sprite;
                break;


            case 2:
                Name = "Cherry";
                objSprite.GetComponent<SpriteRenderer>().sprite = SpriteList.instance.listSpriteFruit[2].sprite;
                break;


            case 3:

                Name = "Onion";
                objSprite.GetComponent<SpriteRenderer>().sprite = SpriteList.instance.listSpriteFruit[3].sprite;

                break;
        }




    }
}
