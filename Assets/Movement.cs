using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Movement : MonoBehaviour
{
    private float speed = 1f;
    public Vector3 Direction1 = Vector3.forward;
    public Vector3 Direction2 = Vector3.left;
    public Vector3 Direction3 = Vector3.right;
   

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private Rigidbody _rigidbody;
    private int _directionIndex;

    

    private void Update()
    // object directionIndex;
    {

        if (Input.GetMouseButtonDown(0)) // клик левой мыши
        {
            if (_directionIndex == 0)
                _directionIndex = 1;
            else
                _directionIndex = 0;
                    }
        if (Input.GetMouseButtonDown(1)) // клик правой мыши
        {
            if (_directionIndex == 0)
                _directionIndex = 2;
            else
                _directionIndex = 0;
        }
        
    }

    private Vector3 GetDirection()
    {
        if (_directionIndex ==1)
            return Direction2;
        else if (_directionIndex == 2)
            return Direction3;
        return Direction1;

        //  if (_directionIndex == 0)
        //      return Direction1;
        // return Direction3;
    }
    private void FixedUpdate()
    {
        Vector3 velocity = GetDirection() * speed;
        velocity.y = _rigidbody.velocity.y; // не меняем Y чтобы гравитация работала
        _rigidbody.velocity = velocity;
    }

    private void OnDisable()
    {
        // остановка при отключении компонента
        Vector3 velocity = Vector3.zero;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }
    public int coins = 0;
    public Text text1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coins = coins + 1;
            Debug.Log(coins);
            text1 = GameObject.FindObjectOfType<Text>();
            
            text1.text = $"Coins {coins}";
        
        }
      
        
     
        {

        }
    }
}


