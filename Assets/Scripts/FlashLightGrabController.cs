using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashLightGrabController : XRGrabInteractable
{
    [SerializeField] GameObject spotLight;
    [SerializeField] MeshRenderer flashLightScreen;

    [SerializeField] Material flashlight, defaultFlashLight;

    bool isOn = false;

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);

        if(isOn)
        {
            spotLight.SetActive(false);
            flashLightScreen.material = defaultFlashLight;
            isOn = false;
        }
        else
        {
            spotLight.SetActive(true);
            flashLightScreen.material = flashlight;
            isOn = true;
        }
    }
}
