using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLenght = endPos.x - this.startPos.x;

            this.speed = swipeLenght / 500.0f;
            Debug.Log(swipeLenght);
        }
        //move car
        transform.Translate(this.speed, 0, 0);
        //slow down
        this.speed *= 0.98f;
    }
}
