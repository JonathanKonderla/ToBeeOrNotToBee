using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyRaspberry : MonoBehaviour{
  public MoneyScript display_raspberry; //GameObject
  public Text raspberry_text;

  public void UpdateDisplayRaspberry(){ //This will update the money
    display_raspberry.Sub_Money(4); //Subtract the money by 7
  }
}
