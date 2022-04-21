using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySunflower : MonoBehaviour{
  public MoneyScript display_sunflower; //GameObject
  public GameObject InsufficientFundsPanel;
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;

  public void UpdateDisplaySunflower(){ //This will update the money
    display_sunflower.Sub_Money(5); //Subtract the money by 5
    if (display_sunflower.player_money < 5){
      InsufficientFundsPanel.SetActive(true);
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
