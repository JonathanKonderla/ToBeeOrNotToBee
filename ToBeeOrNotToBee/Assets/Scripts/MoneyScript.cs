using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Referenced: https://www.youtube.com/watch?v=XJlPF4GtydU
public class MoneyScript : MonoBehaviour {
    public int player_money; //Amount of money that the player has
    public Text money_text; //Text to display

    // Start is called before the first frame update
    void Start(){
      player_money = 100; //Amount of money the player starts with = $100
      money_text.text = "Money Remaining: $" + player_money.ToString();//Initial display of money Money: $100
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
        money_text.text = "Money Remaining: $" + player_money.ToString();
      }

    }
}
