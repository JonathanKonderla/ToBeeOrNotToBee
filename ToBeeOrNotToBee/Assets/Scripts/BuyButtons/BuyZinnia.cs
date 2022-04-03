using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyZinnia : MonoBehaviour{
  public MoneyScript display_zinnia; //GameObject
  public Text zinnia_text;
  public void UpdateDisplayZinnia(){ //This will update the money
    display_zinnia.Sub_Money(2);
  }
}
