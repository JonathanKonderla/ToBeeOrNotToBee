using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingOpen : MonoBehaviour
{
  public GameObject ReferencesPanel;
  public GameObject AcknowledgementsPanel;
  public bool isOpen = false;

  public void OpenPanels(){
    if (AcknowledgementsPanel != null){
      AcknowledgementsPanel.SetActive(true);
    }

    if (isOpen == true){
      ReferencesPanel.SetActive(false);
      isOpen = false;
    }

  }
}
