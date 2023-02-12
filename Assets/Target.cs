using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    /**
    facing forward: counterclockwise, starting at 12'o'clock

    If looking at the sender, it's backwards, and for my own reference in transcribing, it'd look like this:

        0
      7   1
    6       2
      5   3
        4
    */

    public static Dictionary<string, int[]> COORDS = new Dictionary<string, int[]>() {
        {" ", new int[]{4, 4}}, //CHECK Doubling up
        {"ABC", new int[]{0, 2}},
        {"A", new int[]{4, 5}},
        {"B", new int[]{4, 6}},
        {"C", new int[]{4, 7}},
        {"D", new int[]{4, 0}},
        {"E", new int[]{4, 1}},
        {"F", new int[]{4, 2}},
        {"G", new int[]{4, 3}},
        {"H", new int[]{5, 6}},
        {"I", new int[]{5, 7}},
        {"J", new int[]{0, 2}},
        {"K", new int[]{5, 0}},
        {"L", new int[]{5, 1}},
        {"M", new int[]{5, 2}},
        {"N", new int[]{5, 3}},
        {"O", new int[]{6, 7}},
        {"P", new int[]{6, 0}},
        {"Q", new int[]{6, 1}},
        {"R", new int[]{6, 2}},
        {"S", new int[]{6, 3}},
        {"T", new int[]{7, 0}},
        {"U", new int[]{7, 1}},
        {"V", new int[]{0, 3}},
        {"W", new int[]{1, 2}},
        {"X", new int[]{1, 3}},
        {"Y", new int[]{7, 2}},
        {"Z", new int[]{2, 3}},
        {"NUM", new int[]{0, 1}},
        {"0", new int[]{0, 5}},
        {"1", new int[]{4, 5}},
        {"2", new int[]{4, 6}},
        {"3", new int[]{4, 7}},
        {"4", new int[]{4, 0}},
        {"5", new int[]{4, 1}},
        {"6", new int[]{4, 2}},
        {"7", new int[]{4, 3}},
        {"8", new int[]{5, 6}},
        {"9", new int[]{5, 7}},
        {"ACK", new int[]{4, 7}},
        //{"ATTN", new int[]{0, 0}}, //DUMMY ?
        {"DEL", new int[]{3, 7}}
    };

    string s;
    int slotA;
    int slotB;

    public Target(string s) {
        this.s = s;
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
