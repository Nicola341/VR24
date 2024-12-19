using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Script2 : MonoBehaviour
{
    public int val = 10;
    public Text Mytxt;

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
    }
    public void OnCollisionEnter(Collision collision)
    {
        val--;
        Mytxt.text = val.ToString();
    }
}
    