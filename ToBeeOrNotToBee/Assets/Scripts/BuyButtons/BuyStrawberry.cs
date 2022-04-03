using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyStrawberry : MonoBehaviour{
  public MoneyScript display_strawberry; //GameObject
  public Text strawberry_text;
  public void UpdateDisplayStrawberry(){ //This will update the money
    display_strawberry.Sub_Money(7); //Subtract the money by 7
  }
}
