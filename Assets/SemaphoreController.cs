using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SemaphoreController : MonoBehaviour {
    public GameObject leftFlag;
    public GameObject rightFlag;
    public TextMeshPro text;

    int hitCount = 0;
    int missCount = 0;

    public int lookahead = 4;
    public double speed = 0.5;
    public double length = 1;

    public List<Target> targets = new List<Target>();


    //RAINY Permit reorient

    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < lookahead; i++) {
            targets.Add(makeTarget());
        }
    }

    // Update is called once per frame
    void Update() {
        // Move display
        // On segment:
        //// Score
        //// Update display

        bool update = false; //DUMMY

        if (update) {
            bool hit = false; //DUMMY
            if (hit) {
                hitCount++;
            } else {
                missCount++;
            }
            text.text = "Hit: " + hitCount + "\nMiss: " + missCount;

            targets.RemoveAt(0);
            targets.Add(makeTarget());
        }
    }

    Target makeTarget() {
        //DUMMY Deal with numbers etc
        string str = "A"; //DUMMY

        return new Target(str);
    }
}
