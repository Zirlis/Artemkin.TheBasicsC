using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBall : MonoBehaviour
{
    [SerializeField] private GameObject _puzzleWall;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(_puzzleWall);
            Destroy(gameObject);
        }
    }
}
