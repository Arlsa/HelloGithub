using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadStage2 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("Stage2");
    }
}

