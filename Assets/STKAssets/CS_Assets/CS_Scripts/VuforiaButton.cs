using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Events;

public class VuforiaButton : MonoBehaviour, IVirtualButtonEventHandler {

    public VirtualButtonBehaviour button;

    internal float buttonCooldown = 0.5f;

    public UnityEvent buttonActions;

    // Use this for initialization
    void Start()
    {
        button.RegisterEventHandler(this);


    }

    void Update()
    {
        if (buttonCooldown > 0) buttonCooldown -= Time.deltaTime;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (buttonCooldown > 0) return;
        //button.RegisterEventHandler(this);
        //Debug.Log("YAY");
        //throw new System.NotImplementedException();

        //GetComponent<CharacterSelector>().NextCharacter();

        buttonActions.Invoke();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //Debug.Log("NAY");
        //throw new System.NotImplementedException();
    }

	
}
