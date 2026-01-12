
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Assign the destination Transform in the Inspector
    public Transform destinationPoint; 

    // This function is called when a Collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Optional: Check if the entering object has a specific tag (e.g., "Player")
        if (other.CompareTag("Ball")) 
        {
            // Teleport the object to the destination point
            other.transform.position = destinationPoint.position;
        }
    }
}


