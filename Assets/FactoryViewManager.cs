using UnityEngine;
using System.Collections;
using Assets;

public class FactoryViewManager : MonoBehaviour {

    public GameObject factoryViewPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddFactory(Factory f)
    {
        GameObject g = Instantiate(factoryViewPrefab);
        g.transform.SetParent(this.transform);
        g.transform.localScale = new Vector3(1f, 1f, 1f);
        FactoryView fView = g.GetComponent<FactoryView>();
        fView.SetFactory(f);

        RectTransform rect = this.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(0f, g.GetComponent<RectTransform>().rect.height * this.transform.childCount);
    }
}
