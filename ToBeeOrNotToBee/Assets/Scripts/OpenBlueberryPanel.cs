using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=LziIlLB2Kt4
public class OpenBlueberryPanel : MonoBehaviour{

    public GameObject BlueberryPanel;
    public void OpenPanel(){
      if (BlueberryPanel != null){ //Only open it panel exists
        BlueberryPanel.SetActive(true); //Open
      }
    }

}
