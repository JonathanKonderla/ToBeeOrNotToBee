using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSunflowerPanel : MonoBehaviour{
  public GameObject SunflowerPanel;
  public void OpenPanelSunflower(){
    if (SunflowerPanel != null){ //Only open it panel exists
      SunflowerPanel.SetActive(true); //Open
    }
  }
}
