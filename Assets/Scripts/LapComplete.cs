using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LapComplete : MonoBehaviour
{
    public GameObject RestaurantTrig;
    public GameObject StorageTrig;
    public GameObject EndMessageWin;
    public GameObject EndMessageLoss;
    private Renderer rend;
    
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    void OnTriggerEnter()
    {
        StorageTrig.SetActive(true);
        StoragePointTrigger.storageTrigBool = true;
        rend.enabled = false;

        if (LapTimeManager.WasTimeValueZero)
            EndMessageLoss.SetActive(true);
        else
            EndMessageWin.SetActive(true);


        StartCoroutine(Timer());

    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
