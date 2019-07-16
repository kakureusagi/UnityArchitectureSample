using UniRx;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable 0649

namespace MvpSample {

	public class SampleScenePresenter : MonoBehaviour {
		
		[SerializeField]
		private Button dialogButton;

		SampleSceneModel model;

		
		public void Initialize(SampleSceneModel model) {
			this.model = model;
		}

		public void Run() {
			dialogButton.OnClickAsObservable()
				.Subscribe(_ => model.OnDialogButton())
				.AddTo(this);
		}
	}

}