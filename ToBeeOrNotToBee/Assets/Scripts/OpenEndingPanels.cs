using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEndingPanels : MonoBehaviour{
  public GameObject ReferencesPanel;
  public GameObject AcknowledgementsPanel;
  public bool isOpen = false;

  public void OpenPanels(){
    if (ReferencesPanel != null){
      ReferencesPanel.SetActive(true);
      isOpen = true;
    }
    if (isOpen == true){
      AcknowledgementsPanel.SetActive(false);
      isOpen = false;
    }

  }

}
