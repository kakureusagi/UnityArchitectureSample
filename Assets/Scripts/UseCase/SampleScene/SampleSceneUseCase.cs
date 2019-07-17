using UniRx;
using UnityEngine;

namespace MvpSample {

	public class SampleSceneUseCase {

		readonly IDialogFactory dialogFactory;


		public SampleSceneUseCase(IDialogFactory dialogFactory) {
			this.dialogFactory = dialogFactory;
		}

		public void OnDialogButton() {
			var dialog = new OneButtonDialogUseCsae("ダイアログのタイトル", "ダイアログの本文");
			dialog.OnClose.Subscribe(_ => Debug.Log("ダイアログ閉じた"));
				
			dialogFactory.Create(dialog);
		}
	}

}