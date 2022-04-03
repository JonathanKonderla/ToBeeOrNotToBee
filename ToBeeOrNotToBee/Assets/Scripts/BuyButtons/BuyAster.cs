using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAster : MonoBehaviour{
  public MoneyScript display_aster; //GameObject
  public Text aster_text;
  public void UpdateDisplayAster(){ //This will update the money
    display_aster.Sub_Money(2); //Subtract the money by 2
}
}
