using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheckPC : MonoBehaviour
{
    PlayerControllerPC playerControllerPC;

    void Awake()
    {
        playerControllerPC = GetComponentInParent<PlayerControllerPC>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerControllerPC.gameObject)
            return;

        playerControllerPC.SetGroundedState(true);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playerControllerPC.gameObject)
            return;

        playerControllerPC.SetGroundedState(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == playerControllerPC.gameObject)
            return;

        playerControllerPC.SetGroundedState(true);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerControllerPC.gameObject)
            return;

        playerControllerPC.SetGroundedState(true);
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == playerControllerPC.gameObject)
            return;

        playerControllerPC.SetGroundedState(false);
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == playerControllerPC.gameObject)
            return;

        playerControllerPC.SetGroundedState(true);
    }
}
