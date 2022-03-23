using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyNaturalPesticide : MonoBehaviour{
  public GameObject game_object_7; //GameObject
  public Text natural_pesticide_text;
  public void UpdateDisplayPesticide(){ //This will update the money
    game_object_7.GetComponent<MoneyScript>().Sub_Money(12); //Subtract the money by 12
    natural_pesticide_text.text = game_object_7.GetComponent<MoneyScript>().player_money.ToString();
}
}
