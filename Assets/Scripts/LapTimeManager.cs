using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    
    private float timeValue = 90;
    internal static bool WasTimeValueZero = false;
    public Text timeText;

    void Update()
    {
        if (!StoragePointTrigger.storageTrigBool)
        {
            if (timeValue > 0)
                timeValue -= Time.deltaTime;
            else
            {
                timeValue = 0;
                WasTimeValueZero = true;
            }
                

            DisplayTime(timeValue);
        }
        
    }

    private void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
            timeToDisplay = 0;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);


        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
