using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyPesticide : MonoBehaviour{
  public MoneyScript display_pesticide; //GameObject
  public Text pesticide_text;

  public void UpdateDisplayPesticide(){ //This will update the money
    display_pesticide.Sub_Money(10); //Subtract the money by 10
}
}
