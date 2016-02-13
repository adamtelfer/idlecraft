using UnityEngine;
using System.Collections;
using Assets;

public class FactoryPurchasePopupView : MonoBehaviour {

    public GameObject ListContainer;
    public GameObject prefab;

	// Use this for initialization
	void Start () {
        AddCell(new Factory());
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void PurchaseAndClose (Factory f)
    {
        GameState.sharedState.AddFactory(f);
        Close();
    }

    public void AddCell(Factory f)
    {
        GameObject g = Instantiate(prefab);
        g.transform.SetParent(ListContainer.transform);
        g.transform.localScale = new Vector3(1f, 1f, 1f);

        FactoryPurchaseCell cell = g.GetComponent<FactoryPurchaseCell>();
        cell.SetFactory(f);
        cell.parentView = this;

        RectTransform rect = ListContainer.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(0f, g.GetComponent<RectTransform>().rect.height * ListContainer.transform.childCount);
    }

    public void Close()
    {
        RootViewManager.sharedManager.PopView(this.GetComponent<RectTransform>());
    }
}
