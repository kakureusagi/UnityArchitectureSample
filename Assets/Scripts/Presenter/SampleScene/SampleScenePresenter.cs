using UniRx;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable 0649

namespace MvpSample {

	public class SampleScenePresenter : MonoBehaviour {
		
		[SerializeField]
		private Button dialogButton;

		SampleSceneUseCase useCase;

		
		public void Initialize(SampleSceneUseCase useCase) {
			this.useCase = useCase;
		}

		public void Run() {
			dialogButton.OnClickAsObservable()
				.Subscribe(_ => useCase.OnDialogButton())
				.AddTo(this);
		}
	}

}