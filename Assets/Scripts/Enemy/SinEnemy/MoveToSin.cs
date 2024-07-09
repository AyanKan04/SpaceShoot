using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToSin : MonoBehaviour
{

    private float sinCenterY;
    public float amplitude = 2f;
    public float frequency = 2f;
    public float inFre;
    public bool inverted = false;

    // Start is called before the first frame update
    void Start()
    {        
        sinCenterY = transform.position.y; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float sin = Mathf.Sin(pos.x * frequency) * amplitude;
        if (inverted)
        {
            sin *= -1;
        }
        pos.y = sinCenterY + sin;

        transform.position = pos;
    }

    
}
