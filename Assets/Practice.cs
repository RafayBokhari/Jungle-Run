using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    public GameObject smallGroundPrefab;
    public GameObject mediumGroundPrefab;
    public Transform endcube;
    public Transform startcube;
   
    public float newpoint;
    // public float endpoint;
    public Vector2 endingpoint;
    public Vector2 offset;
    public float minY = -2f;
    public float maxY = 2f;
   public float spawnOffset = 0.5f;
    public GameObject enemyPrefab;
    public float enemySpawnChance = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(endcube.transform.position);
        //Debug.Log(startcube.transform.position);
        

        StartCoroutine(spawning());
        spawnerground();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void spawnerground()
    {
        GameObject groundToInstantiate;
        if (Random.Range(0, 2) == 0)
        {
            groundToInstantiate = smallGroundPrefab;
        }
        else
        {
            groundToInstantiate = mediumGroundPrefab;
        }
        float randomY = Random.Range(minY, maxY);

        GameObject newGround = Instantiate(groundToInstantiate,endingpoint + offset , Quaternion.identity);

       endingpoint = new Vector2(endingpoint.x + newpoint,randomY);


        if (groundToInstantiate == mediumGroundPrefab && Random.value < enemySpawnChance)
        {
            SpawnEnemyOnGround(newGround);
        }


    }

    void SpawnEnemyOnGround(GameObject groundPiece)
    {
        // Ensure the ground piece has a Collider2D component
        Collider2D groundCollider = groundPiece.GetComponent<Collider2D>();

        if (groundCollider != null)
        {
            // Calculate spawn position just above the ground
            Vector2 spawnPosition = groundCollider.bounds.center;
            spawnPosition += new Vector2(0, spawnOffset); // Offset to ensure the enemy is above ground

            // Instantiate the enemy
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }

    }


        IEnumerator spawning()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            spawnerground();
        }
        
    }

   
}
