using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=LziIlLB2Kt4
public class OpenBlueberryPanel : MonoBehaviour{

    public GameObject BlueberryPanel;
    public GameObject StrawberryPanel;
    public GameObject RaspberryPanel;
    public GameObject SunflowerPanel;
    public GameObject ZinniaPanel;
    public GameObject AsterPanel;
    public GameObject PesticidePanel;
    public GameObject NaturalPesticidePanel;

    public bool IsOpen = false; //Check whether the panel is open
    public void OpenPanelBlueberry(){
      if (BlueberryPanel != null){ //Only open it panel exists
        BlueberryPanel.SetActive(true); //Open
        IsOpen = true; //Opened panel
      }

      if (IsOpen == true){ //Already opened bluebrry panel
        StrawberryPanel.SetActive(false); //So, don't overlap it
        RaspberryPanel.SetActive(false);
        SunflowerPanel.SetActive(false);
        ZinniaPanel.SetActive(false);
        AsterPanel.SetActive(false);
        PesticidePanel.SetActive(false);
        NaturalPesticidePanel.SetActive(false);
        IsOpen = false;
      }
    }

}
