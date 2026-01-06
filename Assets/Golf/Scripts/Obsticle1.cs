using UnityEngine;

public class Obsticle1 : MonoBehaviour
{
    public int speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,speed,0) * Time.deltaTime);
    }
}
