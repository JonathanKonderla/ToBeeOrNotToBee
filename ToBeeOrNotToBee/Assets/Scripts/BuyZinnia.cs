using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyZinnia : MonoBehaviour{
  public GameObject game_object_4; //GameObject
  public Text zinnia_text;
  public void UpdateDisplayZinnia(){ //This will update the money
    zinnia_text.text = game_object_4.GetComponent<MoneyScript>().player_money.ToString();
  }
}
