using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    public Vector3 Offset;

    private void Awake()
    {
        Offset = transform.position - _ball.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = _ball.transform.position + Offset;
    }
}
