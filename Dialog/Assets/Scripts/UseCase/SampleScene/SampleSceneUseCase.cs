using UniRx;
using UnityEngine;

namespace MvpSample {

	public class SampleSceneUseCase {

		readonly IDialogFactory dialogFactory;


		public SampleSceneUseCase(IDialogFactory dialogFactory) {
			this.dialogFactory = dialogFactory;
		}

		public void OnOneDialogButton() {
			var dialog = new OneButtonDialogUseCase("ダイアログのタイトル", "ダイアログの本文");
			dialog.OnClose.Subscribe(_ => Debug.Log("１ボタンダイアログを閉じた"));
				
			dialogFactory.Create(dialog);
		}

		public void OnTwoButtonDialogButton() {
			var dialog = new TwoButtonDialogUseCase("ダイアログのタイトル", "ダイアログの本文");
			dialog.OnOk.Subscribe(_ => Debug.Log("２ボタンダイアログを閉じた。OK"));
			dialog.OnCancel.Subscribe(_ => Debug.Log("２ボタンダイアログを閉じた。キャンセル"));
				
			dialogFactory.Create(dialog);
		}
	}

}