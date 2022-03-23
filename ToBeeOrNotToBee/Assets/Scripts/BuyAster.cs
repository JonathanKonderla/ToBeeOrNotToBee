using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAster : MonoBehaviour{
  public GameObject game_object_5; //GameObject
  public Text aster_text;
  public void UpdateDisplayAster(){ //This will update the money
    game_object_5.GetComponent<MoneyScript>().Sub_Money(2); //Subtract the money by 2
    aster_text.text = game_object_5.GetComponent<MoneyScript>().player_money.ToString();
  }
}
