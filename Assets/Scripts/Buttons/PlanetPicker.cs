using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetPicker : MonoBehaviour
{
    public Camera cam;
    public Transform target;

    public void FollowSolos()
    {
        print("Solos pressed");
        GetComponent<StateMachine>().followingSolos = true;
        GetComponent<LookAt>().target = target;
    }
}
