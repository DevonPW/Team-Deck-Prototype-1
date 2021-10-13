using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    [SerializeField] float moveSpeed = 1f;

    float deltaTime, prevTime;

    // Start is called before the first frame update
    void Start()
    {
        prevTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //move wall at constant speed
        deltaTime = Time.time - prevTime;

        transform.Translate(Vector3.back * moveSpeed * deltaTime);

        prevTime = Time.time;

        if (transform.position.z < -20) {
            Destroy(this.gameObject);
        }
    }
}
