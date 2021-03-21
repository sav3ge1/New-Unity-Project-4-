using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowTarget;

    private void Awake()
    {
        Vector3 initialPosition = transform.position;
        _offset = initialPosition - FollowTarget.position;
        _fixedY = initialPosition.y;
    }
    private float _fixedY;
    private Vector3 _offset;

    private void LateUpdate()
    {
       // камера на расстонии от цели
        Vector3 newPosition = FollowTarget.position + _offset;
        transform.position = newPosition;
    }

    // Start is called before the first frame update
    void Start()
  {
        
    }

    // Update is called once per frame
  void Update()
   {
        
    }
}
