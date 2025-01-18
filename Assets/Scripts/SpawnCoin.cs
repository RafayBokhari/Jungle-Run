using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject Coin;
    public float respawntime;
    public float groundYPosition;
    public float groundHeight;
    public Transform player;
    private Vector3 lastposition;      
    public float groundLength;         

    // Start is called before the first frame update
    void Start()
    {
        lastposition = new Vector3(player.position.x + groundLength, groundYPosition, player.position.z); 

        StartCoroutine(CoinSpawner());
    }

    // Coin Spawner Coroutine
    IEnumerator CoinSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawntime);
            spawningcoins();
        }
    }

    public void spawningcoins()
    {
        float randomY = Random.Range(groundYPosition, groundYPosition + groundHeight);

        GameObject coin = Instantiate(Coin, lastposition, Quaternion.identity);

        lastposition += new Vector3(groundLength, 0, 0); // Only change X for moving forward
    }
}
//new Vector3(lastposition.x, randomY, lastposition.z)