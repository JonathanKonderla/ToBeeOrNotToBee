using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=LziIlLB2Kt4
public class OpenBlueberryPanel : MonoBehaviour{

    public GameObject BlueberryPanel;
    public void OpenBlueberryPanel(){
      if (BlueberryPanel != null){ //Only open it panel exists
        Panel.SetActive(true); //Open
      }
    }

}
