using UnityEngine;

namespace Bonuses
{
    public class GameBonuses : MonoBehaviour
    {
        internal interface IMirrorController
        {
            void MirrorController(bool endBonus = false);
        }

        internal interface IRotation
        {
            void Rotation(bool endBonus = false);
        }

        internal interface ICameraZoom
        {
            void CameraZoom(bool endBonus = false);
        }

        internal interface ICameraDistancing
        {
            void CameraDistancing(bool endBonus = false);
        }

    }
}
