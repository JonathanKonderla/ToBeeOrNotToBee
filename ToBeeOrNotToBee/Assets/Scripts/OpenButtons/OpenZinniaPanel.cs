using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenZinniaPanel : MonoBehaviour{
  public GameObject BlueberryPanel;
  public GameObject StrawberryPanel;
  public GameObject RaspberryPanel;
  public GameObject SunflowerPanel;
  public GameObject ZinniaPanel;
  public GameObject AsterPanel;
  public GameObject PesticidePanel;
  public GameObject NaturalPesticidePanel;

  public bool IsOpen = false; //Not open, yet
  public void OpenPanelZinnia(){
    if (ZinniaPanel != null){ //Only open it panel exists
      ZinniaPanel.SetActive(true); //Open
      IsOpen = true;
    }

    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false; //Reset
    }
  }
}
