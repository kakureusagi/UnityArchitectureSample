using System;
using UniRx;

namespace MvpSample {

	public class DialogUseCaseBase {

		public IObservable<Unit> OnClose => onClose;
		readonly Subject<Unit> onClose = new Subject<Unit>();
		


		protected void Close() {
			onClose.OnNext(Unit.Default);
		}
	}

}