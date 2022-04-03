using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBlueberry : MonoBehaviour{
  public MoneyScript display_blueberry; //GameObject
  public Text blueberry_text; //Text to Display

  public void UpdateDisplayBlueberry(){ //This will update the money
    display_blueberry.Sub_Money(5); //Subtract the money by 5
  }
}
