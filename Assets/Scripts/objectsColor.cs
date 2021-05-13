using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int k = 0;
        foreach(SpriteRenderer s in GetComponentsInChildren<SpriteRenderer>())
        {
            s.color = colorManager.instance.allColors[k++];

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
