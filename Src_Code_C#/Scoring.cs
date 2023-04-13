using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;


public class Scoring : MonoBehaviour
{
    public TextMesh UI;
    public int scoring;
    public int missing = -1;
    public AudioSource au;
    private void Start()
    {
        //UI.text = "Scoring: " + scoring + " " + "Missing: " + missing;
        transform.localPosition = new Vector3(0, Random.Range(-0.45f, 0.45f), Random.Range(-0.45f, 0.45f));
        au = GetComponent<AudioSource>();// get the type of the script
        hit();
    }
    private void Update()
    {
        //UI.text = "Scoring: " + scoring + " " + "Missing: " + missing;
        if (SteamVR_Input.GetAction<SteamVR_Action_Boolean>("thowin").GetStateDown(SteamVR_Input_Sources.Any)) {
            missing++;
            hit();
        }
        if (SteamVR_Input.GetAction<SteamVR_Action_Boolean>("zeroin").GetStateDown(SteamVR_Input_Sources.Any))
        {
            scoring = 0;
            missing = 0;
            hit();
        }
    }
    private void OnCollisionEnter(Collision gameObject)
    {
        scoring++;
        missing--;
        hit();
        transform.localPosition = new Vector3(0, Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
        GameObject.Destroy(gameObject.gameObject, 3);
        au.Play();
    }
    public void hit()
    {
        UI.text = "Scoring: " + scoring + " " + "Missing: " + missing;
    }
    
}
