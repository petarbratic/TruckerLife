using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoragePointTrigger : MonoBehaviour
{
    public GameObject RestaurantTrig;
    public GameObject StorageTrig;

    void OnTriggerEnter()
    {
        StorageTrig.SetActive(false);
        RestaurantTrig.SetActive(true);
    }

}
