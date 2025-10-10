using UnityEngine;

public class Interactable : MonoBehaviour
{
    public enum CameraFocusType { Resting, Monitor, Caseboard }

    [SerializeField] private CameraFocusType focusType;

    public CameraFocusType FocusType => focusType;
}
