using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClose : MonoBehaviour{
    public GameObject panel_to_close;

    public void ClosePanel(){
      if (panel_to_close != null){
        panel_to_close.SetActive(false);
      }
    }
}
