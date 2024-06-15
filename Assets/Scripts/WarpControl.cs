using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class WarpControl : MonoBehaviour
{
    public VisualEffect warpDrive;
    public float rateOfWarp = 0.02f;
    private bool warpState;
    
    void Start()
    {
        warpDrive.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            warpState = true;
            StartCoroutine(ActivateHyperDrive());
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            warpState = false;
            StartCoroutine(ActivateHyperDrive());
        }

    }

    IEnumerator ActivateHyperDrive()
    {
        if(warpState)
        {
            warpDrive.gameObject.SetActive(true);
            warpDrive.Play();

            float amt = warpDrive.GetFloat("WarpAmount");
            while(amt <= 1)
            {
                amt += rateOfWarp;
                warpDrive.SetFloat("WarpAmount", amt);
                yield return new WaitForSeconds(0.1f);
            }
        }
        else
        {
            warpDrive.Stop();
        }
    }
}
