using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyNaturalPesticide : MonoBehaviour{
  public MoneyScript display_naturalpesticide; //GameObject
  public Text natural_pesticide_text;

  public void UpdateDisplayPesticide(){ //This will update the money
    display_naturalpesticide.Sub_Money(12); //Subtract the money by 12
}
}
