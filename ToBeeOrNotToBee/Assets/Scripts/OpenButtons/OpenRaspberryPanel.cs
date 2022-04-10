using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRaspberryPanel : MonoBehaviour{
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;

  public bool IsOpen = false;
  public void OpenPanelRaspberry(){
    if (RaspberryPanel != null){ //Only open it panel exists
      RaspberryPanel.SetActive(true); //Open
      IsOpen = true;
    }


    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      BlueberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false;
    }
  }
}
