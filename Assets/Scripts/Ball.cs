using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rigidbody.AddForce(-movement * _speed);
    }
}
