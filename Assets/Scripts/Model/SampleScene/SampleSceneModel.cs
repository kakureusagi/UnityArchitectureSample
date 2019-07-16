using UniRx;
using UnityEngine;

namespace MvpSample {

	public class SampleSceneModel {

		readonly IDialogFactory dialogFactory;


		public SampleSceneModel(IDialogFactory dialogFactory) {
			this.dialogFactory = dialogFactory;
		}

		public void OnDialogButton() {
			var dialog = new OneButtonDialogModel("ダイアログのタイトル", "ダイアログの本文");
			dialog.OnClose.Subscribe(_ => Debug.Log("ダイアログ閉じた"));
				
			dialogFactory.Create(dialog);
		}
	}

}