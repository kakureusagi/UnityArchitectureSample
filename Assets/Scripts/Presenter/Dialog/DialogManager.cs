using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace MvpSample {

	public class DialogManager : MonoBehaviour {
		
		[SerializeField]
		Transform root;


		readonly List<DialogPresenterBase> presenters = new List<DialogPresenterBase>();


		public void Add(DialogPresenterBase presenter) {
			presenter.transform.SetParent(root);
			presenter.transform.localPosition = Vector3.zero;
			presenter.transform.localRotation = Quaternion.identity;
			presenter.transform.localScale = Vector3.one;
			presenters.Add(presenter);

			presenter.OnDestroyAsObservable().Subscribe(_ => presenters.Remove(presenter));
		}
	}

}