using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _ball.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = _ball.transform.position + _offset;
    }
}
