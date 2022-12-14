using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject SubCam;
    
    public int CamMode;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("CamKey"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(CamChange());
        }
    }

    IEnumerator CamChange() 
    {
        yield return new WaitForSeconds (0.01f);
        if (CamMode == 0)
        {
            MainCam.SetActive(true);
            SubCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            MainCam.SetActive(false);
            SubCam.SetActive(true);
        }
    }
}
