using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
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

        StartCoroutine(EnemiesSpawner());
    }

    // Coin Spawner Coroutine
    IEnumerator EnemiesSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawntime);
            spawningenemy();
        }
    }

    public void spawningenemy()
    {
        float randomY = Random.Range(groundYPosition, groundYPosition + groundHeight);
         
        int randomValue = Random.Range(0,enemies.Length);

        GameObject Enemy = Instantiate(enemies[randomValue], new Vector3(lastposition.x, randomY, lastposition.z), Quaternion.identity);

        lastposition += new Vector3(groundLength, 0, 0); // Only change X for moving forward
    }
}

