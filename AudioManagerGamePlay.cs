using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerGamePlay : MonoBehaviour
{
    public static AudioManagerGamePlay Instance { get { return instance; } private set { } }

   private static AudioManagerGamePlay instance;


  [SerializeField]  private AudioSource sourceSoundWin;
  [SerializeField]  private AudioSource SourceSoundGetScore;




    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        
        }

        DontDestroyOnLoad(instance);
    }





    public void PlaySoundScore() 
    {
        SourceSoundGetScore.PlayOneShot(SourceSoundGetScore.clip);    
    }

    public void PlaySoundWin() 
    {
        sourceSoundWin.PlayOneShot(sourceSoundWin.clip);
    
    }


}
