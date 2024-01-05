using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float cameraMoveSpeed = 5f;
    public float minDistance = 2f;
    public float maxDistance = 10f;

    void Start()
    {

    }

    void Update()
    {
        // Calculate distance between players
        float distanceBetweenPlayers = Vector3.Distance(player1.position, player2.position);

        // Adjust camera position based on distance
        float targetZPosition = Mathf.Clamp(distanceBetweenPlayers, minDistance, maxDistance);
        float newZPosition = Mathf.Lerp(transform.position.z, targetZPosition, Time.deltaTime * cameraMoveSpeed);

        // Update camera position
        transform.position = new Vector3(transform.position.x, transform.position.y, newZPosition);
    }
}
