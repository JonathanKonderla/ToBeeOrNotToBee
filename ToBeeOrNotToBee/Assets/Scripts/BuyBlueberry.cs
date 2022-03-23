using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBlueberry : MonoBehaviour{
  public GameObject game_object; //GameObject
  public Text blueberry_text;

  public void UpdateDisplayBlueberry(){ //This will update the money
    game_object.GetComponent<MoneyScript>().Sub_Money(5); //Subtract the money by 5
    blueberry_text.text = game_object.GetComponent<MoneyScript>().player_money.ToString();
  }
}
