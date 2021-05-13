using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorManager : MonoBehaviour
{
    public List<Color> allColors = new List<Color>();
    public static colorManager instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        instance = this;
    }

    public Color GetRandomColor() {
        return allColors[Random.Range(0, allColors.Count)];
    }
}
