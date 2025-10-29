using UnityEngine;

public class PlayerMovement_Es_2 : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _dir;

    [SerializeField] private float _speed = 5;
    [SerializeField] private float _rotateSpeed = 1;
    [SerializeField] private Renderer _renderer;

    public void BoostSpeed()
    {
        _speed *= 2;
    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        HandleInputMovement();
    }

    private void HandleInputMovement()
    {
        _dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            _dir += transform.forward;
        else if (Input.GetKey(KeyCode.S))
            _dir += -transform.forward;

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(new Vector3(0f, -_rotateSpeed, 0f));
        else if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0f, _rotateSpeed, 0f));
    }

    void FixedUpdate()
    {
        if (_dir != Vector3.zero)
            _rb.MovePosition(_rb.position + _speed * Time.deltaTime * _dir);
    }
}
