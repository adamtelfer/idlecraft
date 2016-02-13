using UnityEngine;
using System.Collections;
using Assets;

public class ResourceView : MonoBehaviour {

    public System.Collections.Generic.List<SingleResourceView> resourceViews;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    foreach (SingleResourceView resourceView in resourceViews)
        {
            Economy cEconomy = GameState.sharedState.currentEconomy;
            resourceView.text.text = cEconomy.getValueForType(resourceView.type).ToString();
        }
	}
}
