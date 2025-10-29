using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        
        if (player != null)
        {
            player.transform.position = _spawnPoint.position;
        }
    }
}
