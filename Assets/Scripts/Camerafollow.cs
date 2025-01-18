using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform target;
   Vector3 offset;
     float distance;
  
    // Start is called before the first frame update
    void Start()
    {
       offset = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = target.transform .position.x - offset.x;
        transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);

       offset = target.transform.position;
    }
}
