using UniRx.Async;
using UnityEngine;

#pragma warning disable 0649

namespace MvpSample {

	public class SampleScene : SceneBase {

		[SerializeField]
		private SampleScenePresenter presenter;

		protected override async UniTask Start() {
			await base.Start();
			SampleSceneUseCase useCase = new SampleSceneUseCase(dialogFactory);
			presenter.Initialize(useCase);
			presenter.Run();
		}

	}

}