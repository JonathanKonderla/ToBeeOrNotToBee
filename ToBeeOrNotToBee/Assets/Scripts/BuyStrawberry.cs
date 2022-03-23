using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyStrawberry : MonoBehaviour{
  public GameObject game_object_1; //GameObject
  public Text strawberry_text;
  public void UpdateDisplayStrawberry(){ //This will update the money
    game_object_1.GetComponent<MoneyScript>().Sub_Money(7); //Subtract the money by 7
    strawberry_text.text = game_object_1.GetComponent<MoneyScript>().player_money.ToString();
  }
}
