using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{


    #region movementVars
    public float hBound;
    public float vBound;
    public float radius;
    public float speed;
    private Vector2 startingPos;
    private float elapsedTime;
    private bool movingLeft;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();

        transform.position = new Vector2(hBound, vBound);


        if (rand.NextDouble() >= 0.5)
        {
            transform.position = new Vector2(hBound, Random.Range(-vBound, vBound));
            movingLeft = true;
        }
        else
        {
            transform.position = new Vector2(-hBound, Random.Range(-vBound, vBound));
            movingLeft = false;
        }
        startingPos = transform.position;
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingLeft)
        {
            transform.position = startingPos + new Vector2(-elapsedTime * speed, radius * Mathf.Sin(elapsedTime));
        }
        else
        {
            transform.position = startingPos + new Vector2(elapsedTime * speed, radius * Mathf.Sin(elapsedTime));
        }
        elapsedTime += Time.deltaTime;
    }
}
