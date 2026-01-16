using UnityEngine;

public class Slider : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 1f;
    private float t = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;
        transform.position = Vector3.Lerp(pointA.position, pointB.position, t);
    }
}