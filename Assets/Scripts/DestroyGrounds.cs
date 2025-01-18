using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGrounds : MonoBehaviour
{
    public Camera mainCamera; // Camera ka reference
    public Transform player; // Player ka reference
    public float destroyOffset = 10f; // Offset jo camera ke view ke aage chala jaye
    public float destroy;
    void Update()
    {
        // Destroy karna hai un ground pieces ko jo camera ke view se bahar hain
        DestroyOffscreenGround();
        DestroyCoinoffScreen();
        DestroyoffscreenEnemies();
    }

    void DestroyOffscreenGround()
    {
        // Sab ground pieces ko find karo
        GameObject[] groundPieces = GameObject.FindGameObjectsWithTag("Ground");

        foreach (GameObject ground in groundPieces)
        {
            // Check karo agar ground piece camera ke view se bahar hai
            if (IsBehindCamera(ground))
            {
                Destroy(ground); // Ground piece ko destroy karo
            }
        }
    }

    void DestroyCoinoffScreen()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        foreach (GameObject coin in coins)
        {
            if(isbehindcameraCoin(coin))
            {
                Destroy(coin);

            }
        }
    }

    void DestroyoffscreenEnemies()
    {
        GameObject[] Ememies = GameObject.FindGameObjectsWithTag("Enemies");
        foreach (GameObject bird in Ememies)
        {
            if (isbehindCameraEnemy(bird))
            {

                Destroy(bird);
            }
        }
    }

    bool isbehindCameraEnemy(GameObject bird)
    {
        float cameraX = mainCamera.transform.position.x;
        return bird.transform.position.x < cameraX - destroy;
    }


    bool isbehindcameraCoin(GameObject iscoinout)
    {
        float camerax = mainCamera.transform.position.x;
        return iscoinout.transform.position.x < camerax - destroy;
    }

    bool IsBehindCamera(GameObject obj)
    {
        float cameraX = mainCamera.transform.position.x;
        return obj.transform.position.x < cameraX - destroyOffset;
    }
}
