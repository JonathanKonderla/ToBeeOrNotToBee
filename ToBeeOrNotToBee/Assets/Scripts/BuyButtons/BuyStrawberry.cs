using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyStrawberry : MonoBehaviour{
  public MoneyScript display_strawberry; //GameObject
  public Text strawberry_text;
  public GameObject InsufficientFundsPanel;
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;

  public void UpdateDisplayStrawberry(){ //This will update the money
    display_strawberry.Sub_Money(4); //Subtract the money by 7
    if (display_strawberry.player_money < 4){
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
