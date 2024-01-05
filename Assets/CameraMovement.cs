using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform player1pos;
    public Transform player2pos;
    public float cameraMoveSpeed = 5f;
    public float minDistance = 2f;
    public float maxDistance = 10f;

    void Start()
    {

    }

    void Update()
    {
        if (player1pos == null)
        {
            player1pos = GameObject.FindGameObjectWithTag("Azri").transform;
        }

        if (player2pos == null)
        {
            player2pos = GameObject.FindGameObjectWithTag("Thor").transform;
        }

        // Calculate distance between players
        float distanceBetweenPlayers = Vector3.Distance(player1pos.position, player2pos.position);
        Debug.Log(distanceBetweenPlayers);

        // Adjust camera position based on distance
        float targetZPosition = Mathf.Clamp(distanceBetweenPlayers, minDistance, maxDistance);
        float newZPosition = Mathf.Lerp(transform.position.z, targetZPosition, Time.deltaTime * cameraMoveSpeed);

        // Update camera position
        transform.position = new Vector3(transform.position.x, transform.position.y, newZPosition);
    }
}
