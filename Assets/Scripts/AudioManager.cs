using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource1;
    public static AudioManager audioManager;
    public AudioClip jump;
    public AudioClip death;
    public AudioClip coin;
   


    private void Start()
    {
        if (audioManager == null)
        {
            audioManager = this;
            //DontDestroyOnLoad(gameObject);
        }
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

    public void Coinplay()
    {
        audioSource1.PlayOneShot(coin, 0.5f);
    }
     
    public void Jump()
    {
        audioSource1.PlayOneShot(jump, 0.5f);
    }
    public void Death()
    {
        audioSource1.PlayOneShot(death, 0.5f);
    }
    //public void BackgroundSound()
    //{
    //    audioSource1.Play();
    //}
}


   

