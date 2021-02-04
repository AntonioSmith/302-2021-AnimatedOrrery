using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetPicker : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    public GameObject Solos;
    public GameObject Terros;
    public GameObject Lymphos;
    public GameObject Tempos;
    public GameObject Glados;
    public GameObject Luminos;
    public GameObject Phyros;

    private void Update()
    {
        cam.transform.LookAt(target);
    }

    public void FollowSolos()
    {
        target = Solos.transform;
    }
    public void FollowTerros()
    {
        target = Terros.transform;
    }
    public void FollowPhyros()
    {
        target = Phyros.transform;
    }
    public void FollowLymphos()
    {
        target = Lymphos.transform;
    }
    public void FollowTempos()
    {
        target = Tempos.transform;
    }
    public void FollowGlados()
    {
        target = Glados.transform;
    }
    public void FollowLuminos()
    {
        target = Luminos.transform;
    }
    public void FollowNone()
    {
        target = null;
    }
}
