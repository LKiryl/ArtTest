using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    [SerializeField] private GameObject _uiCanvas;
    [SerializeField] private GameObject _prefabPopUp;

    private GameObject _currentPopUp = null;
    

    public void CreatePopUp()
    {
        AudioManager.Instance.PlayButtonSound();
        if( _currentPopUp == null)
        {
            _currentPopUp = Instantiate(_prefabPopUp, _uiCanvas.transform);

            GameObject cancel_B = _currentPopUp.transform.Find("cancel_B").gameObject;
            Button cancel_button = cancel_B.GetComponent<Button>();
            cancel_button.onClick.AddListener(CancelPopUp);

            GameObject ok_B = _currentPopUp.transform.Find("ok_B").gameObject;
            Button ok_button = ok_B.GetComponent<Button>();
            ok_button.onClick.AddListener(Quit);

            return;
        }
        _currentPopUp.SetActive(true);

    }

    
    private void CancelPopUp()
    {
        AudioManager.Instance.PlayButtonSound();
        _currentPopUp.SetActive(false);
    }

    private void Quit()
    {
        Application.Quit();
    }
}
