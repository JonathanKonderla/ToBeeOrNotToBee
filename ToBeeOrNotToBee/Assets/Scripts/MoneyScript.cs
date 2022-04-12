using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Referenced: https://www.youtube.com/watch?v=XJlPF4GtydU
public class MoneyScript : MonoBehaviour {
    public float player_money; //Amount of money that the player has
    public Text money_text; //Text to display

    // Start is called before the first frame update
    void Start(){
      player_money = 30; //Amount of money the player starts with = $30
      money_text.text = "Money Remaining: $" + player_money.ToString();//Initial display of money Money: $100
    }

    public void Add_Money(float money_to_add){ //Call this later
      player_money = player_money + money_to_add; //Add the money
    }

    public void Sub_Money(int money_to_sub){ //Call this later
      if (player_money - money_to_sub >= 0){ //No negative money allowed
        player_money = player_money - money_to_sub; //Subtract the money
        money_text.text = "Money Remaining: $" + player_money.ToString();
      }

    }
}
