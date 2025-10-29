using UnityEngine;

public class EndPath_Behaviour : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if (player != null)
        {
            print("Hai raggiunto la fine!");
            player.transform.position = _spawnPoint.position;
        }
    }
}
