using UnityEngine;

public class Respawner_Es_2 : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMovement_Es_2>();

        if (player != null)
        {
            player.transform.position = _spawnPoint.position;

            if (GameManager_Es_2.Instance.IsTimeStarted())
            {
                GameManager_Es_2.Instance.EraseTimer();
            }
        }
    }
}
