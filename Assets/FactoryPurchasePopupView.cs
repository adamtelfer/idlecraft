using UnityEngine;
using System.Collections;
using Assets;

public class FactoryPurchasePopupView : MonoBehaviour {

    public GameObject ListContainer;
    public GameObject prefab;
    public System.Collections.Generic.List<FactoryPurchaseCell> cells;

	// Use this for initialization
	void Start () {
        cells = new System.Collections.Generic.List<FactoryPurchaseCell>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void PurchaseAndClose (FactoryConfig f)
    {
        if (GameState.sharedState.CanPurchaseFactory(f))
        {
            GameState.sharedState.PurchaseFactory(f);
            Close();
        } else
        {
            Debug.LogError("Could not purchase");
        }
    }

    public void Close()
    {
        RootViewManager.sharedManager.CloseCurrent();
    }

    public void AddCell(FactoryConfig f)
    {
        GameObject g = Instantiate(prefab);
        g.transform.SetParent(ListContainer.transform);
        g.transform.localScale = new Vector3(1f, 1f, 1f);

        FactoryPurchaseCell cell = g.GetComponent<FactoryPurchaseCell>();
        cell.SetFactory(f);
        cell.parentView = this;
        cells.Add(cell);

        RectTransform rect = ListContainer.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(0f, g.GetComponent<RectTransform>().rect.height * ListContainer.transform.childCount);
    }

    public void OnPopUpOpen()
    {
        Debug.Log("OnPopUpOpen");
        if (cells.Count <= 0)
        {
            foreach (FactoryConfig f in Config.masterConfig.factoryTypes.Values)
            {
                AddCell(f);
            }
        } else
        {
            foreach (FactoryPurchaseCell cell in cells)
            {
                cell.SetFactory(cell.factoryToPurchase);
            }
        }
    }

    public void OnPopUpClosed()
    {
        Debug.Log("OnPopUpClosed");
    }

    
}
