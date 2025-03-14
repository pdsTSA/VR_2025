using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class theThuzzScript : MonoBehaviour {
    public TextMeshPro textDisplay; // Assign a TextMeshPro UI element
    public XRBaseInteractable laserButton; // Assign the interactable button

    private string[] miamiIntro =
    {
        "Welcome to Miami! Where the subarbian culture thrives under the sun.", 
        "Enter the house to begin your adventure of a lifetime-",
        "Learning about the sightings and history of the Magic City"

    };

    private int currentIndex = 0;

    void Start() {
        // Ensure the first line is displayed at the start
        textDisplay.text = miamiIntro[currentIndex];

        // Attach the button interaction event
        if (laserButton != null) {
            laserButton.selectEntered.AddListener(OnButtonClicked);
        }
    }

    private void OnButtonClicked(SelectEnterEventArgs args) {
        // Move to the next line when the button is selected
        if (currentIndex < miamiIntro.Length - 1) {
            currentIndex++;
            textDisplay.text = miamiIntro[currentIndex];
        }
    }
}
