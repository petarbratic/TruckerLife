using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public GameObject BackLookCam;

    private int CamMode;

    void Update()
    {

        if (Input.GetButtonDown("ChangeCamera"))
        {
            if (CamMode == 3)
                CamMode = 0;
            else
            {
                CamMode++;
                
            }

            StartCoroutine(ModeChange());





        }

    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0)
        {
            NormalCam.SetActive(true);
            BackLookCam.SetActive(false);
        }
        if(CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if(CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
        if(CamMode == 3)
        {
            BackLookCam.SetActive(true);
            FPCam.SetActive(false);
        }

    }

}
