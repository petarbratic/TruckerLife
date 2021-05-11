using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LapComplete : MonoBehaviour
{

    public GameObject RestaurantTrig;
    public GameObject StorageTrig;
    public GameObject EndMessage;

    // public GameObject MinuteDisplay;
    ///public GameObject SecondDisplay;
    ///public GameObject MilliDisplay;

    //    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
       /* if(LapTimeManager.SecondCount <= 9)
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        else
            SecondDisplay.GetComponent<Text>().text = LapTimeManager.SecondCount + ".";

        if (LapTimeManager.MinuteCount <= 9)
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        else
            MinuteDisplay.GetComponent<Text>().text = LapTimeManager.MinuteCount + ".";

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
       */
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;


        StorageTrig.SetActive(true);
        StoragePointTrigger.storageTrigBool = true;
        //RestaurantTrig.SetActive(false);

        EndMessage.SetActive(true);
        StartCoroutine(Timer());


        
        
        //ButtonOptions a1 = new ButtonOptions();
        //a1.JobOffers();


    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }


}
