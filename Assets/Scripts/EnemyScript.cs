using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    //public float endvalue;
    public float speed;
    public Vector3 MoveBird;
    // Start is called before the first frame update
    void Start()
    {
        //EnemyMove();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MoveBird*speed*Time.deltaTime);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.CompareTag("Player"))
    //    {
    //        SceneManager.LoadScene("Game");
    //    }
    //}


    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //public void EnemyMove()
    //{
    //    // transform.DOMoveX(endvalue, duration);
    //  //  transform.DOMoveX(endvalue, duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    //    transform.DOMoveX(endvalue, duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    //    //transform.DOMove(new Vector3(endvalue,0,0),duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    //}

}
