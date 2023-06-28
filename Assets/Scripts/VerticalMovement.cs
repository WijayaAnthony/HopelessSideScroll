using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    // Start is called before the first frame update

    static float t = 0.0f;
    public float distance, speed, timestart;
    private float originalPOSY;
    bool isRotate = false;
    void Start()
    {
        originalPOSY = transform.position.y;
    }

    float a;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, originalPOSY + Mathf.Sin(t) * distance, transform.position.z);
        t += speed * Time.deltaTime;
    }
}
