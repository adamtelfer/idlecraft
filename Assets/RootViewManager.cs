﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class RootViewManager : MonoBehaviour {

    public RectTransform PopUpRoot;
    public RectTransform PoolRoot;

    public FactoryPurchasePopupView PurchaseFactoryPopUp;
    public FactoryUpgradePopupView PurchaseUpgradePopup;
    public MarketPopupView MarketPopup;

    public static RootViewManager sharedManager = null;

    // Use this for initialization
    void Start () {
        sharedManager = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenPurchaseFactoryPopup()
    {
        this.PushView(PurchaseFactoryPopUp.gameObject);
        PurchaseFactoryPopUp.OnPopUpOpen();
    }

    public void OpenMarket()
    {
        this.PushView(MarketPopup.gameObject);
        MarketPopup.OnPopUpOpen();
    }

    //Currently Open Screen
    private Animator m_Open;

    //Hash of the parameter we use to control the transitions.
    private int m_OpenParameterId;

    //The GameObject Selected before we opened the current Screen.
    //Used when closing a Screen, so we can go back to the button that opened it.
    private GameObject m_PreviouslySelected;

    //Animator State and Transition names we need to check against.
    const string k_OpenTransitionName = "Open";
    const string k_ClosedStateName = "Closed";

    public void PushView (GameObject newGameObject)
    {
        RectTransform rect = newGameObject.GetComponent<RectTransform>();
        Animator anim = newGameObject.GetComponent<Animator>();
        newGameObject.SetActive(true);

        rect.SetParent(PopUpRoot);
        rect.anchoredPosition = new Vector2(0f, 0f);

        if (m_Open == anim)
            return;

        //Save the currently selected button that was used to open this Screen. (CloseCurrent will modify it)
        GameObject newPreviouslySelected = EventSystem.current.currentSelectedGameObject;
        //Move the Screen to front.
        anim.transform.SetAsLastSibling();

        CloseCurrent();

        m_PreviouslySelected = newPreviouslySelected;

        //Set the new Screen as then open one.
        m_Open = anim;
        //Start the open animation
        m_Open.SetBool(m_OpenParameterId, true);

        //Set an element in the new screen as the new Selected one.
        GameObject go = FindFirstEnabledSelectable(anim.gameObject);
        SetSelected(go);

    }

    public void OnEnable()
    {
        m_OpenParameterId = Animator.StringToHash(k_OpenTransitionName);
    }

    //Finds the first Selectable element in the providade hierarchy.
    private static GameObject FindFirstEnabledSelectable(GameObject gameObject)
    {
        GameObject go = null;
        var selectables = gameObject.GetComponentsInChildren<Selectable>(true);
        foreach (var selectable in selectables)
        {
            if (selectable.IsActive() && selectable.IsInteractable())
            {
                go = selectable.gameObject;
                break;
            }
        }
        return go;
    }

    //Closes the currently open Screen
    //It also takes care of navigation.
    //Reverting selection to the Selectable used before opening the current screen.
    public void CloseCurrent()
    {
        if (m_Open == null)
            return;

        //Start the close animation.
        m_Open.SetBool(m_OpenParameterId, false);

        //Reverting selection to the Selectable used before opening the current screen.
        SetSelected(m_PreviouslySelected);
        //Start Coroutine to disable the hierarchy when closing animation finishes.
        StartCoroutine(DisablePanelDeleyed(m_Open));
        //No screen open.
        m_Open = null;
    }

    //Coroutine that will detect when the Closing animation is finished and it will deactivate the
    //hierarchy.
    IEnumerator DisablePanelDeleyed(Animator anim)
    {
        bool closedStateReached = false;
        bool wantToClose = true;
        while (!closedStateReached && wantToClose)
        {
            if (!anim.IsInTransition(0))
                closedStateReached = anim.GetCurrentAnimatorStateInfo(0).IsName(k_ClosedStateName);

            wantToClose = !anim.GetBool(m_OpenParameterId);

            yield return new WaitForEndOfFrame();
        }

        if (wantToClose)
        {
            RectTransform rect = anim.gameObject.GetComponent<RectTransform>();
            rect.SetParent(PoolRoot);
            rect.anchoredPosition = new Vector2(0f, 0f);
            anim.gameObject.SetActive(false);
        }
    }

    //Make the provided GameObject selected
    //When using the mouse/touch we actually want to set it as the previously selected and 
    //set nothing as selected for now.
    private void SetSelected(GameObject go)
    {
        //Select the GameObject.
        EventSystem.current.SetSelectedGameObject(go);

        //If we are using the keyboard right now, that's all we need to do.
        var standaloneInputModule = EventSystem.current.currentInputModule as StandaloneInputModule;
        if (standaloneInputModule != null && standaloneInputModule.inputMode == StandaloneInputModule.InputMode.Buttons)
            return;

        //Since we are using a pointer device, we don't want anything selected. 
        //But if the user switches to the keyboard, we want to start the navigation from the provided game object.
        //So here we set the current Selected to null, so the provided gameObject becomes the Last Selected in the EventSystem.
        EventSystem.current.SetSelectedGameObject(null);
    }
}
