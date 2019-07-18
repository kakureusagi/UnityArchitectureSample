using System;
using UniRx;

namespace MvpSample {

	public class TwoButtonDialogUseCase : DialogUseCaseBase {

		public string Title { get; }
		public string Body { get; }

		
		public IObservable<Unit> OnOk => onOk;
		readonly Subject<Unit> onOk = new Subject<Unit>();
		
		public IObservable<Unit> OnCancel => onCancel;
		readonly Subject<Unit> onCancel = new Subject<Unit>();

		
		public TwoButtonDialogUseCase(string title, string body) {
			Title = title;
			Body = body;
		}

		public void OnOkButton() {
			onOk.OnNext(Unit.Default);
			Close();
		}

		public void OnCancelButton() {
			onCancel.OnNext(Unit.Default);
			Close();
		}

	}

}