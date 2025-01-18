using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer background;
    public float backgroundspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //background.material.mainTextureOffset += new Vector2(backgroundspeed*Time.deltaTime, 0f);
        background.material.mainTextureOffset = background.material.mainTextureOffset + new Vector2(backgroundspeed * Time.deltaTime, 0f);
    }
}
