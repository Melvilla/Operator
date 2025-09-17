using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ComputerUIManager : MonoBehaviour
{
    [Header("Screens")]
    [SerializeField] GameObject LoginScreen;
    [SerializeField] GameObject EmailScreen;

    [Header("Login UI")]
    [SerializeField] TMP_InputField UsernameInput;
    [SerializeField] TMP_InputField PasswordInput;
    [SerializeField] Button LoginButton;
    [SerializeField] TMP_Text ErrorText;

    // Set your credentials here
    [SerializeField] string CorrectUsername = "Randy Pitchford";
    [SerializeField] string CorrectPassword = "ILov3Mon3y";

    void Start()
    {
        LoginButton.onClick.AddListener(OnLoginClicked);
        ShowLoginScreen();
    }

    private void OnLoginClicked()
    {
        if (UsernameInput.text == CorrectUsername && PasswordInput.text == CorrectPassword)
        {
            ShowEmailScreen();
        }
        else
        {
            UsernameInput.text = "";
            PasswordInput.text = "";
            ErrorText.text = "Invalid username or password, please try again";
            StartCoroutine(HideErrorTextAfterDelay(5f));
        }
    }

    private IEnumerator HideErrorTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ErrorText.text = "";
    }

    private void ShowLoginScreen()
    {
        LoginScreen.SetActive(true);
        EmailScreen.SetActive(false);
        ErrorText.text = "";
    }

    private void ShowEmailScreen()
    {
        LoginScreen.SetActive(false);
        EmailScreen.SetActive(true);
    }
}
