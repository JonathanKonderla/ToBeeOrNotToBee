using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenZinniaPanel : MonoBehaviour{
  public GameObject ZinniaPanel;
  public void OpenPanelZinnia(){
    if (ZinniaPanel != null){ //Only open it panel exists
      ZinniaPanel.SetActive(true); //Open
    }
  }
}
