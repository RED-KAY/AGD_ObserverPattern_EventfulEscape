using System;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchView : MonoBehaviour, IInteractable
{
    [SerializeField] private List<Light> lightsources = new List<Light>();
    private SwitchState currentState;

    private void Start() => currentState = SwitchState.Off;

    public delegate void LightSwitchViewDelegate();
    public LightSwitchViewDelegate _LightSwitch;

    void OnEnable()
    {
        _LightSwitch = OnLightSwitchToggle;
    }

    private void OnLightSwitchToggle()
    {
        toggleLights();
    }

    public void Interact()
    {
        //Todo - Implement Interaction

        _LightSwitch?.Invoke();
    }
    private void toggleLights()
    {
        bool lights = false;

        switch (currentState)
        {
            case SwitchState.On:
                currentState = SwitchState.Off;
                lights = false;
                break;
            case SwitchState.Off:
                currentState = SwitchState.On;
                lights = true;
                break;
            case SwitchState.Unresponsive:
                break;
        }
        foreach (Light lightSource in lightsources)
        {
            lightSource.enabled = lights;
        }
    }
}
