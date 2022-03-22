using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAsterPanel : MonoBehaviour{
  public GameObject AsterPanel;
  public void OpenPanelAster(){
    if (AsterPanel != null){ //Only open it panel exists
      AsterPanel.SetActive(true); //Open
    }
  }
}
