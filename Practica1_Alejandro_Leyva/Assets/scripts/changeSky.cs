using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSky : MonoBehaviour
{
    public Material MySky;
    // Start is called before the first frame update
    private void OnEnable()
    {
        
        RenderSettings.skybox = MySky;
    }
    private void OnDisable()
    {
        RenderSettings.skybox = (null);
    }

}
