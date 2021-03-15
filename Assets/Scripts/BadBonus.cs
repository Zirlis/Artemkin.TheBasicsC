using UnityEngine;
using static Bonuses.GameBonuses;

namespace Bonuses
{
    public class BadBonus : MonoBehaviour, IMirrorController, ICameraZoom
    {
        [SerializeField] private Ball _ball;
        [SerializeField] private CameraControl _cameraControl;
        private float _oldBallSpeed;
        private Vector3 _oldOffset;
        [SerializeField] private float _tTLBonus = 5f;
        [SerializeField] private bool _isTrigged = false;
        private float _time = 0f;

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player") && !_isTrigged)
            {
                Destroy(gameObject.GetComponent<MeshRenderer>());
                MirrorController();
                CameraZoom();
                _isTrigged = true;
            }
        }
        

        private void Start()
        {
            _oldBallSpeed = _ball.Speed;
            _oldOffset = _cameraControl.Offset;
        }

        private void Update()
        {
            if(_isTrigged)
            {                
                _time += Time.deltaTime;                
                if(_time >= _tTLBonus)
                {
                    MirrorController(true);
                    CameraZoom(true);
                    Destroy(gameObject);
                }
            }
        }
        public void MirrorController(bool endBonus = false)
        {
            if (!endBonus)
            {
                _ball.Speed *= -1;
            }
            else if (endBonus)
            {
                _ball.Speed = _oldBallSpeed;
            }
        }

        //public void Rotation()
        //{
        //    throw new System.NotImplementedException();
        //}

        public void CameraZoom(bool endBonus = false)
        {
            if (!endBonus)
            {
                _cameraControl.Offset -= new Vector3(0f, 5f, 0f);
            }
            else if (endBonus)
            {
                _cameraControl.Offset = _oldOffset;
            }
        }        

    }
}
