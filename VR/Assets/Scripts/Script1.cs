using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public int val = 0;
    public Text Mytxt;
    public GameObject click;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUptade()
    {
        val++;
        Mytxt.text = val.ToString();
    }
    public void ClickButton()
    {
       click.SetActive(!(click.activeSelf));
    }
}