using UnityEngine;
using static Bonuses.GameBonuses;

namespace Bonuses
{
    public class GoodBonus : MonoBehaviour, ICameraDistancing
    {
        [SerializeField] private CameraControl _cameraControl;
        private Vector3 _oldOffset;
        [SerializeField] private float _tTLBonus = 5f;
        [SerializeField] private bool _isTrigged = false;
        private float _time = 0f;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && !_isTrigged)
            {
                Destroy(gameObject.GetComponent<MeshRenderer>());
                CameraDistancing();
                _isTrigged = true;
            }
        }
        private void Start()
        {
            _oldOffset = _cameraControl.Offset;
        }

        private void Update()
        {
            if (_isTrigged)
            {
                _time += Time.deltaTime;
                if (_time >= _tTLBonus)
                {
                    CameraDistancing(true);                    
                    Destroy(gameObject);
                }
            }
        }
        public void CameraDistancing(bool endBonus = false)
        {
            if (!endBonus)
            {
                _cameraControl.Offset += new Vector3(0f, 5f, 0f);
            }
            else if (endBonus)
            {
                _cameraControl.Offset = _oldOffset;
            }
        }
    }
}
