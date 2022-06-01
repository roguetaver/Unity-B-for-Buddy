using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchScript : Interactable
{   

    [SerializeField] private bool lightState;
    [SerializeField] private GameObject[] allLights;
    public bool interacted;

    private void Start(){
        lightState = false;
        interacted = false;
    }

    public override void OnFocus(){
        
    }

    public override void OnInteract(){
        interacted = true;
        lightState = !lightState;

        if(lightState){
            turnOn();
        }
        else{
            turnOff();
        }
        
    }

    public override void OnLoseFocus(){

    }

    private void turnOn(){
        foreach(GameObject obj in allLights){
            obj.SetActive(true);
        }
    }

    private void turnOff(){
        foreach(GameObject obj in allLights){
            obj.SetActive(false);
        }
    }
}
