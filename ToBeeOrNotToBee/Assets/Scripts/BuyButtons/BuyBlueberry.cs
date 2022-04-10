using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBlueberry : MonoBehaviour{
  public MoneyScript display_blueberry; //GameObject
  public Text blueberry_text; //Text to Display
  public GameObject InsufficientFundsPanel;
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;

  public void UpdateDisplayBlueberry(){ //This will update the money
    display_blueberry.Sub_Money(4); //Subtract the money by 5
    if (display_blueberry.player_money < 4){ //Not enough money to purchase blueberry seeds
      InsufficientFundsPanel.SetActive(true); //Show InsufficientFundsPanel
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
