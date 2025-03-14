using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportScript : MonoBehaviour {
    public string sceneToLoad; // Set in the Inspector

    private void Start() {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        if (interactable != null) {
            interactable.selectEntered.AddListener(OnTeleport);
        }
    }

    private void OnTeleport(SelectEnterEventArgs args) {
        SceneManager.LoadScene(sceneToLoad);
    }
}
