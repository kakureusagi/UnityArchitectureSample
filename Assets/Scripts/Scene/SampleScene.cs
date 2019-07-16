using UniRx.Async;
using UnityEngine;

namespace MvpSample {

	public class SampleScene : SceneBase {

		[SerializeField]
		private SampleScenePresenter presenter;

		protected override async UniTask Start() {
			await base.Start();
			SampleSceneModel model = new SampleSceneModel(dialogFactory);
			presenter.Initialize(model);
			presenter.Run();
		}

	}

}