using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StoragePointTrigger : MonoBehaviour
{
    internal static bool storageTrigBool = true;

    public GameObject RestaurantTrig;
    public GameObject StorageTrig;

    void OnTriggerEnter()
    {
       

        StorageTrig.SetActive(false);
        storageTrigBool = false;
        RestaurantTrig.SetActive(true);

       


    }

    

}
