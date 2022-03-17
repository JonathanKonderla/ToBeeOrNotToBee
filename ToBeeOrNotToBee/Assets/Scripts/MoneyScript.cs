using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Referenced: https://www.youtube.com/watch?v=XJlPF4GtydU
public class MoneyScript : MonoBehaviour {
    public int player_money; //Amount of money that the player has
    // Start is called before the first frame update
    void Start(){
      //Amount of money the player starts with
      player_money = 50; //Can change this later
    }

    // Update is called once per frame
    void Update(){

    }

    public void Add_Money(int money_to_add){ //Call this later
      player_money = player_money + money_to_add; //Add the money
    }

    public void Sub_Money(int money_to_sub){ //Call this later
      if (player_money - money_to_sub >= 0){ //No negative money allowed
        player_money = player_money - money_to_sub; //Subtract the money
      }

    }
}
