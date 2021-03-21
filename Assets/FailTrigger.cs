﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(message:"Fail");
            other.GetComponent<Movement>().enabled = false;
        }
    }
}

