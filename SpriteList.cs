using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteList :MonoBehaviour
{
    public static SpriteList instance;

    public List<SpriteRenderer> listSpriteFruit;

    private void Awake()
    {
        instance = this;
    }

}
