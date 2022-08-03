using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2 : MonoBehaviour
{
    string heroName = "Ammar";
    string heroSuperPower = "fire";
    float heroHeight = 173.5f;
    int heroAge = 35;

    string villainName = "Sayed";
    string villainSuperPower = "lightning";
    float villainHeight = 167.3f;
    int villainAge = 31;

    

    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = heroAge - villainAge;

        print("The hero's name is " + heroName);
        print("His height is " + heroHeight + ". His age is " + heroAge + " and his super power is " + heroSuperPower);

        print("The villain's name is " + villainName);
        print("His height is " + villainHeight + ". His age is " + villainAge + " and his super power is " + villainSuperPower);
        
        print("The age difference between the hero and the villain is " + ageDifference);

        heroHeight = heroHeight + 5f;
        villainSuperPower = "None";

        print("The hero's name is " + heroName);
        print("His height is " + heroHeight + ". His age is " + heroAge + " and his super power is " + heroSuperPower);

        print("The villain's name is " + villainName);
        print("His height is " + villainHeight + ". His age is " + villainAge + " and his super power is " + villainSuperPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
