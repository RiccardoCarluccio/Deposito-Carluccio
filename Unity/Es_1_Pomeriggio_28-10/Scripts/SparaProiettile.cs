using UnityEngine;

public class SparaProiettile : MonoBehaviour
{
    [SerializeField] private GameObject _prefabToSpawn;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _shootForce = 15;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_prefabToSpawn, null, true);
            bullet.transform.position = _spawnPoint.position;
            bullet.SetActive(true);

            var rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(_spawnPoint.forward * _shootForce, ForceMode.Impulse);
        }
    }
}
