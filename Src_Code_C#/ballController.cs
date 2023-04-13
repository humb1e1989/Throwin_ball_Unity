using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ballController : MonoBehaviour
{
    public GameObject ball;
    public GameObject shootpoint;
    public SteamVR_Action_Boolean triggerAction;
    public SteamVR_Behaviour_Pose pose;
    void Update()
    {
        if (SteamVR_Input.GetAction<SteamVR_Action_Boolean>("thowin").GetStateDown(SteamVR_Input_Sources.Any))
        {
            print("GetStateDown");
            GameObject balls = GameObject.Instantiate(ball); // intialize the ball
            balls.transform.position = shootpoint.transform.position;
            balls.transform.eulerAngles = shootpoint.transform.eulerAngles;
            print("Instantiate Ball");
        }

        //if (triggerAction.GetStateUp(SteamVR_Input_Sources.Any))
        //{
        //    print("triggerAction Up1111");
        //}

        //if (SteamVR_Input.GetAction<SteamVR_Action_Boolean>("thowin").GetStateDown(SteamVR_Input_Sources.Any))
        //{
        //    print("GetStateDown");

        //}if (SteamVR_Input.GetAction<SteamVR_Action_Boolean>("thowin").GetState(SteamVR_Input_Sources.Any))
        //{
        //    print("GetState");

        //}


    }



}
