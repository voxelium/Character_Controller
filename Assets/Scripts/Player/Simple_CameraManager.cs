using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_CameraManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothTime;
    private Vector3 currentVelocity = Vector3.zero;

    private Vector3 offset;

    private void Awake()
    {
        offset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        var playerPosition = player.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, playerPosition,
            ref currentVelocity, smoothTime);
    }

}
