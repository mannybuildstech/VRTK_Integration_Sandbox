using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class ControllerEventHandler : MonoBehaviour {

    public VRTK_ControllerEvents controllerEvents;

	// Use this for initialization
	void Start () {
		
        if(controllerEvents!=null)
        {
            controllerEvents.TriggerClicked += ControllerEvents_TriggerClicked;

            controllerEvents.TriggerPressed += ControllerEvents_TriggerPressed;
            controllerEvents.TriggerReleased += ControllerEvents_TriggerReleased;

            controllerEvents.TriggerTouchStart += ControllerEvents_TriggerTouchStart;
            controllerEvents.TriggerTouchEnd += ControllerEvents_TriggerTouchEnd;
        }
        
	}

    private void ControllerEvents_TriggerTouchEnd(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("ControllerEvents_TriggerTouchEnd, buttonPressure: " + e.buttonPressure);
    }

    private void ControllerEvents_TriggerTouchStart(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("ControllerEvents_TriggerTouchStart Button pressure: " + e.buttonPressure);
    }

    private void ControllerEvents_TriggerReleased(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("ControllerEvents_TriggerReleased Button pressure: " + e.buttonPressure);
    }

    private void ControllerEvents_TriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("ControllerEvents_TriggerPressed Button pressure: " + e.buttonPressure);
    }

    private void ControllerEvents_TriggerClicked(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("ControllerEvents_TriggerClicked Button pressure: " + e.buttonPressure);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
