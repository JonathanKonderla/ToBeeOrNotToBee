using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRaspberryPanel : MonoBehaviour{
  public GameObject RaspberryPanel;
  public void OpenPanelRaspberry(){
    if (RaspberryPanel != null){ //Only open it panel exists
      RaspberryPanel.SetActive(true); //Open
    }
  }
}
