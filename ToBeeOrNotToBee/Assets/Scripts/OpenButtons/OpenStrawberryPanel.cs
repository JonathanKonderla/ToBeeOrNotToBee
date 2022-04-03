using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStrawberryPanel : MonoBehaviour{
  public GameObject StrawberryPanel;
  public GameObject BlueberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;
  public bool IsOpen = false;


  public void OpenPanelStrawberry(){
    if (StrawberryPanel != null){ //Only open it panel exists
      StrawberryPanel.SetActive(true); //Open
      IsOpen = true; //Open StrawberryPanel
    }


    if (IsOpen == true){ //Already opened bluebrry panel
      BlueberryPanel.SetActive(false); //Don't overlap
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false; //Reset
      }
  }

}
