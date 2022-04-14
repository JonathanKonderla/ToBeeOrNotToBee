using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAllPanels : MonoBehaviour{

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

  public void OpenPanelStrawberry(){
    if (StrawberryPanel != null){ //Only open it panel exists
      StrawberryPanel.SetActive(true); //Open
      IsOpen = true; //Open StrawberryPanel
    }


    if (IsOpen == true){ //Already opened bluebrry panel
      BlueberryPanel.SetActive(false); //Don't overlap
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false; //Reset
      }
  }

  public void OpenPanelRaspberry(){
    if (RaspberryPanel != null){ //Only open it panel exists
      RaspberryPanel.SetActive(true); //Open
      IsOpen = true;
    }


    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      BlueberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false;
    }
  }

  public void OpenPanelSunflower(){
    if (SunflowerPanel != null){ //Only open it panel exists
      SunflowerPanel.SetActive(true); //Open
      IsOpen = true;
    }

    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      RaspberryPanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false; //Reset
  }
}

  public void OpenPanelZinnia(){
    if (ZinniaPanel != null){ //Only open it panel exists
      ZinniaPanel.SetActive(true); //Open
      IsOpen = true;
    }

    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false; //Reset
    }
  }

  public void OpenPanelAster(){
    if (AsterPanel != null){ //Only open it panel exists
      AsterPanel.SetActive(true); //Open
      IsOpen = true;
    }

    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false;
    }
  }

  public void OpenPanelPesticide(){
    if (PesticidePanel != null){ //Only open it panel exists
      PesticidePanel.SetActive(true); //Open
      IsOpen = true;
    }

    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      NaturalPesticidePanel.SetActive(false);
      IsOpen = false;
    }
  }

  public void OpenPanelNaturalPesticide(){
    if (NaturalPesticidePanel != null){ //Only open it panel exists
      NaturalPesticidePanel.SetActive(true); //Open
      IsOpen = true;
    }

    if (IsOpen == true){ //Already opened bluebrry panel
      StrawberryPanel.SetActive(false); //So, don't overlap it
      RaspberryPanel.SetActive(false);
      SunflowerPanel.SetActive(false);
      ZinniaPanel.SetActive(false);
      AsterPanel.SetActive(false);
      PesticidePanel.SetActive(false);
      BlueberryPanel.SetActive(false);
      IsOpen = false;
    }
  }

} //End class
