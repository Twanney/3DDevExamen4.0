using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    GameObject _computerSettings;

    [SerializeField]
    GameObject _VRSettings;

    void Awake()
    {
        if (isPresent())
        {
            _computerSettings.SetActive(false);
            _VRSettings.SetActive(true);
        }
        else
        {
            _VRSettings.SetActive(false);
            _computerSettings.SetActive(true);
        }
    }

    public static bool isPresent()
    {
        var xrDisplaySubsystems = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances<XRDisplaySubsystem>(xrDisplaySubsystems);
        foreach (var xrDisplay in xrDisplaySubsystems)
        {
            if (xrDisplay.running)
            {
                return true;
            }
        }
        return false;
    }
}
