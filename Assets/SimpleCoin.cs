using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCoin : MonoBehaviour
{
 //   public int position;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
  
   // position = transform.position;
  //  private _position;
}
    void FixedUpdate()
    {
        
        transform.Rotate(0, 2f, 0);
     
        transform.position = new Vector3(transform.position.x,1+Mathf.Sin(Time.time)/4, transform.position.z);
    }

   
}
