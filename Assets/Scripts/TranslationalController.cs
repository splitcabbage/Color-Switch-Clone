using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationalController : MonoBehaviour
{
    [SerializeField] Vector2 limits = Vector2.one;
    [SerializeField] Vector2 speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);

        if (transform.localPosition.x > limits.x) speed = -speed;
        if (transform.localPosition.y > limits.y) speed = -speed;   
        if (-transform.localPosition.x < limits.x) speed = speed;
        if (-transform.localPosition.y < limits.y) speed = speed;

    }
}
