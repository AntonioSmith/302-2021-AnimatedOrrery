using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetPicker : MonoBehaviour
{
    #region variables
    public Camera cam;
    public bool isFollowing = false;
    public Transform target;
    public GameObject Solos;
    public GameObject Terros;
    public GameObject Lymphos;
    public GameObject Tempos;
    public GameObject Glados;
    public GameObject Luminos;
    public GameObject Phyros;
    #endregion

    private void Update()
    {
        cam.transform.LookAt(target);
        if (isFollowing)
        {
            cam.transform.position = AnimMath.Slide(cam.transform.position, target.position, .01f);
        }
    }

    public void FollowSolos()
    {
        target = Solos.transform;
        isFollowing = true;
    }
    public void FollowTerros()
    {
        target = Terros.transform;
        isFollowing = true;
    }
    public void FollowPhyros()
    {
        target = Phyros.transform;
        isFollowing = true;
    }
    public void FollowLymphos()
    {
        target = Lymphos.transform;
        isFollowing = true;
    }
    public void FollowTempos()
    {
        target = Tempos.transform;
        isFollowing = true;
    }
    public void FollowGlados()
    {
        target = Glados.transform;
        isFollowing = true;
    }
    public void FollowLuminos()
    {
        target = Luminos.transform;
        isFollowing = true;
    }
    public void FollowNone()
    {
        target = Solos.transform;
        isFollowing = false;
    }
}
