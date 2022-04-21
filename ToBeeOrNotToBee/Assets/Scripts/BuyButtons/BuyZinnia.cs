using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyZinnia : MonoBehaviour{
  public MoneyScript display_zinnia; //GameObject
  public GameObject InsufficientFundsPanel;
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;

  public void UpdateDisplayZinnia(){ //This will update the money
    display_zinnia.Sub_Money(4);
    if (display_zinnia.player_money < 4){
      InsufficientFundsPanel.SetActive(true);
      AsterPanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      StrawberryPanel.SetActive(false);
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
    }
  }
}
