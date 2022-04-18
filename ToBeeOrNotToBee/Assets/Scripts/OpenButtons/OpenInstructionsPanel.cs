using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInstructionsPanel : MonoBehaviour{
  public GameObject InstructionsPanel;

  public void InstructionsPanelOpen(){
    if (InstructionsPanel != null){
      InstructionsPanel.SetActive(true);
    }
  }
}
