using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySunflower : MonoBehaviour{
  public MoneyScript display_sunflower; //GameObject
  public Text sunflower_text;

  public void UpdateDisplaySunflower(){ //This will update the money
    display_sunflower.Sub_Money(2); //Subtract the money by 2
  }
}
