using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePesticidePanel : MonoBehaviour{
    public GameObject InsufficientFundsPanel;

    public void ClosePanel(){
      if (InsufficientFundsPanel != null){
        InsufficientFundsPanel.SetActive(false);
      }
    }
}
