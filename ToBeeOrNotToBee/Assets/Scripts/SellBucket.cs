using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBucket : MonoBehaviour{
    public MoneyScript harvest_money; //Money that will be added
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            Plant sellPlant = other.gameObject.transform.parent.gameObject.GetComponent<Plant>();
            float sellPrice = sellPlant.GetValue();
            sellPlant.SellPlant();
            harvest_money.Add_Money(sellPrice);
        }
    }
}
