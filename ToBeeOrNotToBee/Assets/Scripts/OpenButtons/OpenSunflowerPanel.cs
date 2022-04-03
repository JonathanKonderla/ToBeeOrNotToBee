using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSunflowerPanel : MonoBehaviour{
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;
  public bool IsOpen = false; //Not open originally

  public void OpenPanelSunflower(){
    if (SunflowerPanel != null){ //Only open it panel exists
      SunflowerPanel.SetActive(true); //Open
      IsOpen = true;
    }

  if (IsOpen == true){ //Already opened bluebrry panel
    StrawberryPanel.SetActive(false); //So, don't overlap it
    RaspberryPanel.SetActive(false);
    BlueberryPanel.SetActive(false);
    ZinniaPanel.SetActive(false);
    AsterPanel.SetActive(false);
    PesticidePanel.SetActive(false);
    NaturalPesticidePanel.SetActive(false);
    IsOpen = false; //Reset
  }
}
}
