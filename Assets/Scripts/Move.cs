using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -2, 0), _speed * Time.deltaTime);
    }
}