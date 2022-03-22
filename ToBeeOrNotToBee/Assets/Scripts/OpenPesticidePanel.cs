using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPesticidePanel : MonoBehaviour{
  public GameObject PesticidePanel;
  public void OpenPanelPesticide(){
    if (PesticidePanel != null){ //Only open it panel exists
      PesticidePanel.SetActive(true); //Open
    }
  }
}
