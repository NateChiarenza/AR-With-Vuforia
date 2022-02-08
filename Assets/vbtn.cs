using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vbtn : MonoBehaviour
{
    // Start is called before the first frame update
    public VirtualButtonBehaviour vb;
    public Animator pikachu;
    void Start()
    {
        vb.RegisterOnButtonPressed(pressed);
        vb.RegisterOnButtonReleased(released);
        pikachu.SetBool("Clapp", false);
    }

    // Update is called once per frame
    public void pressed(VirtualButtonBehaviour v)
    {
        pikachu.SetBool("Clapp", true);
    }
    public void released(VirtualButtonBehaviour v)
    {
        
        pikachu.SetBool("Clapp", false);
    }
}
