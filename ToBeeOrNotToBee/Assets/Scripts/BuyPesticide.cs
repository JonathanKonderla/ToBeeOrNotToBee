using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyPesticide : MonoBehaviour{
  public GameObject game_object_6; //GameObject
  public Text pesticide_text;
  public void UpdateDisplayPesticide(){ //This will update the money
    game_object_6.GetComponent<MoneyScript>().Sub_Money(10); //Subtract the money by 10
    pesticide_text.text = game_object_6.GetComponent<MoneyScript>().player_money.ToString();
}
}
