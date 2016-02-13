using UnityEngine;
using System.Collections;

public class RootViewManager : MonoBehaviour {

    public RectTransform PopUpRoot;
    public RectTransform PoolRoot;

    public RectTransform PurchaseFactoryPopUp;

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
        this.PushView(PurchaseFactoryPopUp);
    }

    public void PushView (RectTransform rect)
    {
        rect.SetParent(PopUpRoot);
        rect.anchoredPosition = new Vector2(0f, 0f);
        
    }

    public void PopView (RectTransform rect)
    {
        rect.SetParent(PoolRoot);
        rect.anchoredPosition = new Vector2(0f, 0f);
    }
}
