using UniRx;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable 0649

namespace MvpSample {

	public class SampleScenePresenter : MonoBehaviour {
		
		[SerializeField]
		Button oneDialogButton;
		
		[SerializeField]
		Button twoDialogButton;

		SampleSceneUseCase useCase;

		
		public void Initialize(SampleSceneUseCase useCase) {
			this.useCase = useCase;
		}

		public void Run() {
			oneDialogButton.OnClickAsObservable()
				.Subscribe(_ => useCase.OnOneDialogButton())
				.AddTo(this);
			
			twoDialogButton.OnClickAsObservable()
				.Subscribe(_ => useCase.OnTwoButtonDialogButton())
				.AddTo(this);
		}
	}

}