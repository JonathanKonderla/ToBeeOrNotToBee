using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyRaspberry : MonoBehaviour{
  public GameObject game_object_2; //GameObject
  public Text raspberry_text;
  public void UpdateDisplayRaspberry(){ //This will update the money
    game_object_2.GetComponent<MoneyScript>().Sub_Money(7); //Subtract the money by 7
    raspberry_text.text = game_object_2.GetComponent<MoneyScript>().player_money.ToString();
  }
}
