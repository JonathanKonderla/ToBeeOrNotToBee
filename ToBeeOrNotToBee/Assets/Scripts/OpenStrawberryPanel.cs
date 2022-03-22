using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStrawberryPanel : MonoBehaviour{
  public GameObject StrawberryPanel;
  public void OpenPanelStrawberry(){
    if (StrawberryPanel != null){ //Only open it panel exists
      StrawberryPanel.SetActive(true); //Open
    }
  }

}
