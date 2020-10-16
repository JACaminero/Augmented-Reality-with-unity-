using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Vuforia;

public class WaifuIsLifu : MonoBehaviour
{
    public GameObject vbChange, vbRotation, vbAnimate;
    public GameObject waifu, bake2, bake;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = waifu.GetComponent<Animator>();
        anim.enabled = false;

        vbChange.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnChangePressed);
        vbAnimate.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnAnimatePressed);
        vbAnimate.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnAnimateReleased);
        vbRotation.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnRotatePressed);
    }

    private void OnAnimateReleased(VirtualButtonBehaviour obj)
    {
        anim.enabled = false;
    }

    private void OnAnimatePressed(VirtualButtonBehaviour obj)
    {
        anim.enabled = true;    
    }

    private void OnRotatePressed(VirtualButtonBehaviour obj)
    {
        waifu.transform.Rotate(0, 300, 0);
    }

    private void OnChangePressed(VirtualButtonBehaviour obj)
    {
        var rnd = new System.Random();
        bake.GetComponent<MeshRenderer>().material.color = new Color(rnd.Next(1, 253), rnd.Next(1, 253), rnd.Next(1, 253));
        bake2.GetComponent<MeshRenderer>().material.color = new Color(rnd.Next(1, 253), rnd.Next(1, 253), rnd.Next(1, 253));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
