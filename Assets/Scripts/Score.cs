using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoretext;
    public Text Hiscoretext;
   
    public static Score newScore;

    public float score;
    private float hiscore;
    public float pointspersec;
    private void Start()
    {
        if(newScore == null)
        {
            newScore = this;
        }

        if (PlayerPrefs.HasKey("HiScore"))
        {
            hiscore = PlayerPrefs.GetFloat("HiScore");

        }


    }
    private void Update()
    {
        // scoretext.text = myscore.ToString();
        score += pointspersec * Time.deltaTime;
        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetFloat("HiScore",hiscore);
        }
        scoretext.text = Mathf.Round(score).ToString();
        Hiscoretext.text = Mathf.Round(hiscore).ToString(); 
    }

    //public void AddScore(int score)
    //{
    //   myscore = myscore + score;
    //}

}