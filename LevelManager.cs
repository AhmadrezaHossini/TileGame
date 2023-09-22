using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{



    public byte NumberLevel;
    [Header("config tiles every level")]
    public byte CountTiles;
    public List<TileData> lisTiledata = new List<TileData>();

    [Header("set data in tile")]
    public GameObject[] ListParentLevels;
    public List<GameObject> ListTiles;
   


  

   
   public void LoadLevel ()
    {
      
        if (PlayerPrefs.HasKey("LevelNumber")) 
        {
           
            LevelNumber((byte)PlayerPrefs.GetInt("LevelNumber"));
           // Debug.Log("we are in LoadLevel:"+ (byte)PlayerPrefs.GetInt("LevelNumber"));
        }
        else 
        {
            PlayerPrefs.SetInt("LevelNumber", 1);
            NumberLevel =(byte)PlayerPrefs.GetInt("LevelNumber");
            LevelNumber(NumberLevel);

        }

      

    }

    public void SaveNewLevel() 
    {
        if (NumberLevel != 3)
        {
            NumberLevel = (byte)PlayerPrefs.GetInt("LevelNumber");
            NumberLevel += 1;
            PlayerPrefs.SetInt("LevelNumber", NumberLevel);

        }
        else { Debug.Log("Finish the Game"); }

    }

    private void LevelNumber(byte levelNumber) 
    {
      

        switch (levelNumber) 
        {
            case 1:
               
                CountTiles = 6;
              byte[]  arrayTileNumberLevel1 = { 0, 1, 2, 3, 4, 5 };
              byte[]  arrayFruitNumberInTileLevel1 = {1,0,1,0,1, 0 };
           

             ListParentLevels[0].SetActive(true);






                





                for (byte i = 0; i <CountTiles ; i++)
                {
                    lisTiledata.Add(new TileData()
                    {
                        TileNumber = arrayTileNumberLevel1[i],
                        fruitNumber = arrayFruitNumberInTileLevel1[i]
                    }); 
                }


                for (byte i = 0; i < CountTiles; i++)
                {
                    ListTiles.Add ( ListParentLevels[0].transform.GetChild(i).gameObject);
                    ListTiles[i].SetActive(true);
                    ListTiles[i].GetComponent<TileName>().makeNameFruit(lisTiledata[i].fruitNumber);
                }





               







                break;

            case 2:

                CountTiles = 9;
                byte[] arrayTileNumberLevel2 = { 0, 1, 2, 3, 4, 5,6,7,8 };
                byte[] arrayFruitNumberInTileLevel2 ={ 0,1,1,2,0,1,0,2,2 };


                ListTiles = ListTiles = new List<GameObject>(ListParentLevels[1].transform.childCount);

                ListParentLevels[0].SetActive(false);
                ListParentLevels[1].SetActive(true);

                for (byte i = 0; i < CountTiles; i++)
                {
                    lisTiledata.Add(new TileData()
                    {
                        TileNumber = arrayTileNumberLevel2[i],
                        fruitNumber = arrayFruitNumberInTileLevel2[i]
                    });

                 

                }





                for (byte i = 0; i < CountTiles; i++)
                {
                    ListTiles.Add(ListParentLevels[1].transform.GetChild(i).gameObject);
                    ListTiles[i].SetActive(true);
                    ListTiles[i].GetComponent<TileName>().makeNameFruit(lisTiledata[i].fruitNumber);
                }












                break;

            case 3:

                CountTiles = 12;
                byte[] arrayTileNumberLevel3 = { 0, 1, 2, 3, 4, 5, 6, 7, 8,9,10,11 };
                byte[] arrayFruitNumberInTileLevel3 = { 2,1,1,0,2,3,0,1,3,0,3,2 };

            

                ListParentLevels[0].SetActive(false);
                ListParentLevels[1].SetActive(false);
                ListParentLevels[2].SetActive(true);


                for (byte i = 0; i < CountTiles; i++)
                {
                    lisTiledata.Add(new TileData()
                    {
                        TileNumber = arrayTileNumberLevel3[i],
                        fruitNumber = arrayFruitNumberInTileLevel3[i]
                    });

                  


                }




                for (byte i = 0; i < CountTiles; i++)
                {
                    ListTiles.Add(ListParentLevels[2].transform.GetChild(i).gameObject);
                    ListTiles[i].SetActive(true);
                    ListTiles[i].GetComponent<TileName>().makeNameFruit(lisTiledata[i].fruitNumber);
                }







                break;
        
        
        
        
        
        }
    
    
    
    
    }















    public void ClearData() 
    {
        ListTiles.Clear();
        lisTiledata.Clear();
    
    }



}
