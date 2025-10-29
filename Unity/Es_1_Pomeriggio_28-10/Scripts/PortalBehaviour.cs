using UnityEngine;

public class PortalBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if (player != null)
            player.BoostSpeed();
    }
}
