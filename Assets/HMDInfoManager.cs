using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is device Active: " + XRSettings.isDeviceActive);
        Debug.Log("Device name: " + XRSettings.loadedDeviceName);

        if(!XRSettings.isDeviceActive)
        {
            Debug.Log("No Device connected!");
        }
        else if(!XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "MOCKHMD") && (XRSettings.loadedDeviceName == "MOCKHMD Display"))
        {
            Debug.Log("Using Mock HMD");
        }
        else
        {
            Debug.Log("Device name: " + XRSettings.loadedDeviceName);
        }
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
