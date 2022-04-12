using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBucket : MonoBehaviour{
    public MoneyScript harvest_money; //Money that will be added
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
          //REESA MODIFY IT
            //Destroy(other.gameObject.transform.parent.gameObject);
            float sellPrice = other.gameObject.transform.parent.gameObject.GetComponent<Plant>().SellPlant();
            harvest_money.Add_Money(sellPrice);
        }
    }
}
