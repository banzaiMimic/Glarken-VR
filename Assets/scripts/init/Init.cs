using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

/*
  detects if VR headset is present
  - @TODO either load camera for keyboard / mouse or send to keyboardScene ?
  - probably just want to programatically remove the XRRig and add some Camera to this scene (cleaner)
*/
public class Init : MonoBehaviour {
  
  public void Start() {
    Debug.Log("init start...");
    List<XRDisplaySubsystem> displaySubsystems = new List<XRDisplaySubsystem>();

    SubsystemManager.GetInstances<XRDisplaySubsystem>(displaySubsystems);
    if (displaySubsystems.Count > 0) {
      Debug.Log("VR system found...");
    }

  }

}