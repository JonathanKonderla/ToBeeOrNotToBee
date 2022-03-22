using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNaturalPesticidePanel : MonoBehaviour{
  public GameObject NaturalPesticidePanel;
  public void OpenPanelNaturalPesticide(){
    if (NaturalPesticidePanel != null){ //Only open it panel exists
      NaturalPesticidePanel.SetActive(true); //Open
    }
  }
}
