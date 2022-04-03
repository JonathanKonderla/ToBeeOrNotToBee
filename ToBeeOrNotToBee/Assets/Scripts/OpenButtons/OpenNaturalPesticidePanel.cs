using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNaturalPesticidePanel : MonoBehaviour{
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;

  public bool IsOpen = false; //Check whether the panel is open
  public void OpenPanelNaturalPesticide(){
    if (NaturalPesticidePanel != null){ //Only open it panel exists
      NaturalPesticidePanel.SetActive(true); //Open
      IsOpen = true;
    }

    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      IsOpen = false;
    }
  }
}
