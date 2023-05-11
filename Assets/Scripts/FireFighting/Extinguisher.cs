using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
//using OVRTouchSample;

public class Extinguisher : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem smoke;
    public Transform spawnPoint;
    //public float fireSpeed = 20.0f;
    private InputDevice targetDevice;
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        if(devices.Count > 0)
        {
            targetDevice = devices[0];
        }
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(useFireExtinguisher);
        //if(OVRInput.Get(OVRInput.Button.One))
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void useFireExtinguisher(ActivateEventArgs arg)
    {
        if(targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool value) && value == true )
        {
            ParticleSystem spawnedSmoke = Instantiate(smoke);
            spawnedSmoke.transform.position = spawnPoint.transform.position;
        }
        
        //spawnedSmoke.GetComponent<Rigidbody>().velocity = spawnPoint.forward; 
        //Destroy(spawnedSmoke, 5);

    }
}
