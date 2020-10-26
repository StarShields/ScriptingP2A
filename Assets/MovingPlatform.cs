using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // public Transform pos1, pos2;
    public float speed = 2.5f;
    float startY;
    public float distance = 5;
    float addY;
    // Start is called before the first frame update
    void Start()
    {

        startY = transform.position.y;
        //  nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        addY = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(transform.position.x, startY + addY, transform.position.z);

    }
}
