using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MineralDisplay : MonoBehaviour
{
    private int minerals = 0;
    public Text mineralText;

    void Update() {
        mineralText.text = "MINERALS: " + minerals;
        if (Input.GetKeyDown(KeyCode.Space)) {
            minerals++;
        }
    }
}
