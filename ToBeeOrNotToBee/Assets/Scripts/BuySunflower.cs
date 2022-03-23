using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySunflower : MonoBehaviour{
  public GameObject game_object_3; //GameObject
  public Text sunflower_text;

  public void UpdateDisplaySunflower(){ //This will update the money
    game_object_3.GetComponent<MoneyScript>().Sub_Money(2); //Subtract the money by 2
    sunflower_text.text = game_object_3.GetComponent<MoneyScript>().player_money.ToString();
  }
}
