using UnityEngine;

public class Start_Timer_Es_2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMovement_Es_2>();
        if (player != null)
        {
            if (!GameManager_Es_2.Instance.IsTimeStarted())
            {
                GameManager_Es_2.Instance.StartTimer();
            }
        }
    }
}
